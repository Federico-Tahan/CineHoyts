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
using CineHoytsBack.Dominio.Campos;
using CineHoytsFront.Servicio;
using Newtonsoft.Json;

namespace Cine_Project
{
    public partial class ConPelicula : Form
    {
        List<Pelicula> lp = new List<Pelicula>();
        public ConPelicula()
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
        private async void ConPelicula_Load(object sender, EventArgs e)
        {
            pnlFiltro.Visible = false;
            lp = await CargarPelicula();
            cargar_dgv();
            await CargarComboAsyncProduccion();
            await CargarComboAsyncRestriccion();
        }

        private async Task CargarComboAsyncProduccion()
        {
            string url = "https://localhost:7271/api/Tablas/ProduccionCBO";
            var data = await ClaseSingleton.GetInstance().GetAsync(url);
            List<Produccion> lst = JsonConvert.DeserializeObject<List<Produccion>>(data);
            if (data == "")
            {

            }
            else
            {
                cboprod.DataSource = lst;
                cboprod.ValueMember = "Id_produccion";
                cboprod.DisplayMember = "produccion";
                cboprod.DropDownStyle = ComboBoxStyle.DropDownList;
                cboprod.SelectedIndex = -1;
            }
            

        }

        private async Task<List<Pelicula>> CargarPelicula()
        {
            string url = "https://localhost:7271/api/CPelicula/PeliculaGet";
            var data = await ClaseSingleton.GetInstance().GetAsync(url);
            if (data  == "")
            {
                return new List<Pelicula>();
            }
            return JsonConvert.DeserializeObject<List<Pelicula>>(data);


        }

        private async Task<List<Pelicula>> CargarPeliculaFilter(string nombre)
        {
            string url = "https://localhost:7271/api/CPelicula/PeliculaFilterGet?nombre=" + nombre;
            var data = await ClaseSingleton.GetInstance().GetAsync(url);
            if (data == "")
            {
                return new List<Pelicula>();
            }
            return JsonConvert.DeserializeObject<List<Pelicula>>(data);


        }

        private async Task CargarComboAsyncRestriccion()
        {
            string url = "https://localhost:7271/api/Tablas/restriccionCBO";
            var data = await ClaseSingleton.GetInstance().GetAsync(url);
            List<restriccion> lst = JsonConvert.DeserializeObject<List<restriccion>>(data);
            if (data == "")
            {

            }
            else
            {
                cborestrc.DataSource = lst;
                cborestrc.ValueMember = "Id_Restriccion";
                cborestrc.DisplayMember = "Restriccion";
                cborestrc.DropDownStyle = ComboBoxStyle.DropDownList;
                cborestrc.SelectedIndex = -1;
            }
        }



        private void cargar_dgv()
        {
            dgvPel.Rows.Clear();
            if (lp is null)
            {
            }
            foreach (Pelicula f in lp )
            {
                try
                {
                    dgvPel.Rows.Add(f.id_pel, f.Titulo, f.Duracion, f.productor, f.Edad, f.Espectadores);
                }
                catch (Exception)
                {
                }
            }
        }

        private async void picreset_Click(object sender, EventArgs e)
        {
            cborestrc.SelectedIndex = -1;
            cboprod.SelectedIndex = -1;
            numespc.Value = 0;
            nummin.Value = 0;
            txbNombre.Text = "";
            lp = await CargarPelicula();
            cargar_dgv();
            pnlFiltro.Visible = false;
        }

        private async void btnBuscar_Click_1(object sender, EventArgs e)
        {
            pnlFiltro.Visible = false;
            cargar_dgv();
            if (txbNombre.Text != "")
            {

                lp = await CargarPeliculaFilter(txbNombre.Text);
                cargar_dgv();
            }
            else
            {
                lp = await CargarPelicula();
                cargar_dgv();
            }
            if (cboprod.SelectedIndex != -1)
            {
                List<DataGridViewRow> temp = new List<DataGridViewRow>();

                foreach (DataGridViewRow row in dgvPel.Rows)
                {
                    if (Convert.ToString(row.Cells["Produccion"].Value) != cboprod.Text)
                    {
                        temp.Add(row);
                    }

                }

                foreach (DataGridViewRow row in temp)
                {

                    dgvPel.Rows.Remove(row);

                }
            }
            if (cborestrc.SelectedIndex != -1)
            {
                List<DataGridViewRow> temp = new List<DataGridViewRow>();

                foreach (DataGridViewRow row in dgvPel.Rows)
                {
                    if (Convert.ToInt32(row.Cells["Restriccion"].Value) != Convert.ToInt32(cborestrc.Text))
                    {
                        temp.Add(row);
                    }

                }

                foreach (DataGridViewRow row in temp)
                {

                    dgvPel.Rows.Remove(row);

                }
            }
            if (nummin.Value != 0)
            {
                List<DataGridViewRow> temp = new List<DataGridViewRow>();

                foreach (DataGridViewRow row in dgvPel.Rows)
                {
                    if (Convert.ToInt32(row.Cells["Duracion"].Value) < nummin.Value)
                    {
                        temp.Add(row);
                    }

                }

                foreach (DataGridViewRow row in temp)
                {

                    dgvPel.Rows.Remove(row);

                }
            }
            if (numespc.Value != 0)
            {
                List<DataGridViewRow> temp = new List<DataGridViewRow>();

                foreach (DataGridViewRow row in dgvPel.Rows)
                {
                    if (Convert.ToInt32(row.Cells["Total"].Value) < numespc.Value)
                    {
                        temp.Add(row);
                    }

                }

                foreach (DataGridViewRow row in temp)
                {

                    dgvPel.Rows.Remove(row);

                }
            }
        }
    }
}
