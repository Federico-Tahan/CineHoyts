using Cine_Hoyts.Datos;
using Cine_Hoyts.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using CineHoytsBack.Dominio.Campos;
using CineHoytsFront.Servicio;

namespace Cine_Hoyts.Formularios
{
    public partial class ConFactura : Form
    {
        List<Factura> LFactura = new List<Factura>();
        Factura f = new Factura();
        public ConFactura()
        {
            InitializeComponent();
            this.toolTip1.SetToolTip(this.pctFilter, "Filtros avanzados");
            this.toolTip1.SetToolTip(this.picreset, "Reiniciar filtros");
        }

        private void pnltop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pctFilter_Click(object sender, EventArgs e)
        {
            if (pnlFiltro.Visible == true)
            {
                pnlFiltro.Visible = false;
            }
            else
            {
                pnlFiltro.Visible = true;

            }
        }

        private async void ConFactura_Load(object sender, EventArgs e)
        {
            pnlFiltro.Visible = false;
            await CargarComboAsyncFormaPago();
            await CargarCboVendedor();
            await CargarCboTipoCompra();
                await Cargar_Facturas_concret();
            cargar_datagrid_factura();



        }

        private async Task Cargar_Facturas_concret()
        {
            string url = "https://localhost:7271/api/CRUDfactura/GetFacturaConcret";
            var data = await ClaseSingleton.GetInstance().GetAsync(url);
            LFactura = JsonConvert.DeserializeObject<List<Factura>>(data);
            if (data == "")
            {
                MessageBox.Show("Demasiadas solicitudes, intentelo de nuevo más tarde");
            }
            else
            {
                foreach (Factura item in LFactura)
                {
                    item.Lcomprobantes = await Cargar_Detalle_Factura(item.id_Factura);
                }
            }

        }


        private async Task Cargar_Facturas_concret_name(string str)
        {
            string url = "https://localhost:7271/api/CRUDfactura/GetFacturaConClientefilter?f=" + str;
            var data = await ClaseSingleton.GetInstance().GetAsync(url);
            LFactura = JsonConvert.DeserializeObject<List<Factura>>(data);
            if (data == "")
            {
                MessageBox.Show("Demasiadas solicitudes, intentelo de nuevo más tarde");
            }
            else
            {
                foreach (Factura item in LFactura)
                {
                    item.Lcomprobantes = await Cargar_Detalle_Factura(item.id_Factura);
                }
            }

        }

        private async Task<List<Comprobante>> Cargar_Detalle_Factura(int f)
        {
            string url = "https://localhost:7271/api/CRUDfactura/GetDetalle?f=" + f.ToString();
            var data = await ClaseSingleton.GetInstance().GetAsync(url);
            return JsonConvert.DeserializeObject<List<Comprobante>>(data);
        }
        private void cargar_datagrid_factura()
        {
            dgvFactura.Rows.Clear();
            if (LFactura is null)
            {

            }
            else
            {
                foreach (Factura f in LFactura)
                {
                    try
                    {
                        dgvFactura.Rows.Add(f.id_Factura.ToString(), f.vendedor.per.Nombre + " " + f.vendedor.per.Apellido, f.cliente.per.Nombre + " " + f.cliente.per.Apellido,
                        f.fecha_Reserva, f.tipoCompra, f.formaPago, "$ " + f.calcular_total_con().ToString());
                    }
                    catch (Exception)
                    {

                    }
                }
            }
            
        }
        private async Task CargarComboAsyncFormaPago()
        {
            string url = "https://localhost:7271/api/Tablas/FormaPago";
            var data = await ClaseSingleton.GetInstance().GetAsync(url);
            List<FormaPago> lst = JsonConvert.DeserializeObject<List<FormaPago>>(data);
            cboFormapago.DataSource = lst;
            cboFormapago.ValueMember = "IdFormaPago";
            cboFormapago.DisplayMember = "Formapago";
            cboFormapago.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFormapago.SelectedIndex = -1;

        }

        private async Task CargarCboVendedor()
        {
            string url = "https://localhost:7271/api/Tablas/VendedoresCBO";
            var data = await ClaseSingleton.GetInstance().GetAsync(url);
            List<Vendedor> lst = JsonConvert.DeserializeObject<List<Vendedor>>(data);
            cbovendedor.DataSource = lst;
            cbovendedor.ValueMember = "Id_Vendedor";
            cbovendedor.DisplayMember = "nombreCBO";
            cbovendedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cbovendedor.SelectedIndex = -1;

        }

        private async Task CargarCboTipoCompra()
        {
            string url = "https://localhost:7271/api/Tablas/TipoCompraCBO";
            var data = await ClaseSingleton.GetInstance().GetAsync(url);
            List<TipoCompra> lst = JsonConvert.DeserializeObject<List<TipoCompra>>(data);
            cboTipocompra.DataSource = lst;
            cboTipocompra.ValueMember = "Id_tipoCompra";
            cboTipocompra.DisplayMember = "TipocOMRPA";
            cboTipocompra.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipocompra.SelectedIndex = -1;

        }
        private async void picreset_Click(object sender, EventArgs e)
        {
            await Cargar_Facturas_concret();
            cargar_datagrid_factura();
            txbCliente.Text = "";
            cboFormapago.SelectedIndex = -1;
            cboTipocompra.SelectedIndex = -1;
            cbovendedor.SelectedIndex = -1;
            numeric.Value = 0;
            dtpFin.Value = DateTime.Now.Date;
            dtpInicio.Value = DateTime.Now.Date;
            pnlFiltro.Visible = false;


        }

        private async void btnBuscar_Click_1(object sender, EventArgs e)
        {
            cargar_datagrid_factura();
            pnlFiltro.Visible = false;
            if (txbCliente.Text != "")
            {
                await Cargar_Facturas_concret_name(txbCliente.Text);
                cargar_datagrid_factura();
            }

            if (cbovendedor.SelectedIndex != -1)
            {
                List<DataGridViewRow> temp = new List<DataGridViewRow>();

                foreach (DataGridViewRow row in dgvFactura.Rows)
                {
                    if (Convert.ToString(row.Cells["vendedor"].Value) != cbovendedor.Text)
                    {
                        temp.Add(row);
                    }

                }

                foreach (DataGridViewRow row in temp)
                {

                    dgvFactura.Rows.Remove(row);

                }
            }
            if (cboFormapago.SelectedIndex != -1)
            {
                List<DataGridViewRow> temp = new List<DataGridViewRow>();

                foreach (DataGridViewRow row in dgvFactura.Rows)
                {
                    if (Convert.ToString(row.Cells["Formapago"].Value) != cboFormapago.Text)
                    {
                        temp.Add(row);
                    }

                }

                foreach (DataGridViewRow row in temp)
                {

                    dgvFactura.Rows.Remove(row);

                }
            }
            if (cboTipocompra.SelectedIndex != -1)
            {
                List<DataGridViewRow> temp = new List<DataGridViewRow>();

                foreach (DataGridViewRow row in dgvFactura.Rows)
                {
                    if (Convert.ToString(row.Cells["tipocompra"].Value) != cboTipocompra.Text)
                    {
                        temp.Add(row);
                    }

                }

                foreach (DataGridViewRow row in temp)
                {

                    dgvFactura.Rows.Remove(row);

                }
            }
            if (dtpInicio.Value.Date != DateTime.Now.Date)
            {
                List<DataGridViewRow> temp = new List<DataGridViewRow>();

                foreach (DataGridViewRow row in dgvFactura.Rows)
                {
                    if (Convert.ToDateTime(row.Cells["fecha"].Value) < dtpInicio.Value || Convert.ToDateTime(row.Cells["fecha"].Value) >= dtpFin.Value)
                    {
                        temp.Add(row);
                    }

                }

                foreach (DataGridViewRow row in temp)
                {

                    dgvFactura.Rows.Remove(row);

                }
            }
            if (numeric.Value != 0)
            {
                List<DataGridViewRow> temp = new List<DataGridViewRow>();

                foreach (DataGridViewRow row in dgvFactura.Rows)
                {
                    if (Convert.ToDecimal(row.Cells["total"].Value) < Convert.ToDecimal(numeric.Value))
                    {
                        temp.Add(row);
                    }

                }

                foreach (DataGridViewRow row in temp)
                {

                    dgvFactura.Rows.Remove(row);

                }
            }
        }
    }
}
