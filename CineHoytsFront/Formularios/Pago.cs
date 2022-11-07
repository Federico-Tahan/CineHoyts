using Cine_Hoyts.Datos;
using Cine_Hoyts.Dominio;
using CineHoytsBack.Dominio.Campos;
using CineHoytsFront.Servicio;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cine_Hoyts.Formularios
{
    public partial class Pago : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        int modo = 0;

        Factura f = new Factura();
        public Pago(Factura fac)
        {
            InitializeComponent();
            f = fac;
        }

        private async void Pago_Load(object sender, EventArgs e)
        {
            txbVendedor.Text = Login.v.per.Nombre + " " + Login.v.per.Apellido;
            await CargarCboTipoCompra();
            await CargarComboAsyncFormaPago();
            if (f.id_cliente == 0)
            {
                await CargarCboClientes();
            }
            else
            {
                rbtPosponer.Visible = false;
                cboCliente.Enabled = false;
                cboCliente.Text = f.cliente.per.Nombre + "" + f.cliente.per.Apellido;
                modo = 1;
            }


        }
        private async Task CargarComboAsyncFormaPago()
        {
            string url = "https://localhost:7271/api/Tablas/FormaPago";
            var data = await ClaseSingleton.GetInstance().GetAsync(url);
            List<FormaPago> lst = JsonConvert.DeserializeObject<List<FormaPago>>(data);
            cboFormaPago.DataSource = lst;
            cboFormaPago.ValueMember = "IdFormaPago";
            cboFormaPago.DisplayMember = "Formapago";
            cboFormaPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFormaPago.SelectedIndex = -1;

        }
        private async Task CargarCboTipoCompra()
        {
            string url = "https://localhost:7271/api/Tablas/TipoCompraCBO";
            var data = await ClaseSingleton.GetInstance().GetAsync(url);
            List<TipoCompra> lst = JsonConvert.DeserializeObject<List<TipoCompra>>(data);
            cboTipoCompra.DataSource = lst;
            cboTipoCompra.ValueMember = "Id_tipoCompra";
            cboTipoCompra.DisplayMember = "TipocOMRPA";
            cboTipoCompra.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoCompra.SelectedIndex = -1;

        }
        private async Task CargarCboClientes()
        {
            string url = "https://localhost:7271/api/Tablas/ClientesCBO";
            var data = await ClaseSingleton.GetInstance().GetAsync(url);
            List<Cliente> lst = JsonConvert.DeserializeObject<List<Cliente>>(data);
            cboCliente.DataSource = lst;
            cboCliente.ValueMember = "Id_Cliente";
            cboCliente.DisplayMember = "nombreCBO";
            cboCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCliente.SelectedIndex = -1;

        }


        private void picCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chPosponer_CheckedChanged(object sender, EventArgs e)
        {
            cboTipoCompra.SelectedIndex = -1; cboTipoCompra.Enabled = !cboTipoCompra.Enabled; cboTipoCompra.Visible = !cboTipoCompra.Visible;
            cboFormaPago.SelectedIndex = -1; cboFormaPago.Enabled = !cboFormaPago.Enabled; cboFormaPago.Visible = !cboFormaPago.Visible;
            lbpago.Visible = cboFormaPago.Visible;
            lbcompra.Visible = cboTipoCompra.Visible;
        }

        public void abstraer_Factura()
        {
            f.id_vendedor = Login.v.Id_Vendedor;
            f.id_cliente = Convert.ToInt32(cboCliente.SelectedValue);
            if (rbtPosponer.Checked == true)
            {
                f.id_Forma_Pago = -1;
                f.id_Tipo_Compra = -1;
                f.fecha_Pago = DateTime.MinValue.ToShortDateString();
            }
            else
            {
                f.id_Forma_Pago = Convert.ToInt32(cboFormaPago.SelectedValue);
                f.id_Tipo_Compra = Convert.ToInt32(cboTipoCompra.SelectedValue);
                f.fecha_Pago = DateTime.Now.ToShortDateString();
            }
            f.fecha_Reserva = DateTime.Now.ToShortDateString();

        }

        public bool validar()
        {
            if(cboCliente.SelectedIndex == -1 && f.id_cliente == 0)
            {
                MessageBox.Show("Debe cargar el cliente");
                return false;
            }
            if (rbtPosponer.Checked == false)
            {
                if (cboFormaPago.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe cargar la forma de pago");
                    return false;
                }
                if (cboTipoCompra.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe cargar el tipo de compra");
                    return false;
                }
            }

            return true;
        }

        private async void btnConfirmar_Click_1(object sender, EventArgs e)
        {
            try
            {

            
                if (validar())
                {
                    abstraer_Factura();
                    if (modo == 0)
                    {
                        if (rbtPosponer.Checked == true)
                        {
                            if (await Pago_Reserva(f))
                            {
                                if (MessageBox.Show("Reserva Cargada Correctamente", "", MessageBoxButtons.OK) == DialogResult.OK)
                                {
                                    this.DialogResult = DialogResult.OK;
                                    this.Close();
                                }
                            }
                        }
                        else
                        {
                            if (await Pago_Concret(f))
                            {
                                if (MessageBox.Show("Reserva Cargada Correctamente", "", MessageBoxButtons.OK) == DialogResult.OK)
                                {
                                    this.DialogResult = DialogResult.OK;
                                    this.Close();
                                }
                            }

                        }
                    }
                    else
                    {
                        if (await Actualizar_Reserva(f))
                        {
                            if (MessageBox.Show("Reserva Pagada con Exito", "", MessageBoxButtons.OK) == DialogResult.OK)
                            {
                                this.DialogResult = DialogResult.OK;
                                this.Close();
                            }
                        }
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Contacte con el proveedor");
            }
        }

        public async Task<bool> Pago_Concret(Factura pm)
        {
            string FiltrosJson = JsonConvert.SerializeObject(pm);
            string url = "https://localhost:7271/api/CRUDfactura/PostFacturas";
            var data = await ClaseSingleton.GetInstance().PostAsync(url, FiltrosJson);

            return JsonConvert.DeserializeObject<bool>(data);
        }

        public async Task<bool> Pago_Reserva(Factura pm)
        {
            bool bandera = false;
            string FiltrosJson = JsonConvert.SerializeObject(pm);
            string url = "https://localhost:7271/api/CRUDfactura/PostReserva";
            var data = await ClaseSingleton.GetInstance().PostAsync(url, FiltrosJson);

            if (JsonConvert.DeserializeObject<bool>(data))
            {
                bandera = true;
            }
            return bandera;
        }

        public async Task<bool> Actualizar_Reserva(Factura pm)
        {
            string FiltrosJson = JsonConvert.SerializeObject(pm);
            string url = "https://localhost:7271/api/CRUDfactura/PutPago";
            var data = await ClaseSingleton.GetInstance().PostAsync(url, FiltrosJson);

            return JsonConvert.DeserializeObject<bool>(data);
        }
    }
}
