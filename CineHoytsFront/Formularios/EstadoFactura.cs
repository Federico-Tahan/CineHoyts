using Cine_Hoyts.Dominio;
using CineHoytsBack.Dominio;
using CineHoytsFront.Properties;
using CineHoytsFront.Servicio;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cine_Hoyts.Formularios
{
    public partial class EstadoFactura : Form
    {
        List<Factura> LFactura = new List<Factura>();
        Factura f = new Factura();
        List<Butaca> but = new List<Butaca>();

        public EstadoFactura()
        {
            InitializeComponent();
            this.toolTip1.SetToolTip(this.picdesplegar, "Ocultar detalle");

        }

        private async void EstadoFactura_Load(object sender, EventArgs e)
        {
            dgvComprobantes.Visible = false;
            picdesplegar.Visible = false;
            pnlButaca.Visible = false;
            BtnPagar.SendToBack();
            try
            {
                await cargar_Facturas();
            }catch (Exception)
            {
                MessageBox.Show("Demasiadas solicitudes, intentelo de nuevo mas tarde");
            }
        }
        private void cargar_datagrid_factura(List<Factura> LFactura)
        {
            dgvFacturas.Rows.Clear();

            foreach (Factura f in LFactura)
            {
                Image estad;

                if (f.estado == 1)
                {
                    estad = Resources.eliminar;
                }
                else if (f.fecha_Pago != DateTime.MinValue.ToShortDateString())
                {
                    estad = Resources.cheque;
                }
                else
                {
                    estad = Resources.asd__1_;

                }


                if (f.fecha_Pago == DateTime.MinValue.ToShortDateString())
                {
                    dgvFacturas.Rows.Add(f.id_Factura.ToString(), Convert.ToString(f.id_vendedor) + " " + f.vendedor.per.Nombre + " " + f.vendedor.per.Apellido,
                    Convert.ToString(f.id_cliente) + " " + f.cliente.per.Nombre + " " + f.cliente.per.Apellido,
                    f.tipoCompra, f.formaPago, "", f.fecha_Reserva, estad);
                }
                else
                {
                    dgvFacturas.Rows.Add(f.id_Factura.ToString(), Convert.ToString(f.id_vendedor) + " " + f.vendedor.per.Nombre + " " + f.vendedor.per.Apellido,
                    Convert.ToString(f.id_cliente) + " " + f.cliente.per.Nombre + " " + f.cliente.per.Apellido,
                    f.tipoCompra, f.formaPago, f.fecha_Pago, f.fecha_Reserva, estad);
                }

            }
        }
        private async Task cargar_Facturas()
        {
            HttpClient c = new HttpClient();
            string url = "https://localhost:7271/api/CRUDfactura/GetFacturas";
            var result = await c.GetAsync(url);
            var bodyJson = await result.Content.ReadAsStringAsync();
            if (bodyJson is null)
            {
                MessageBox.Show("Intentelo nuevamente más tarde");
            }
            else
            {
                LFactura = JsonConvert.DeserializeObject<List<Factura>>(bodyJson);
                cargar_datagrid_factura(LFactura);
            }


        }
        private async void dgvFacturas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            f = LFactura[dgvFacturas.CurrentRow.Index];
            f.Lcomprobantes = await Cargar_Detalle_Factura(f.id_Factura);
            cargar_total(f);
            cargar_data_grid_com();
            picdesplegar.Visible = true;
            dgvComprobantes.Visible = true;
            if (f.estado == 0 && f.fecha_Pago == DateTime.MinValue.ToShortDateString())
            {
                BtnPagar.Visible = true;
                btnBorrar.Visible = true;
            }

        }
        private async Task<List<Comprobante>> Cargar_Detalle_Factura(int f)
        {
            string url = "https://localhost:7271/api/CRUDfactura/GetDetalle?f=" + f.ToString();
            var data = await ClaseSingleton.GetInstance().GetAsync(url);
            return JsonConvert.DeserializeObject<List<Comprobante>>(data);
        }
        private void cargar_data_grid_com()
        {
            dgvComprobantes.Rows.Clear();

            foreach (Comprobante f in f.Lcomprobantes)
            {

               dgvComprobantes.Rows.Add(f.Fun.id_funcion.ToString(), f.Fun.Pelicula,f.Fun.Idioma,f.Fun.Fecha + ' ' + f.Fun.Hora.ToString(), "$ " +f.Total);


            }
        }
        private void picdesplegar_Click(object sender, EventArgs e)
        {
            if (pnlButaca.Visible == true)
            {
                pnlButaca.Visible = false;
            }
            else
            {
                picdesplegar.Visible = false;
                dgvComprobantes.Visible = false;

            }

            if (dgvComprobantes.Visible == false)
            {
                BtnPagar.Visible = false;
                btnBorrar.Visible = false;
            }

        }
        private async void dgvComprobantes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            reiniciar_butacas();
            but = await Cargar_Tickets(Convert.ToInt32(f.Lcomprobantes[dgvComprobantes.CurrentRow.Index].Fun.Id_sala), f.Lcomprobantes[dgvComprobantes.CurrentRow.Index].Fun.id_funcion, f.Lcomprobantes[dgvComprobantes.CurrentRow.Index].Id_comprobante);
            ocupar_butacas();
            pnlButaca.Visible = true;
        }
        private async Task<List<Butaca>> Cargar_Tickets(int sala, int fun, int id_comprobante)
        {
            string url = "https://localhost:7271/api/CRUDfactura/GetButacasOcupa?sala=" + sala.ToString() + "&funcion=" + fun.ToString() + "&id_comprobante=" + id_comprobante.ToString()
;
            var data = await ClaseSingleton.GetInstance().GetAsync(url);
            return JsonConvert.DeserializeObject<List<Butaca>>(data);
        }
        private void cargar_total(Factura f)
        {
            
            foreach (Comprobante item in f.Lcomprobantes)
            {

                if (item.Id_promocion == 1)
                {
                    item.Promocion = 50;
                }
                else if (item.Id_promocion == 2)
                {
                    item.Promocion = 80;

                }
                else if (item.Id_promocion == 3)
                {
                    item.Promocion = 25;
                }
                else if (item.Id_promocion == 4)
                {
                    item.Promocion = 40;

                }
                else if (item.Id_promocion == 5)
                {
                    item.Promocion = 30;
                }
                else
                {
                    item.Promocion = 35;

                }
                item.Total += item.monto * item.cantidad - (((item.monto * item.cantidad) * item.Promocion) / 100);
            }
        }
        private async void BtnPagar_Click_1(object sender, EventArgs e)
        {
            Pago p = new Pago(f);
            if (p.ShowDialog() == DialogResult.OK)
            {
                pnlButaca.Visible = false;
                dgvComprobantes.Visible = false;
                picdesplegar.Visible = false;
                btnBorrar.Visible = false;
                BtnPagar.Visible = false;
                await cargar_Facturas();
                cargar_datagrid_factura(LFactura);
            }
        }
        private void reiniciar_butacas()
        {
            picbut1.Image = Resources.vaciaaa;
            picbut2.Image = Resources.vaciaaa;
            picbut3.Image = Resources.vaciaaa;
            picbut4.Image = Resources.vaciaaa;
            picbut5.Image = Resources.vaciaaa;
            picbut6.Image = Resources.vaciaaa;
            picbut7.Image = Resources.vaciaaa;
            picbut8.Image = Resources.vaciaaa;
            picbut9.Image = Resources.vaciaaa;
            picbut10.Image = Resources.vaciaaa;
            picbut11.Image = Resources.vaciaaa;
            picbut12.Image = Resources.vaciaaa;
            picbut13.Image = Resources.vaciaaa;
            picbut15.Image = Resources.vaciaaa;
            picbut16.Image = Resources.vaciaaa;
            picbut17.Image = Resources.vaciaaa;
            picbut18.Image = Resources.vaciaaa;
            picbut19.Image = Resources.vaciaaa;
            picbut20.Image = Resources.vaciaaa;
            picbut21.Image = Resources.vaciaaa;
            picbut22.Image = Resources.vaciaaa;
            picbut23.Image = Resources.vaciaaa;
            picbut24.Image = Resources.vaciaaa;
            picbut25.Image = Resources.vaciaaa;
            picbut26.Image = Resources.vaciaaa;
            picbut27.Image = Resources.vaciaaa;
            picbut28.Image = Resources.vaciaaa;
            picbut29.Image = Resources.vaciaaa;
            picbut30.Image = Resources.vaciaaa;
            picbut31.Image = Resources.vaciaaa;
            picbut32.Image = Resources.vaciaaa;
            picbut33.Image = Resources.vaciaaa;
            picbut34.Image = Resources.vaciaaa;
            picbut35.Image = Resources.vaciaaa;
            picbut36.Image = Resources.vaciaaa;
            picbut37.Image = Resources.vaciaaa;
            picbut38.Image = Resources.vaciaaa;
            picbut39.Image = Resources.vaciaaa;
            picbut40.Image = Resources.vaciaaa;
            picbut41.Image = Resources.vaciaaa;
            picbut42.Image = Resources.vaciaaa;
            picbut43.Image = Resources.vaciaaa;
            picbut44.Image = Resources.vaciaaa;
            picbut45.Image = Resources.vaciaaa;
            picbut46.Image = Resources.vaciaaa;
            picbut1.Enabled = true;
            picbut2.Enabled = true;
            picbut3.Enabled = true;
            picbut4.Enabled = true;
            picbut5.Enabled = true;
            picbut6.Enabled = true;
            picbut7.Enabled = true;
            picbut8.Enabled = true;
            picbut9.Enabled = true;
            picbut10.Enabled = true;
            picbut11.Enabled = true;
            picbut12.Enabled = true;
            picbut13.Enabled = true;
            picbut15.Enabled = true;
            picbut16.Enabled = true;
            picbut17.Enabled = true;
            picbut18.Enabled = true;
            picbut19.Enabled = true;
            picbut20.Enabled = true;
            picbut21.Enabled = true;
            picbut22.Enabled = true;
            picbut23.Enabled = true;
            picbut24.Enabled = true;
            picbut25.Enabled = true;
            picbut26.Enabled = true;
            picbut27.Enabled = true;
            picbut28.Enabled = true;
            picbut29.Enabled = true;
            picbut30.Enabled = true;
            picbut31.Enabled = true;
            picbut32.Enabled = true;
            picbut33.Enabled = true;
            picbut34.Enabled = true;
            picbut35.Enabled = true;
            picbut36.Enabled = true;
            picbut37.Enabled = true;
            picbut38.Enabled = true;
            picbut39.Enabled = true;
            picbut40.Enabled = true;
            picbut41.Enabled = true;
            picbut42.Enabled = true;
            picbut43.Enabled = true;
            picbut44.Enabled = true;
            picbut45.Enabled = true;
            picbut46.Enabled = true;


        }
        private void ocupar_butacas()
        {
            foreach (Butaca b in but)
            {

                if (b.Fila == "A" && b.nro == 1)
                {
                    picbut1.Image = Resources.ia;
                    picbut1.Enabled = false;
                }
                else if (b.Fila == "A" && b.nro == 2)
                {
                    picbut2.Image = Resources.ia;
                    picbut2.Enabled = false;
                }
                else if (b.Fila == "A" && b.nro == 3)
                {
                    picbut3.Image = Resources.ia;
                    picbut3.Enabled = false;
                }
                else if (b.Fila == "A" && b.nro == 4)
                {
                    picbut4.Image = Resources.ia;
                    picbut4.Enabled = false;
                }
                else if (b.Fila == "A" && b.nro == 5)
                {
                    picbut5.Image = Resources.ia;
                    picbut5.Enabled = false;
                }
                else if (b.Fila == "B" && b.nro == 1)
                {
                    picbut6.Image = Resources.ia;
                    picbut6.Enabled = false;
                }
                else if (b.Fila == "B" && b.nro == 2)
                {
                    picbut7.Image = Resources.ia;
                    picbut7.Enabled = false;
                }
                else if (b.Fila == "B" && b.nro == 3)
                {
                    picbut8.Image = Resources.ia;
                    picbut8.Enabled = false;
                }
                else if (b.Fila == "B" && b.nro == 4)
                {
                    picbut9.Image = Resources.ia;
                    picbut9.Enabled = false;
                }
                else if (b.Fila == "B" && b.nro == 5)
                {
                    picbut10.Image = Resources.ia;
                    picbut10.Enabled = false;
                }
                else if (b.Fila == "C" && b.nro == 1)
                {
                    picbut11.Image = Resources.ia;
                    picbut11.Enabled = false;
                }
                else if (b.Fila == "C" && b.nro == 2)
                {
                    picbut12.Image = Resources.ia;
                    picbut12.Enabled = false;
                }
                else if (b.Fila == "C" && b.nro == 3)
                {
                    picbut13.Image = Resources.ia;
                    picbut13.Enabled = false;
                }
                else if (b.Fila == "C" && b.nro == 4)
                {
                    picbut15.Image = Resources.ia;
                    picbut15.Enabled = false;
                }
                else if (b.Fila == "C" && b.nro == 5)
                {
                    picbut16.Image = Resources.ia;
                    picbut16.Enabled = false;
                }
                else if (b.Fila == "D" && b.nro == 1)
                {
                    picbut17.Image = Resources.ia;
                    picbut17.Enabled = false;
                }
                else if (b.Fila == "D" && b.nro == 2)
                {
                    picbut18.Image = Resources.ia;
                    picbut18.Enabled = false;
                }
                else if (b.Fila == "D" && b.nro == 3)
                {
                    picbut19.Image = Resources.ia;
                    picbut19.Enabled = false;
                }
                else if (b.Fila == "D" && b.nro == 4)
                {
                    picbut20.Image = Resources.ia;
                    picbut20.Enabled = false;
                }
                else if (b.Fila == "D" && b.nro == 5)
                {
                    picbut21.Image = Resources.ia;
                    picbut21.Enabled = false;
                }
                else if (b.Fila == "E" && b.nro == 1)
                {
                    picbut22.Image = Resources.ia;
                    picbut22.Enabled = false;
                }
                else if (b.Fila == "E" && b.nro == 2)
                {
                    picbut23.Image = Resources.ia;
                    picbut23.Enabled = false;
                }
                else if (b.Fila == "E" && b.nro == 3)
                {
                    picbut24.Image = Resources.ia;
                    picbut24.Enabled = false;
                }
                else if (b.Fila == "E" && b.nro == 4)
                {
                    picbut25.Image = Resources.ia;
                    picbut25.Enabled = false;
                }
                else if (b.Fila == "E" && b.nro == 5)
                {
                    picbut26.Image = Resources.ia;
                    picbut26.Enabled = false;
                }
                else if (b.Fila == "F" && b.nro == 1)
                {
                    picbut27.Image = Resources.ia;
                    picbut27.Enabled = false;
                }
                else if (b.Fila == "F" && b.nro == 2)
                {
                    picbut28.Image = Resources.ia;
                    picbut28.Enabled = false;
                }
                else if (b.Fila == "F" && b.nro == 3)
                {
                    picbut29.Image = Resources.ia;
                    picbut29.Enabled = false;
                }
                else if (b.Fila == "F" && b.nro == 4)
                {
                    picbut30.Image = Resources.ia;
                    picbut30.Enabled = false;
                }
                else if (b.Fila == "F" && b.nro == 5)
                {
                    picbut31.Image = Resources.ia;
                    picbut31.Enabled = false;
                }
                else if (b.Fila == "G" && b.nro == 1)
                {
                    picbut32.Image = Resources.ia;
                    picbut32.Enabled = false;
                }
                else if (b.Fila == "G" && b.nro == 2)
                {
                    picbut33.Image = Resources.ia;
                    picbut33.Enabled = false;
                }
                else if (b.Fila == "G" && b.nro == 3)
                {
                    picbut34.Image = Resources.ia;
                    picbut34.Enabled = false;
                }
                else if (b.Fila == "G" && b.nro == 4)
                {
                    picbut35.Image = Resources.ia;
                    picbut35.Enabled = false;
                }
                else if (b.Fila == "G" && b.nro == 5)
                {
                    picbut36.Image = Resources.ia;
                    picbut36.Enabled = false;
                }
                else if (b.Fila == "H" && b.nro == 1)
                {
                    picbut37.Image = Resources.ia;
                    picbut37.Enabled = false;
                }
                else if (b.Fila == "H" && b.nro == 2)
                {
                    picbut38.Image = Resources.ia;
                    picbut38.Enabled = false;
                }
                else if (b.Fila == "H" && b.nro == 3)
                {
                    picbut39.Image = Resources.ia;
                    picbut39.Enabled = false;
                }
                else if (b.Fila == "H" && b.nro == 4)
                {
                    picbut40.Image = Resources.ia;
                    picbut40.Enabled = false;
                }
                else if (b.Fila == "H" && b.nro == 5)
                {
                    picbut41.Image = Resources.ia;
                    picbut41.Enabled = false;
                }
                else if (b.Fila == "I" && b.nro == 1)
                {
                    picbut42.Image = Resources.ia;
                    picbut42.Enabled = false;
                }
                else if (b.Fila == "I" && b.nro == 2)
                {
                    picbut43.Image = Resources.ia;
                    picbut43.Enabled = false;
                }
                else if (b.Fila == "I" && b.nro == 3)
                {
                    picbut44.Image = Resources.ia;
                    picbut44.Enabled = false;
                }
                else if (b.Fila == "I" && b.nro == 4)
                {
                    picbut45.Image = Resources.ia;
                    picbut45.Enabled = false;
                }
                else if (b.Fila == "I" && b.nro == 5)
                {
                    picbut46.Image = Resources.ia;
                    picbut46.Enabled = false;
                }
            }


        }

        private async void btnBorrar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Desea dar de baja la factura?", "Baja", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Parametro pm = new Parametro("@id_Factura", f.id_Factura);

                if(await BajaFactura(pm))
                {
                    MessageBox.Show("Factura bajada con exito.");
                }
                else
                {
                    MessageBox.Show("Problema del servidor al bajar la factura");

                }
                pnlButaca.Visible = false;
                dgvComprobantes.Visible = false;
                picdesplegar.Visible = false;
                btnBorrar.Visible = false;
                BtnPagar.Visible = false;
                await cargar_Facturas();
                cargar_datagrid_factura(LFactura);
            }



        }


        private async Task<bool> BajaFactura(Parametro pm)
        {
            string FiltrosJson = JsonConvert.SerializeObject(pm);
            string url = "https://localhost:7271/api/CRUDfactura/BajaFactura";
            var data = await ClaseSingleton.GetInstance().PostAsync(url, FiltrosJson);
            return JsonConvert.DeserializeObject<bool>(data);
 

        }

    }
}
