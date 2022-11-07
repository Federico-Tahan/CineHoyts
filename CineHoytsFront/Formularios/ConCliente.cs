using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cine_Hoyts.Datos;
using Cine_Hoyts.Dominio;
using CineHoytsBack.Dominio;
using CineHoytsFront.Servicio;
using Newtonsoft.Json;

namespace Cine_Project
{
    public partial class ConCliente : Form
    {
        List<Cliente> clientes = new List<Cliente>();
        public ConCliente()
        {
            InitializeComponent();
            this.toolTip1.SetToolTip(this.pctFilter, "Filtros avanzados");
            this.toolTip1.SetToolTip(this.picreset, "Reiniciar filtros");

        }
        private async void ConCliente_Load(object sender, EventArgs e)
        {
            pnlFiltro.Visible = false;
            dtpInicio.Value = DateTime.Now.Date;
            await CargarComboAsyncTipoDoc();       
            await Cargar_Clientes();
            CargarDgvMonto();
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
        private async Task CargarComboAsyncTipoDoc()
        {
            string url = "https://localhost:7271/api/Tablas/GetDocumentos";
            var data = await ClaseSingleton.GetInstance().GetAsync(url);
            List<TipoDoc> lst = JsonConvert.DeserializeObject<List<TipoDoc>>(data);
            if (lst is null)
            {
            }
            else
            {
                CboTipoDoc.DataSource = lst;
                CboTipoDoc.ValueMember = "IdTipoDoc";
                CboTipoDoc.DisplayMember = "TipoDocumento";
                CboTipoDoc.DropDownStyle = ComboBoxStyle.DropDownList;
                CboTipoDoc.SelectedIndex = -1;
            }
        }
        private async void picreset_Click(object sender, EventArgs e)
        {
            txbNombre.Text = "";
            rbtGenFem.Checked = false;
            rdbMasc.Checked = false;
            pnlFiltro.Visible = false;
            dtpNac.Value = DateTime.Now;
            dtpInicio.Value = DateTime.Now.Date;
            dtpFin.Value = DateTime.Now;
            CboTipoDoc.SelectedIndex = -1;
            await Cargar_Clientes();
            CargarDgvMonto();
        }
        private void CargarDgvMonto()
        {
            dgvCliente.Rows.Clear();
            if (clientes is null)
            {

            }
            else
            {
                for (int i = 0; i < clientes.Count; i++)
                {
                    string sex = "";
                    if (clientes[i].per.Sexo == 1)
                    {
                        sex = "Masculino";
                    }
                    else
                    {
                        sex = "Femenino";

                    }
                    string tip_doc = "";
                    if (clientes[i].per.Id_tipo_documento == 1)
                    {
                        tip_doc = "Libreta civica";
                    }
                    else if (clientes[i].per.Id_tipo_documento == 2)
                    {
                        tip_doc = "Documento Nacional de Identidad";
                    }
                    else if (clientes[i].per.Id_tipo_documento == 3)
                    {
                        tip_doc = "Cédula de Identidad";
                    }
                    else
                    {
                        tip_doc = "Libreta de Enrolamiento";
                    }

                    try
                    {
                        dgvCliente.Rows.Add(clientes[i].Id_Cliente.ToString(), clientes[i].per.Nombre + " " + clientes[i].per.Apellido, clientes[i].per.Nro_Documento.ToString(),
                          clientes[i].per.Fecha_Nac, sex, tip_doc, "$ "+ clientes[i].TotalGastado);
                    }
                    catch (Exception)
                    {

                    }


                }
            }
                

           
        }
        public async Task Cargar_Clientes()
        {
            string url = "https://localhost:7271/api/CRUDcliente/GetClienteConVenta";
            var data = await ClaseSingleton.GetInstance().GetAsync(url);
            clientes = JsonConvert.DeserializeObject<List<Cliente>>(data);
            if (clientes is null)
            {
                MessageBox.Show("Demasiadas solicitudes, Intentelo de nuevo más tarde");
            }
        }
        public async Task Cargar_Clientes_filter(List<Parametro> pm)
        {
            string FiltrosJson = JsonConvert.SerializeObject(pm);
            string url = "https://localhost:7271/api/CRUDcliente/GetClienteConVentaRango";
            var data = await ClaseSingleton.GetInstance().PostAsync(url,FiltrosJson);

            clientes = JsonConvert.DeserializeObject<List<Cliente>>(data);
            if (clientes is null)
            {
                MessageBox.Show("Demasiadas solicitudes, Intentelo de nuevo más tarde");
            }
        }

        public async Task Cargar_Clientes_filter_name(Parametro pm)
        {
            string FiltrosJson = JsonConvert.SerializeObject(pm);
            string url = "https://localhost:7271/api/CRUDcliente/GetClienteConFilter";
            var data = await ClaseSingleton.GetInstance().PostAsync(url, FiltrosJson);

            clientes = JsonConvert.DeserializeObject<List<Cliente>>(data);
            if (clientes is null)
            {
                MessageBox.Show("Demasiadas solicitudes, Intentelo de nuevo más tarde");
            }
        }

        public async Task Cargar_Clientes_filter_name(List<Parametro> pm)
        {
            string FiltrosJson = JsonConvert.SerializeObject(pm);
            string url = "https://localhost:7271/api/CRUDcliente/GetClienteConVentaRango_filter";
            var data = await ClaseSingleton.GetInstance().PostAsync(url, FiltrosJson);

            clientes = JsonConvert.DeserializeObject<List<Cliente>>(data);
            if (clientes is null)
            {
                MessageBox.Show("Demasiadas solicitudes, Intentelo de nuevo más tarde");
            }
        }
        private async void btnBuscar_Click_1(object sender, EventArgs e)
        {
            CargarDgvMonto();
            pnlFiltro.Visible = false;
            if (txbNombre.Text != "" && dtpInicio.Value.Date != DateTime.Now.Date)
            {


                List<Parametro> pm = new List<Parametro>();
                pm.Add(new Parametro("@fecha1", dtpInicio.Value.ToShortDateString()));
                pm.Add(new Parametro("@fecha2", dtpFin.Value.ToShortDateString()));
                pm.Add(new Parametro("@nombre", txbNombre.Text));
                await Cargar_Clientes_filter_name(pm);
                CargarDgvMonto();

            }else if (dtpInicio.Value.Date != DateTime.Now.Date)
            {
                List<Parametro> pm = new List<Parametro>();
                pm.Add(new Parametro("@fecha1", dtpInicio.Value.ToShortDateString()));
                pm.Add(new Parametro("@fecha2", dtpFin.Value.ToShortDateString()));
                await Cargar_Clientes_filter(pm);
                CargarDgvMonto();

            }else if (txbNombre.Text != "")
            {
                Parametro pm = new Parametro("@nombre", txbNombre.Text);
                await Cargar_Clientes_filter_name(pm);
                CargarDgvMonto();
                
            }
            if (rbtGenFem.Checked)
            {
                List<DataGridViewRow> temp = new List<DataGridViewRow>();

                foreach (DataGridViewRow row in dgvCliente.Rows)
                {
                    if (Convert.ToString(row.Cells["genero"].Value) != "Femenino")
                    {
                        temp.Add(row);
                    }

                }

                foreach (DataGridViewRow row in temp)
                {

                    dgvCliente.Rows.Remove(row);

                }
            }
            if (rdbMasc.Checked)
            {
                List<DataGridViewRow> temp = new List<DataGridViewRow>();

                foreach (DataGridViewRow row in dgvCliente.Rows)
                {
                    if (Convert.ToString(row.Cells["genero"].Value) != "Masculino")
                    {
                        temp.Add(row);
                    }

                }

                foreach (DataGridViewRow row in temp)
                {

                    dgvCliente.Rows.Remove(row);

                }
            }
            if (dtpNac.Value.Date != DateTime.Now.Date)
            {
                List<DataGridViewRow> temp = new List<DataGridViewRow>();

                foreach (DataGridViewRow row in dgvCliente.Rows)
                {
                    if (Convert.ToDateTime(row.Cells["Fecha_nac"].Value) != dtpNac.Value.Date)
                    {
                        temp.Add(row);
                    }

                }

                foreach (DataGridViewRow row in temp)
                {

                    dgvCliente.Rows.Remove(row);

                }
            }
            if (CboTipoDoc.SelectedIndex != -1)
            {
                List<DataGridViewRow> temp = new List<DataGridViewRow>();

                foreach (DataGridViewRow row in dgvCliente.Rows)
                {
                    if (Convert.ToString(row.Cells["Tipo_cliente"].Value) != CboTipoDoc.Text)
                    {
                        temp.Add(row);
                    }

                }

                foreach (DataGridViewRow row in temp)
                {

                    dgvCliente.Rows.Remove(row);

                }
            }
        }
    }
}
