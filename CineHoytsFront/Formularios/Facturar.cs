using Cine_Hoyts.Dominio;
using CineHoytsBack.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CineHoytsFront.Properties;
using CineHoytsFront.Servicio;
using Newtonsoft.Json;
using CineHoytsBack.Dominio.Campos;

namespace Cine_Hoyts.Formularios
{
    public partial class Facturar : Form
    {
        Factura fac = new Factura();
        Comprobante comprobante = new Comprobante();
        List<Butaca> but = new List<Butaca>();
        List<Butaca> but_selected = new List<Butaca>();
        Funcion funcion = new Funcion();
        public Facturar()
        {
            InitializeComponent();
        }

        private async void Facturar_Load(object sender, EventArgs e)
        {
            try
            {
                await CargarComboAsyncPelicula();
                await CargarComboAsyncPelicula();
                cboPromocion.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            catch
            {
                MessageBox.Show("Demasiadas solicitudes, intentelo de nuevo mas tarde");

            }


        }
        private async Task CargarComboAsyncPelicula()
        {
            string url = "https://localhost:7271/api/Tablas/PeliculaCBO ";
            var data = await ClaseSingleton.GetInstance().GetAsync(url);
            List<Pelicula> lst = JsonConvert.DeserializeObject<List<Pelicula>>(data);
            cboPelicula.DataSource = lst;
            cboPelicula.ValueMember = "id_pel";
            cboPelicula.DisplayMember = "titulo";
            cboPelicula.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPelicula.SelectedIndex = -1;

        }

        private async Task CargarComboAsyncDia(List<Parametro> pm)
        {
            string FiltrosJson = JsonConvert.SerializeObject(pm);
            string url = "https://localhost:7271/api/Tablas/FechaCBO";
            var data = await ClaseSingleton.GetInstance().PostAsync(url, FiltrosJson);

            List<Fecha> lst = JsonConvert.DeserializeObject<List<Fecha>>(data);
            cboDia.DataSource = lst;
            cboDia.ValueMember = "fecha";
            cboDia.DisplayMember = "fecha";
            cboDia.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDia.SelectedIndex = -1;

        }

        private async Task CargarComboAsyncHora(List<Parametro> pm)
        {
            string FiltrosJson = JsonConvert.SerializeObject(pm);
            string url = "https://localhost:7271/api/Tablas/HorarioCBO";
            var data = await ClaseSingleton.GetInstance().PostAsync(url, FiltrosJson);

            List<Hora> lst = JsonConvert.DeserializeObject<List<Hora>>(data);
            cboHora.DataSource = lst;
            cboHora.ValueMember = "id_hora";
            cboHora.DisplayMember = "Horario";
            cboHora.DropDownStyle = ComboBoxStyle.DropDownList;
            cboHora.SelectedIndex = -1;

        }

        private async Task CargarComboAsyncIdioma(List<Parametro> pm)
        {
            string FiltrosJson = JsonConvert.SerializeObject(pm);
            string url = "https://localhost:7271/api/Tablas/IdiomaCBO";
            var data = await ClaseSingleton.GetInstance().PostAsync(url, FiltrosJson);

            List<Idioma> lst = JsonConvert.DeserializeObject<List<Idioma>>(data);
            cboIdioma.DataSource = lst;
            cboIdioma.ValueMember = "id_idioma";
            cboIdioma.DisplayMember = "idiom";
            cboIdioma.DropDownStyle = ComboBoxStyle.DropDownList;
            cboIdioma.SelectedIndex = -1;

        }

        private async Task CargarComboAsyncTipoSala(List<Parametro> pm)
        {
            string FiltrosJson = JsonConvert.SerializeObject(pm);
            string url = "https://localhost:7271/api/Tablas/SalaCBO";
            var data = await ClaseSingleton.GetInstance().PostAsync(url, FiltrosJson);

            List<TipoSala> lst = JsonConvert.DeserializeObject<List<TipoSala>>(data);
            cboTipoSal.DataSource = lst;
            cboTipoSal.ValueMember = "id_tipoSala";
            cboTipoSal.DisplayMember = "tiposala";
            cboTipoSal.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoSal.SelectedIndex = -1;

        }
        private async void cboPelicula_SelectionChangeCommitted(object sender, EventArgs e)
        {
            List<Parametro> pm = new List<Parametro>();
            funcion.Id_pelicula = Convert.ToInt32(cboPelicula.SelectedValue);
            funcion.Pelicula = cboPelicula.Text; but_selected.Clear();
            cboDia.SelectedIndex = -1; cboDia.Enabled = true;
            cboHora.SelectedIndex = -1; cboHora.Enabled = false;
            cboIdioma.SelectedIndex = -1; cboIdioma.Enabled = false;
            cboTipoSal.SelectedIndex = -1; cboTipoSal.Enabled = false; pnlButaca.Visible = false;
            comprobante.Fun = funcion;
            pm.Add(new Parametro("@id_pelicula", comprobante.Fun.Id_pelicula));
            try
            {
                await CargarComboAsyncDia(pm);

            }
            catch (Exception)
            {
                MessageBox.Show("Demasiadas solicitudes, intentelo de nuevo mas tarde");

            }

        }

        private async void cboDia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            List<Parametro> pm = new List<Parametro>();
            but_selected.Clear(); funcion.Fecha = Convert.ToDateTime(cboDia.SelectedValue).ToShortDateString();
            cboHora.SelectedIndex = -1; cboHora.Enabled = true;
            cboIdioma.SelectedIndex = -1; cboIdioma.Enabled = false;
            cboTipoSal.SelectedIndex = -1; cboTipoSal.Enabled = false; pnlButaca.Visible = false;
            comprobante.Fun = funcion;
            pm.Add(new Parametro("@id_pelicula", comprobante.Fun.Id_pelicula));
            pm.Add(new Parametro("@fecha", comprobante.Fun.Fecha));
            try
            {
                await CargarComboAsyncHora(pm);

            }
            catch (Exception)
            {
                MessageBox.Show("Demasiadas solicitudes, intentelo de nuevo mas tarde");

            }
        }

        private async void cboHora_SelectionChangeCommitted(object sender, EventArgs e)
        {
            List<Parametro> pm = new List<Parametro>();

            cboIdioma.SelectedIndex = -1; cboIdioma.Enabled = true;
            cboTipoSal.SelectedIndex = -1; cboTipoSal.Enabled = false;
            pnlButaca.Visible = false; but_selected.Clear();
            funcion.Id_horario = Convert.ToInt32(cboHora.SelectedValue);
            funcion.Hora = cboHora.Text;
            comprobante.Fun = funcion;
            pm.Add(new Parametro("@id_pelicula", comprobante.Fun.Id_pelicula));
            pm.Add(new Parametro("@fecha", comprobante.Fun.Fecha));
            pm.Add(new Parametro("@id_horario", comprobante.Fun.Id_horario));
            try
            {
                await CargarComboAsyncIdioma(pm);

            }
            catch (Exception)
            {
                MessageBox.Show("Demasiadas solicitudes, intentelo de nuevo mas tarde");

            }
        }

        private async void cboIdioma_SelectionChangeCommitted(object sender, EventArgs e)
        {
            List<Parametro> pm = new List<Parametro>();

            funcion.Id_idioma = Convert.ToInt32(cboIdioma.SelectedValue);
            funcion.Idioma = cboIdioma.Text;
            comprobante.Fun = funcion;
            cboTipoSal.SelectedIndex = -1; cboTipoSal.Enabled = true; but_selected.Clear();
            pnlButaca.Visible = false;
            pm.Add(new Parametro("@id_pelicula", comprobante.Fun.Id_pelicula));
            pm.Add(new Parametro("@fecha", comprobante.Fun.Fecha));
            pm.Add(new Parametro("@id_horario", comprobante.Fun.Id_horario));
            pm.Add(new Parametro("@id_idioma", comprobante.Fun.Id_idioma));
            try
            {
                await CargarComboAsyncTipoSala(pm);

            }
            catch (Exception)
            {
                MessageBox.Show("Demasiadas solicitudes, intentelo de nuevo mas tarde");

            }
        }

        private async void cboTipoSal_SelectionChangeCommitted(object sender, EventArgs e)
        {
            List<Parametro> pm = new List<Parametro>();

            but_selected.Clear(); pnlButaca.Visible = false;

            funcion.Id_sala = Convert.ToInt32(cboTipoSal.SelectedValue);
            funcion.Sala = cboTipoSal.Text;
            comprobante.Fun = funcion;
            pm.Add(new Parametro("@id_pelicula", comprobante.Fun.Id_pelicula));
            pm.Add(new Parametro("@fecha", comprobante.Fun.Fecha));
            pm.Add(new Parametro("@id_horario", comprobante.Fun.Id_horario));
            pm.Add(new Parametro("@id_idioma", comprobante.Fun.Id_idioma));
            pm.Add(new Parametro("@id_sala", comprobante.Fun.Id_sala));

            try
            {
                await Cargar_Funcion(pm);

            }
            catch (Exception)
            {
                MessageBox.Show("Demasiadas solicitudes, intentelo de nuevo mas tarde");

            }

            reiniciar_butacas();
            comprobante.monto = comprobante.Fun.monto;

            
        }

        public async Task Cargar_Funcion(List<Parametro> pm)
        {
            Funcion fu = new Funcion();
            string FiltrosJson = JsonConvert.SerializeObject(pm);
            string url = "https://localhost:7271/api/Tablas/Funcion";
            var data = await ClaseSingleton.GetInstance().PostAsync(url, FiltrosJson);

            fu = JsonConvert.DeserializeObject<Funcion>(data);
            funcion.id_funcion = fu.id_funcion;
            funcion.monto = fu.monto;
            comprobante.Fun= funcion;
            comprobante.Fun = funcion;

        }

        private void cargar_txb_montos()
        {
            double total = 0;
            double subtotal = 0;
            foreach (Comprobante item in fac.listComprobobante)
            {
                total += item.monto * item.cantidad;
                subtotal += item.Total;
            }
            TxbTotal.Text = Convert.ToString(total);
            TxbSubtotal.Text = Convert.ToString(subtotal);

        }
        private void cargar_dgv_factura()
        {
            dgvComprobantes.Rows.Clear();

            foreach (Comprobante com in fac.listComprobobante)
            {
                dgvComprobantes.Rows.Add(com.Fun.id_funcion.ToString(), com.Fun.Pelicula, com.Fun.Idioma, com.Fun.Fecha, 
                    "$ "+ com.Fun.monto, com.TicketLista.Count,cboPromocion.Text, "$ " + com.Total);
            }
        }
        private async void reiniciar_cbo()
        {
            cboPelicula.SelectedIndex = -1;
            cboHora.SelectedIndex = -1;
            cboDia.SelectedIndex = -1;
            cboIdioma.SelectedIndex = -1;
            cboTipoSal.SelectedIndex = -1;
            try
            {
                await CargarComboAsyncPelicula();

            }
            catch (Exception)
            {
                MessageBox.Show("Demasiadas solicitudes intentalo nuevamente más tarde");
            }
            cboDia.Enabled = false;
            cboHora.Enabled = false;
            cboIdioma.Enabled = false;
            cboTipoSal.Enabled = false;
            cboPromocion.SelectedIndex = -1;
        }
        private int promocion()
        {
            if (cboPromocion.SelectedIndex == 0)
            {
                comprobante.Promocion = 50;
                return 1;
            }
            else if (cboPromocion.SelectedIndex == 1)
            {
                comprobante.Promocion = 80;

                return 2;
            }
            else if(cboPromocion.SelectedIndex == 2)
            {
                comprobante.Promocion = 25;

                return 3;
            }
            else if(cboPromocion.SelectedIndex == 3)
            {
                comprobante.Promocion = 40;

                return 4;
            }
            else if(cboPromocion.SelectedIndex == 4)
            {
                comprobante.Promocion = 30;

                return 5;
            }
            else 
            {
                comprobante.Promocion = 35;

                return 6;
            }
        }

        private async void btnButaca_Click_1(object sender, EventArgs e)
        {
            if (cboPelicula.SelectedIndex != -1 && cboDia.SelectedIndex != -1 && cboHora.SelectedIndex != -1
                && cboIdioma.SelectedIndex != -1 && cboTipoSal.SelectedIndex != -1)
            {
                    List<Parametro> pm = new List<Parametro>();
                    pm.Add(new Parametro("@id_sala", comprobante.Fun.Id_sala));
                    pm.Add(new Parametro("@id_funcion", comprobante.Fun.id_funcion));
                    but = await CargarButaca(pm);
                    txbCantEntradas.Text = Convert.ToString(comprobante.TicketLista.Count);
                    ocupar_butacas();
                    pnlButaca.Visible = !pnlButaca.Visible;

            }
            else
            {
                MessageBox.Show("Complete los datos de la Funcion para elegir las butacas");
            }

        }
        private async Task<List<Butaca>> CargarButaca(List<Parametro> pm)
        {
            string FiltrosJson = JsonConvert.SerializeObject(pm);
            string url = "https://localhost:7271/api/CRUDfactura/GetButacas";
            var data = await ClaseSingleton.GetInstance().PostAsync(url, FiltrosJson);
            if (data == null)
            {
                 data = await ClaseSingleton.GetInstance().PostAsync(url, FiltrosJson);

            }
            return  JsonConvert.DeserializeObject<List<Butaca>>(data);

        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            if (funcion.id_funcion != null && funcion.id_funcion != 0)
            {
                if (fac.buscar(comprobante.Fun.id_funcion))
                {
                    if (comprobante.TicketLista.Count > 0)
                    {
                        comprobante.TicketList = comprobante.TicketLista;
                        if (cboPromocion.SelectedIndex != -1)
                        {
                            comprobante.Id_promocion = promocion();
                            comprobante.cantidad = comprobante.TicketList.Count;
                            comprobante.Total = comprobante.Fun.monto * comprobante.TicketList.Count - (((comprobante.Fun.monto * comprobante.TicketList.Count) * comprobante.Promocion) / 100);
                            fac.listComprobobante.Add(comprobante);
                            cargar_dgv_factura();
                            cargar_txb_montos();
                            comprobante = new Comprobante();
                            reiniciar_butacas();
                            reiniciar_cbo();
                            pnlButaca.Visible = false;
                            funcion = new Funcion();
                        }
                        else
                        {
                            MessageBox.Show("Debe seleccionar una promocion");

                        }


                    }
                    else
                    {
                        MessageBox.Show("Debe comprar al menos una butaca");
                    }
                }
                else
                {
                    MessageBox.Show("Ya adquirio esta funcion");

                }
            }
            else
            {
                MessageBox.Show("Debe elegir una funcion");

            }
        }

        /*--------------------------------------------------------------------------------------------------------------------------*/
        /*--------------------------------------------------------------------------------------------------------------------------*/
        /*--------------------------------------------------------------------------------------------------------------------------*/
        /*--------------------------------------------------------------------------------------------------------------------------*/
        /*--------------------------------------------------------------------------------------------------------------------------*/
        /*--------------------------------------------------------------------------------------------------------------------------*/
        /*--------------------------------------------------------------------------------------------------------------------------*/
        /*--------------------------------------------------------------------------------------------------------------------------*/
        /*--------------------------------------------------------------------------------------------------------------------------*/
        /*--------------------------------------------------------------------------------------------------------------------------*/
        private void reiniciar_butacas()
        {
                comprobante.TicketLista.Clear();
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
            if(but is null)
            {

                MessageBox.Show("Intentalo nuevamente más tarde");


            }
            else
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
            


        }
        private void picbut1_Click(object sender, EventArgs e)
        {
            Ticket b = new Ticket();
            if (Convert.ToInt32(cboTipoSal.SelectedValue) == 1)
            {
                b.Id_butaca_sala = 1;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 2)
            {
                b.Id_butaca_sala = 46;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 3)
            {
                b.Id_butaca_sala = 91;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 4)
            {
                b.Id_butaca_sala = 136;

            }

            if (comprobante.buscar(b.Id_butaca_sala))
            {
                picbut1.Image = Resources.vaciaaa;
                comprobante.remover(b.Id_butaca_sala);

            }
            else
            {
                comprobante.TicketLista.Add(b);
                picbut1.Image = Resources.Sleected;
            }
            txbCantEntradas.Text = Convert.ToString(comprobante.TicketLista.Count);
        }

        private void picbut2_Click(object sender, EventArgs e)
        {
            Ticket b = new Ticket();
            if (Convert.ToInt32(cboTipoSal.SelectedValue) == 1)
            {
                b.Id_butaca_sala = 2;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 2)
            {
                b.Id_butaca_sala = 47;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 3)
            {
                b.Id_butaca_sala = 92;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 4)
            {
                b.Id_butaca_sala = 137;

            }


            if (comprobante.buscar(b.Id_butaca_sala))
            {
                picbut2.Image = Resources.vaciaaa;
                comprobante.remover(b.Id_butaca_sala);

            }
            else
            {
                comprobante.TicketLista.Add(b);
                picbut2.Image = Resources.Sleected;
            }
            txbCantEntradas.Text = Convert.ToString(comprobante.TicketLista.Count);

        }

        private void picbut3_Click(object sender, EventArgs e)
        {
            Ticket b = new Ticket();
            if (Convert.ToInt32(cboTipoSal.SelectedValue) == 1)
            {
                b.Id_butaca_sala = 3;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 2)
            {
                b.Id_butaca_sala = 48;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 3)
            {
                b.Id_butaca_sala = 93;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 4)
            {
                b.Id_butaca_sala = 138;

            }

            if (comprobante.buscar(b.Id_butaca_sala))
            {
                picbut3.Image = Resources.vaciaaa;
                comprobante.remover(b.Id_butaca_sala);

            }
            else
            {
                comprobante.TicketLista.Add(b);
                picbut3.Image = Resources.Sleected;
            }
            txbCantEntradas.Text = Convert.ToString(comprobante.TicketLista.Count);

        }

        private void picbut4_Click(object sender, EventArgs e)
        {
            Ticket b = new Ticket();
            if (Convert.ToInt32(cboTipoSal.SelectedValue) == 1)
            {
                b.Id_butaca_sala = 4;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 2)
            {
                b.Id_butaca_sala = 49;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 3)
            {
                b.Id_butaca_sala = 94;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 4)
            {
                b.Id_butaca_sala = 139;

            }


            if (comprobante.buscar(b.Id_butaca_sala))
            {
                picbut4.Image = Resources.vaciaaa;
                comprobante.remover(b.Id_butaca_sala);

            }
            else
            {
                comprobante.TicketLista.Add(b);
                picbut4.Image = Resources.Sleected;
            }
            txbCantEntradas.Text = Convert.ToString(comprobante.TicketLista.Count);

        }

        private void picbut5_Click(object sender, EventArgs e)
        {
            Ticket b = new Ticket();

            if (Convert.ToInt32(cboTipoSal.SelectedValue) == 1)
            {
                b.Id_butaca_sala = 5;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 2)
            {
                b.Id_butaca_sala = 50;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 3)
            {
                b.Id_butaca_sala = 95;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 4)
            {
                b.Id_butaca_sala = 140;

            }

            if (comprobante.buscar(b.Id_butaca_sala))
            {
                picbut5.Image = Resources.vaciaaa;
                comprobante.remover(b.Id_butaca_sala);

            }
            else
            {
                comprobante.TicketLista.Add(b);
                picbut5.Image = Resources.Sleected;
            }
            txbCantEntradas.Text = Convert.ToString(comprobante.TicketLista.Count);

        }

        private void picbut6_Click(object sender, EventArgs e)
        {
            Ticket b = new Ticket();

            if (Convert.ToInt32(cboTipoSal.SelectedValue) == 1)
            {
                b.Id_butaca_sala = 6;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 2)
            {
                b.Id_butaca_sala = 51;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 3)
            {
                b.Id_butaca_sala = 96;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 4)
            {
                b.Id_butaca_sala = 141;

            }


            if (comprobante.buscar(b.Id_butaca_sala))
            {
                picbut6.Image = Resources.vaciaaa;
                comprobante.remover(b.Id_butaca_sala);

            }
            else
            {
                comprobante.TicketLista.Add(b);
                picbut6.Image = Resources.Sleected;
            }
            txbCantEntradas.Text = Convert.ToString(comprobante.TicketLista.Count);

        }

        private void picbut7_Click(object sender, EventArgs e)
        {
            Ticket b = new Ticket();

            if (Convert.ToInt32(cboTipoSal.SelectedValue) == 1)
            {
                b.Id_butaca_sala = 7;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 2)
            {
                b.Id_butaca_sala = 52;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 3)
            {
                b.Id_butaca_sala = 97;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 4)
            {
                b.Id_butaca_sala = 142;

            }
            if (comprobante.buscar(b.Id_butaca_sala))
            {
                picbut7.Image = Resources.vaciaaa;
                comprobante.remover(b.Id_butaca_sala);

            }
            else
            {
                comprobante.TicketLista.Add(b);
                picbut7.Image = Resources.Sleected;
            }

            txbCantEntradas.Text = Convert.ToString(comprobante.TicketLista.Count);

        }

        private void picbut8_Click(object sender, EventArgs e)
        {
            Ticket b = new Ticket();

            if (Convert.ToInt32(cboTipoSal.SelectedValue) == 1)
            {
                b.Id_butaca_sala = 8;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 2)
            {
                b.Id_butaca_sala = 53;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 3)
            {
                b.Id_butaca_sala = 98;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 4)
            {
                b.Id_butaca_sala = 143;

            }

            if (comprobante.buscar(b.Id_butaca_sala))
            {
                picbut8.Image = Resources.vaciaaa;
                comprobante.remover(b.Id_butaca_sala);

            }
            else
            {
                comprobante.TicketLista.Add(b);
                picbut8.Image = Resources.Sleected;
            }
            txbCantEntradas.Text = Convert.ToString(comprobante.TicketLista.Count);

        }

        private void picbut9_Click(object sender, EventArgs e)
        {
            Ticket b = new Ticket();

            if (Convert.ToInt32(cboTipoSal.SelectedValue) == 1)
            {
                b.Id_butaca_sala = 9;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 2)
            {
                b.Id_butaca_sala = 54;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 3)
            {
                b.Id_butaca_sala = 99;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 4)
            {
                b.Id_butaca_sala = 144;

            }


            if (comprobante.buscar(b.Id_butaca_sala))
            {
                picbut9.Image = Resources.vaciaaa;
                comprobante.remover(b.Id_butaca_sala);

            }
            else
            {
                comprobante.TicketLista.Add(b);
                picbut9.Image = Resources.Sleected;
            }
            txbCantEntradas.Text = Convert.ToString(comprobante.TicketLista.Count);

        }

        private void picbut10_Click(object sender, EventArgs e)
        {
            Ticket b = new Ticket();

            if (Convert.ToInt32(cboTipoSal.SelectedValue) == 1)
            {
                b.Id_butaca_sala = 10;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 2)
            {
                b.Id_butaca_sala = 55;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 3)
            {
                b.Id_butaca_sala = 100;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 4)
            {
                b.Id_butaca_sala = 145;

            }
            if (comprobante.buscar(b.Id_butaca_sala))
            {
                picbut10.Image = Resources.vaciaaa;
                comprobante.remover(b.Id_butaca_sala);

            }
            else
            {
                comprobante.TicketLista.Add(b);
                picbut10.Image = Resources.Sleected;
            }
            txbCantEntradas.Text = Convert.ToString(comprobante.TicketLista.Count);

        }

        private void picbut11_Click(object sender, EventArgs e)
        {
            Ticket b = new Ticket();

            if (Convert.ToInt32(cboTipoSal.SelectedValue) == 1)
            {
                b.Id_butaca_sala = 11;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 2)
            {
                b.Id_butaca_sala = 56;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 3)
            {
                b.Id_butaca_sala = 101;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 4)
            {
                b.Id_butaca_sala = 146;

            }

            if (comprobante.buscar(b.Id_butaca_sala))
            {
                picbut11.Image = Resources.vaciaaa;
                comprobante.remover(b.Id_butaca_sala);

            }
            else
            {
                comprobante.TicketLista.Add(b);
                picbut11.Image = Resources.Sleected;
            }
            txbCantEntradas.Text = Convert.ToString(comprobante.TicketLista.Count);

        }

        private void picbut12_Click(object sender, EventArgs e)
        {
            Ticket b = new Ticket();

            if (Convert.ToInt32(cboTipoSal.SelectedValue) == 1)
            {
                b.Id_butaca_sala = 12;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 2)
            {
                b.Id_butaca_sala = 57;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 3)
            {
                b.Id_butaca_sala = 102;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 4)
            {
                b.Id_butaca_sala = 147;
            }



            if (comprobante.buscar(b.Id_butaca_sala))
            {
                picbut12.Image = Resources.vaciaaa;
                comprobante.remover(b.Id_butaca_sala);

            }
            else
            {
                comprobante.TicketLista.Add(b);
                picbut12.Image = Resources.Sleected;
            }
            txbCantEntradas.Text = Convert.ToString(comprobante.TicketLista.Count);

        }

        private void picbut13_Click(object sender, EventArgs e)
        {
            Ticket b = new Ticket();

            if (Convert.ToInt32(cboTipoSal.SelectedValue) == 1)
            {
                b.Id_butaca_sala = 13;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 2)
            {
                b.Id_butaca_sala = 58;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 3)
            {
                b.Id_butaca_sala = 103;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 4)
            {
                b.Id_butaca_sala = 148;

            }




            if (comprobante.buscar(b.Id_butaca_sala))
            {
                picbut13.Image = Resources.vaciaaa;
                comprobante.remover(b.Id_butaca_sala);

            }
            else
            {
                comprobante.TicketLista.Add(b);
                picbut13.Image = Resources.Sleected;
            }
            txbCantEntradas.Text = Convert.ToString(comprobante.TicketLista.Count);

        }

        private void picbut15_Click(object sender, EventArgs e)
        {
            Ticket b = new Ticket();

            if (Convert.ToInt32(cboTipoSal.SelectedValue) == 1)
            {
                b.Id_butaca_sala = 14;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 2)
            {
                b.Id_butaca_sala = 59;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 3)
            {
                b.Id_butaca_sala = 104;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 4)
            {
                b.Id_butaca_sala = 149;

            }





            if (comprobante.buscar(b.Id_butaca_sala))
            {
                picbut15.Image = Resources.vaciaaa;
                comprobante.remover(b.Id_butaca_sala);

            }
            else
            {
                comprobante.TicketLista.Add(b);
                picbut15.Image = Resources.Sleected;
            }
            txbCantEntradas.Text = Convert.ToString(comprobante.TicketLista.Count);

        }

        private void picbut16_Click(object sender, EventArgs e)
        {
            Ticket b = new Ticket();

            if (Convert.ToInt32(cboTipoSal.SelectedValue) == 1)
            {
                b.Id_butaca_sala = 15;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 2)
            {
                b.Id_butaca_sala = 60;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 3)
            {
                b.Id_butaca_sala = 105;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 4)
            {
                b.Id_butaca_sala = 150;

            }


            if (comprobante.buscar(b.Id_butaca_sala))
            {
                picbut16.Image = Resources.vaciaaa;
                comprobante.remover(b.Id_butaca_sala);

            }
            else
            {
                comprobante.TicketLista.Add(b);
                picbut16.Image = Resources.Sleected;
            }
            txbCantEntradas.Text = Convert.ToString(comprobante.TicketLista.Count);

        }

        private void picbut17_Click(object sender, EventArgs e)
        {
            
             Ticket b = new Ticket();

            if (Convert.ToInt32(cboTipoSal.SelectedValue) == 1)
            {
                b.Id_butaca_sala = 16;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 2)
            {
                b.Id_butaca_sala = 61;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 3)
            {
                b.Id_butaca_sala = 106;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 4)
            {
                b.Id_butaca_sala = 151;

            }

            if (comprobante.buscar(b.Id_butaca_sala))
            {
                  picbut17.Image = Resources.vaciaaa;
                  comprobante.remover(b.Id_butaca_sala);

            }
            else
            {
                 comprobante.TicketLista.Add(b);
                picbut17.Image = Resources.Sleected;
            }
            txbCantEntradas.Text = Convert.ToString(comprobante.TicketLista.Count);

        }

        private void picbut18_Click(object sender, EventArgs e)
        {
            Ticket b = new Ticket();

            if (Convert.ToInt32(cboTipoSal.SelectedValue) == 1)
            {
                b.Id_butaca_sala = 17;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 2)
            {
                b.Id_butaca_sala = 62;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 3)
            {
                b.Id_butaca_sala = 107;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 4)
            {
                b.Id_butaca_sala = 152;

            }


            if (comprobante.buscar(b.Id_butaca_sala))
            {
                picbut18.Image = Resources.vaciaaa;
                comprobante.remover(b.Id_butaca_sala);

            }
            else
            {
                comprobante.TicketLista.Add(b);
                picbut18.Image = Resources.Sleected;
            }
            txbCantEntradas.Text = Convert.ToString(comprobante.TicketLista.Count);

        }

        private void picbut19_Click(object sender, EventArgs e)
        {
            Ticket b = new Ticket();
            if (Convert.ToInt32(cboTipoSal.SelectedValue) == 1)
            {
                b.Id_butaca_sala = 18;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 2)
            {
                b.Id_butaca_sala = 63;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 3)
            {
                b.Id_butaca_sala = 108;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 4)
            {
                b.Id_butaca_sala = 153;

            }



            if (comprobante.buscar(b.Id_butaca_sala))
            {
                picbut19.Image = Resources.vaciaaa;
                comprobante.remover(b.Id_butaca_sala);

            }
            else
            {
                comprobante.TicketLista.Add(b);
                picbut19.Image = Resources.Sleected;
            }
            txbCantEntradas.Text = Convert.ToString(comprobante.TicketLista.Count);

        }

        private void picbut20_Click(object sender, EventArgs e)
        {
            Ticket b = new Ticket();

            if (Convert.ToInt32(cboTipoSal.SelectedValue) == 1)
            {
                b.Id_butaca_sala = 19;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 2)
            {
                b.Id_butaca_sala = 64;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 3)
            {
                b.Id_butaca_sala = 109;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 4)
            {
                b.Id_butaca_sala = 154;

            }

            if (comprobante.buscar(b.Id_butaca_sala))
            {
                picbut20.Image = Resources.vaciaaa;
                comprobante.remover(b.Id_butaca_sala);

            }
            else
            {
                comprobante.TicketLista.Add(b);
                picbut20.Image = Resources.Sleected;
            }
            txbCantEntradas.Text = Convert.ToString(comprobante.TicketLista.Count);

        }

        private void picbut21_Click(object sender, EventArgs e)
        {
            Ticket b = new Ticket();

            if (Convert.ToInt32(cboTipoSal.SelectedValue) == 1)
            {
                b.Id_butaca_sala = 20;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 2)
            {
                b.Id_butaca_sala = 65;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 3)
            {
                b.Id_butaca_sala = 110;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 4)
            {
                b.Id_butaca_sala = 155;

            }

            if (comprobante.buscar(b.Id_butaca_sala))
            {
                picbut21.Image = Resources.vaciaaa;
                comprobante.remover(b.Id_butaca_sala);

            }
            else
            {
                comprobante.TicketLista.Add(b);
                picbut21.Image = Resources.Sleected;
            }
            txbCantEntradas.Text = Convert.ToString(comprobante.TicketLista.Count);

        }

        private void picbut22_Click(object sender, EventArgs e)
        {
            Ticket b = new Ticket();
            if (Convert.ToInt32(cboTipoSal.SelectedValue) == 1)
            {
                b.Id_butaca_sala = 21;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 2)
            {
                b.Id_butaca_sala = 66;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 3)
            {
                b.Id_butaca_sala = 111;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 4)
            {
                b.Id_butaca_sala = 156;

            }

            if (comprobante.buscar(b.Id_butaca_sala))
            {
                picbut22.Image = Resources.vaciaaa;
                comprobante.remover(b.Id_butaca_sala);

            }
            else
            {
                comprobante.TicketLista.Add(b);
                picbut22.Image = Resources.Sleected;
            }
            txbCantEntradas.Text = Convert.ToString(comprobante.TicketLista.Count);


        }

        private void picbut23_Click(object sender, EventArgs e)
        {
            Ticket b = new Ticket();

            if (Convert.ToInt32(cboTipoSal.SelectedValue) == 1)
            {
                b.Id_butaca_sala = 22;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 2)
            {
                b.Id_butaca_sala = 67;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 3)
            {
                b.Id_butaca_sala = 112;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 4)
            {
                b.Id_butaca_sala = 157;

            }

            if (comprobante.buscar(b.Id_butaca_sala))
            {
                picbut23.Image = Resources.vaciaaa;
                comprobante.remover(b.Id_butaca_sala);

            }
            else
            {
                comprobante.TicketLista.Add(b);
                picbut23.Image = Resources.Sleected;
            }
            txbCantEntradas.Text = Convert.ToString(comprobante.TicketLista.Count);

        }

        private void picbut24_Click(object sender, EventArgs e)
        {
            Ticket b = new Ticket();

            if (Convert.ToInt32(cboTipoSal.SelectedValue) == 1)
            {
                b.Id_butaca_sala = 23;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 2)
            {
                b.Id_butaca_sala = 68;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 3)
            {
                b.Id_butaca_sala = 113;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 4)
            {
                b.Id_butaca_sala = 158;

            }
            if (comprobante.buscar(b.Id_butaca_sala))
            {
                picbut24.Image = Resources.vaciaaa;
                comprobante.remover(b.Id_butaca_sala);

            }
            else
            {
                comprobante.TicketLista.Add(b);
                picbut24.Image = Resources.Sleected;
            }
            txbCantEntradas.Text = Convert.ToString(comprobante.TicketLista.Count);

        }

        private void picbut25_Click(object sender, EventArgs e)
        {
            Ticket b = new Ticket();

            if (Convert.ToInt32(cboTipoSal.SelectedValue) == 1)
            {
                b.Id_butaca_sala = 24;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 2)
            {
                b.Id_butaca_sala = 69;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 3)
            {
                b.Id_butaca_sala = 114;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 4)
            {
                b.Id_butaca_sala = 159;

            }
            if (comprobante.buscar(b.Id_butaca_sala))
            {
                picbut25.Image = Resources.vaciaaa;
                comprobante.remover(b.Id_butaca_sala);

            }
            else
            {
                comprobante.TicketLista.Add(b);
                picbut25.Image = Resources.Sleected;
            }
            txbCantEntradas.Text = Convert.ToString(comprobante.TicketLista.Count);

        }

        private void picbut26_Click(object sender, EventArgs e)
        {
            Ticket b = new Ticket();

            if (Convert.ToInt32(cboTipoSal.SelectedValue) == 1)
            {
                b.Id_butaca_sala = 25;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 2)
            {
                b.Id_butaca_sala = 70;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 3)
            {
                b.Id_butaca_sala = 115;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 4)
            {
                b.Id_butaca_sala = 160;

            }
            if (comprobante.buscar(b.Id_butaca_sala))
            {
                picbut26.Image = Resources.vaciaaa;
                comprobante.remover(b.Id_butaca_sala);

            }
            else
            {
                comprobante.TicketLista.Add(b);
                picbut26.Image = Resources.Sleected;
            }
            txbCantEntradas.Text = Convert.ToString(comprobante.TicketLista.Count);

        }

        private void picbut27_Click(object sender, EventArgs e)
        {
            Ticket b = new Ticket();

            if (Convert.ToInt32(cboTipoSal.SelectedValue) == 1)
            {
                b.Id_butaca_sala = 26;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 2)
            {
                b.Id_butaca_sala = 71;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 3)
            {
                b.Id_butaca_sala = 116;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 4)
            {
                b.Id_butaca_sala = 161;

            }
            if (comprobante.buscar(b.Id_butaca_sala))
            {
                picbut27.Image = Resources.vaciaaa;
                comprobante.remover(b.Id_butaca_sala);

            }
            else
            {
                comprobante.TicketLista.Add(b);
                picbut27.Image = Resources.Sleected;
            }
            txbCantEntradas.Text = Convert.ToString(comprobante.TicketLista.Count);

        }

        private void picbut28_Click(object sender, EventArgs e)
        {
            Ticket b = new Ticket();

            if (Convert.ToInt32(cboTipoSal.SelectedValue) == 1)
            {
                b.Id_butaca_sala = 27;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 2)
            {
                b.Id_butaca_sala = 72;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 3)
            {
                b.Id_butaca_sala = 117;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 4)
            {
                b.Id_butaca_sala = 162;

            }
            if (comprobante.buscar(b.Id_butaca_sala))
            {
                picbut28.Image = Resources.vaciaaa;
                comprobante.remover(b.Id_butaca_sala);

            }
            else
            {
                comprobante.TicketLista.Add(b);
                picbut28.Image = Resources.Sleected;
            }
            txbCantEntradas.Text = Convert.ToString(comprobante.TicketLista.Count);


        }

        private void picbut29_Click(object sender, EventArgs e)
        {
            Ticket b = new Ticket();

            if (Convert.ToInt32(cboTipoSal.SelectedValue) == 1)
            {
                b.Id_butaca_sala = 28;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 2)
            {
                b.Id_butaca_sala = 73;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 3)
            {
                b.Id_butaca_sala = 118;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 4)
            {
                b.Id_butaca_sala = 163;

            }
            if (comprobante.buscar(b.Id_butaca_sala))
            {
                picbut29.Image = Resources.vaciaaa;
                comprobante.remover(b.Id_butaca_sala);

            }
            else
            {
                comprobante.TicketLista.Add(b);
                picbut29.Image = Resources.Sleected;
            }
            txbCantEntradas.Text = Convert.ToString(comprobante.TicketLista.Count);


        }

        private void picbut30_Click(object sender, EventArgs e)
        {
            Ticket b = new Ticket();

            if (Convert.ToInt32(cboTipoSal.SelectedValue) == 1)
            {
                b.Id_butaca_sala = 29;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 2)
            {
                b.Id_butaca_sala = 74;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 3)
            {
                b.Id_butaca_sala = 119;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 4)
            {
                b.Id_butaca_sala = 164;

            }
            if (comprobante.buscar(b.Id_butaca_sala))
            {
                picbut30.Image = Resources.vaciaaa;
                comprobante.remover(b.Id_butaca_sala);

            }
            else
            {
                comprobante.TicketLista.Add(b);
                picbut30.Image = Resources.Sleected;
            }
            txbCantEntradas.Text = Convert.ToString(comprobante.TicketLista.Count);

        }

        private void picbut31_Click(object sender, EventArgs e)
        {
            Ticket b = new Ticket();

            if (Convert.ToInt32(cboTipoSal.SelectedValue) == 1)
            {
                b.Id_butaca_sala = 30;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 2)
            {
                b.Id_butaca_sala = 75;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 3)
            {
                b.Id_butaca_sala = 120;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 4)
            {
                b.Id_butaca_sala = 165;

            }
            if (comprobante.buscar(b.Id_butaca_sala))
            {
                picbut31.Image = Resources.vaciaaa;
                comprobante.remover(b.Id_butaca_sala);

            }
            else
            {
                comprobante.TicketLista.Add(b);
                picbut31.Image = Resources.Sleected;
            }
            txbCantEntradas.Text = Convert.ToString(comprobante.TicketLista.Count);

        }

        private void picbut32_Click(object sender, EventArgs e)
        {
            Ticket b = new Ticket();

            if (Convert.ToInt32(cboTipoSal.SelectedValue) == 1)
            {
                b.Id_butaca_sala = 31;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 2)
            {
                b.Id_butaca_sala = 76;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 3)
            {
                b.Id_butaca_sala = 121;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 4)
            {
                b.Id_butaca_sala = 166;

            }

            if (comprobante.buscar(b.Id_butaca_sala))
            {
                picbut32.Image = Resources.vaciaaa;
                comprobante.remover(b.Id_butaca_sala);

            }
            else
            {
                comprobante.TicketLista.Add(b);
                picbut32.Image = Resources.Sleected;
            }
            txbCantEntradas.Text = Convert.ToString(comprobante.TicketLista.Count);

        }

        private void picbut33_Click(object sender, EventArgs e)
        {
            Ticket b = new Ticket();

            if (Convert.ToInt32(cboTipoSal.SelectedValue) == 1)
            {
                b.Id_butaca_sala = 32;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 2)
            {
                b.Id_butaca_sala = 77;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 3)
            {
                b.Id_butaca_sala = 122;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 4)
            {
                b.Id_butaca_sala = 167;

            }
            if (comprobante.buscar(b.Id_butaca_sala))
            {
                picbut33.Image = Resources.vaciaaa;
                comprobante.remover(b.Id_butaca_sala);

            }
            else
            {
                comprobante.TicketLista.Add(b);
                picbut33.Image = Resources.Sleected;
            }
            txbCantEntradas.Text = Convert.ToString(comprobante.TicketLista.Count);

        }

        private void picbut34_Click(object sender, EventArgs e)
        {
            Ticket b = new Ticket();

            if (Convert.ToInt32(cboTipoSal.SelectedValue) == 1)
            {
                b.Id_butaca_sala = 33;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 2)
            {
                b.Id_butaca_sala = 78;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 3)
            {
                b.Id_butaca_sala = 123;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 4)
            {
                b.Id_butaca_sala = 168;

            }

            if (comprobante.buscar(b.Id_butaca_sala))
            {
                picbut34.Image = Resources.vaciaaa;
                comprobante.remover(b.Id_butaca_sala);

            }
            else
            {
                comprobante.TicketLista.Add(b);
                picbut34.Image = Resources.Sleected;
            }
            txbCantEntradas.Text = Convert.ToString(comprobante.TicketLista.Count);

        }

        private void picbut35_Click(object sender, EventArgs e)
        {
            Ticket b = new Ticket();

            if (Convert.ToInt32(cboTipoSal.SelectedValue) == 1)
            {
                b.Id_butaca_sala = 34;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 2)
            {
                b.Id_butaca_sala = 79;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 3)
            {
                b.Id_butaca_sala = 124;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 4)
            {
                b.Id_butaca_sala = 169;

            }
            if (comprobante.buscar(b.Id_butaca_sala))
            {
                picbut35.Image = Resources.vaciaaa;
                comprobante.remover(b.Id_butaca_sala);

            }
            else
            {
                comprobante.TicketLista.Add(b);
                picbut35.Image = Resources.Sleected;
            }
            txbCantEntradas.Text = Convert.ToString(comprobante.TicketLista.Count);

        }

        private void picbut36_Click(object sender, EventArgs e)
        {
            Ticket b = new Ticket();

            if (Convert.ToInt32(cboTipoSal.SelectedValue) == 1)
            {
                b.Id_butaca_sala = 35;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 2)
            {
                b.Id_butaca_sala = 80;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 3)
            {
                b.Id_butaca_sala = 125;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 4)
            {
                b.Id_butaca_sala = 170;

            }
            if (comprobante.buscar(b.Id_butaca_sala))
            {
                picbut36.Image = Resources.vaciaaa;
                comprobante.remover(b.Id_butaca_sala);

            }
            else
            {
                comprobante.TicketLista.Add(b);
                picbut36.Image = Resources.Sleected;
            }
            txbCantEntradas.Text = Convert.ToString(comprobante.TicketLista.Count);

        }

        private void picbut37_Click(object sender, EventArgs e)
        {
            Ticket b = new Ticket();

            if (Convert.ToInt32(cboTipoSal.SelectedValue) == 1)
            {
                b.Id_butaca_sala = 36;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 2)
            {
                b.Id_butaca_sala = 81;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 3)
            {
                b.Id_butaca_sala = 126;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 4)
            {
                b.Id_butaca_sala = 171;

            }
            if (comprobante.buscar(b.Id_butaca_sala))
            {
                picbut37.Image = Resources.vaciaaa;
                comprobante.remover(b.Id_butaca_sala);

            }
            else
            {
                comprobante.TicketLista.Add(b);
                picbut37.Image = Resources.Sleected;
            }
            txbCantEntradas.Text = Convert.ToString(comprobante.TicketLista.Count);

        }

        private void picbut38_Click(object sender, EventArgs e)
        {
            Ticket b = new Ticket();

            if (Convert.ToInt32(cboTipoSal.SelectedValue) == 1)
            {
                b.Id_butaca_sala = 37;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 2)
            {
                b.Id_butaca_sala = 82;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 3)
            {
                b.Id_butaca_sala = 127;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 4)
            {
                b.Id_butaca_sala = 172;

            }

            if (comprobante.buscar(b.Id_butaca_sala))
            {
                picbut38.Image = Resources.vaciaaa;
                comprobante.remover(b.Id_butaca_sala);

            }
            else
            {
                comprobante.TicketLista.Add(b);
                picbut38.Image = Resources.Sleected;
            }
            txbCantEntradas.Text = Convert.ToString(comprobante.TicketLista.Count);

        }

        private void picbut39_Click(object sender, EventArgs e)
        {
            Ticket b = new Ticket();

            if (Convert.ToInt32(cboTipoSal.SelectedValue) == 1)
            {
                b.Id_butaca_sala = 38;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 2)
            {
                b.Id_butaca_sala = 83;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 3)
            {
                b.Id_butaca_sala = 128;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 4)
            {
                b.Id_butaca_sala = 173;

            }

            if (comprobante.buscar(b.Id_butaca_sala))
            {
                picbut39.Image = Resources.vaciaaa;
                comprobante.remover(b.Id_butaca_sala);

            }
            else
            {
                comprobante.TicketLista.Add(b);
                picbut39.Image = Resources.Sleected;
            }
            txbCantEntradas.Text = Convert.ToString(comprobante.TicketLista.Count);


        }

        private void picbut40_Click(object sender, EventArgs e)
        {
            Ticket b = new Ticket();

            if (Convert.ToInt32(cboTipoSal.SelectedValue) == 1)
            {
                b.Id_butaca_sala = 39;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 2)
            {
                b.Id_butaca_sala = 84;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 3)
            {
                b.Id_butaca_sala = 129;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 4)
            {
                b.Id_butaca_sala = 174;

            }
            if (comprobante.buscar(b.Id_butaca_sala))
            {
                picbut40.Image = Resources.vaciaaa;
                comprobante.remover(b.Id_butaca_sala);

            }
            else
            {
                comprobante.TicketLista.Add(b);
                picbut40.Image = Resources.Sleected;
            }
            txbCantEntradas.Text = Convert.ToString(comprobante.TicketLista.Count);

        }

        private void picbut41_Click(object sender, EventArgs e)
        {
            Ticket b = new Ticket();

            if (Convert.ToInt32(cboTipoSal.SelectedValue) == 1)
            {
                b.Id_butaca_sala = 40;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 2)
            {
                b.Id_butaca_sala = 85;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 3)
            {
                b.Id_butaca_sala = 130;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 4)
            {
                b.Id_butaca_sala = 175;

            }
            if (comprobante.buscar(b.Id_butaca_sala))
            {
                picbut41.Image = Resources.vaciaaa;
                comprobante.remover(b.Id_butaca_sala);

            }
            else
            {
                comprobante.TicketLista.Add(b);
                picbut41.Image = Resources.Sleected;
            }
            txbCantEntradas.Text = Convert.ToString(comprobante.TicketLista.Count);

        }

        private void picbut42_Click(object sender, EventArgs e)
        {
            Ticket b = new Ticket();

            if (Convert.ToInt32(cboTipoSal.SelectedValue) == 1)
            {
                b.Id_butaca_sala = 41;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 2)
            {
                b.Id_butaca_sala = 86;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 3)
            {
                b.Id_butaca_sala = 131;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 4)
            {
                b.Id_butaca_sala = 176;

            }
            if (comprobante.buscar(b.Id_butaca_sala))
            {
                picbut42.Image = Resources.vaciaaa;
                comprobante.remover(b.Id_butaca_sala);

            }
            else
            {
                comprobante.TicketLista.Add(b);
                picbut42.Image = Resources.Sleected;
            }
            txbCantEntradas.Text = Convert.ToString(comprobante.TicketLista.Count);

        }

        private void picbut43_Click(object sender, EventArgs e)
        {
            Ticket b = new Ticket();

            if (Convert.ToInt32(cboTipoSal.SelectedValue) == 1)
            {
                b.Id_butaca_sala = 42;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 2)
            {
                b.Id_butaca_sala = 87;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 3)
            {
                b.Id_butaca_sala = 132;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 4)
            {
                b.Id_butaca_sala = 177;

            }
            if (comprobante.buscar(b.Id_butaca_sala))
            {
                picbut43.Image = Resources.vaciaaa;
                comprobante.remover(b.Id_butaca_sala);

            }
            else
            {
                comprobante.TicketLista.Add(b);
                picbut43.Image = Resources.Sleected;
            }
            txbCantEntradas.Text = Convert.ToString(comprobante.TicketLista.Count);

        }

        private void picbut44_Click(object sender, EventArgs e)
        {
            Ticket b = new Ticket();

            if (Convert.ToInt32(cboTipoSal.SelectedValue) == 1)
            {
                b.Id_butaca_sala = 43;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 2)
            {
                b.Id_butaca_sala = 88;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 3)
            {
                b.Id_butaca_sala = 133;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 4)
            {
                b.Id_butaca_sala = 178;

            }
            if (comprobante.buscar(b.Id_butaca_sala))
            {
                picbut44.Image = Resources.vaciaaa;
                comprobante.remover(b.Id_butaca_sala);

            }
            else
            {
                comprobante.TicketLista.Add(b);
                picbut44.Image = Resources.Sleected;
            }
            txbCantEntradas.Text = Convert.ToString(comprobante.TicketLista.Count);

        }

        private void picbut45_Click(object sender, EventArgs e)
        {
            Ticket b = new Ticket();

            if (Convert.ToInt32(cboTipoSal.SelectedValue) == 1)
            {
                b.Id_butaca_sala = 44;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 2)
            {
                b.Id_butaca_sala = 89;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 3)
            {
                b.Id_butaca_sala = 134;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 4)
            {
                b.Id_butaca_sala = 179;

            }
            if (comprobante.buscar(b.Id_butaca_sala))
            {
                picbut45.Image = Resources.vaciaaa;
                comprobante.remover(b.Id_butaca_sala);

            }
            else
            {
                comprobante.TicketLista.Add(b);
                picbut45.Image = Resources.Sleected;
            }
            txbCantEntradas.Text = Convert.ToString(comprobante.TicketLista.Count);

        }

        private void picbut46_Click(object sender, EventArgs e)
        {
            Ticket b = new Ticket();

            if (Convert.ToInt32(cboTipoSal.SelectedValue) == 1)
            {
                b.Id_butaca_sala = 45;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 2)
            {
                b.Id_butaca_sala = 90;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 3)
            {
                b.Id_butaca_sala = 135;

            }
            else if (Convert.ToInt32(cboTipoSal.SelectedValue) == 4)
            {
                b.Id_butaca_sala = 180;

            }
            if (comprobante.buscar(b.Id_butaca_sala))
            {
                picbut46.Image = Resources.vaciaaa;
                comprobante.remover(b.Id_butaca_sala);

            }
            else
            {
                comprobante.TicketLista.Add(b);
                picbut46.Image = Resources.Sleected;
            }
            txbCantEntradas.Text = Convert.ToString(comprobante.TicketLista.Count);

        }

        private void btncon_Click_1(object sender, EventArgs e)
        {
            if (fac.listComprobobante.Count != 0)
            {
                fac.Lcomprobantes = fac.listComprobobante;
                Pago pago = new Pago(fac);
                if (pago.ShowDialog() == DialogResult.OK)
                {
                    limpiar();
                }
            }
            else
            {
                MessageBox.Show("Debe cargar al menos una funcion");
            }
        }

        private void limpiar()
        {
            fac = new Factura();
            comprobante = new Comprobante();
            but = new List<Butaca>();
            but_selected = new List<Butaca>();
            dgvComprobantes.Rows.Clear();
            TxbTotal.Text = "";
            TxbSubtotal.Text = "";
            txbCantEntradas.Text = "";
            reiniciar_cbo();
        }

        private void dgvComprobantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvComprobantes.Columns[e.ColumnIndex].Name == "qitar")

            {
                fac.remover(dgvComprobantes.CurrentRow.Index);
                dgvComprobantes.Rows.Remove(dgvComprobantes.CurrentRow);
                cargar_txb_montos();
            }

        }
    }
}
