using CineHoytsBack.Dominio.Campos;
using CineHoytsFront.Servicio;
using Newtonsoft.Json;
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
using Cine_Hoyts.Dominio;
using System.IO;

namespace CineHoytsFront.Formularios
{
    public partial class CrudPelicula : Form
    {
        List<Pelicula> lp = new List<Pelicula>();
        Pelicula pelSelected = new Pelicula();

        public CrudPelicula()
        {
            InitializeComponent();
        }

        private async void CrudPelicula_Load(object sender, EventArgs e)
        {
            await CargarComboAsyncRestriccion();
            await CargarComboAsyncProduccion();
            lp = await CargarPelicula();
            cargar_dgv();
        }

        private void cargar_dgv()
        {
            dgvPel.Rows.Clear();
            if (lp is null)
            {
            }
            foreach (Pelicula f in lp)
            {
                try
                {
                    dgvPel.Rows.Add(f.id_pel, f.Titulo, f.Duracion, f.productor, f.Edad);
                }
                catch (Exception)
                {
                }
            }
        }

        private async Task<List<Pelicula>> CargarPelicula()
        {
            string url = "https://localhost:7271/api/CPelicula/PeliculasCrud";
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            pnlCrud.Visible = true;
            habilitar_todo_btn(true);
            habilitar_todo_nuevo(true);
            btnNuevo.Enabled = false;
            btnBorrar.Enabled = false;
            btnMod.Enabled = false;
            BtnGuardar.Enabled = true;
            pnlCrud.Visible = true;
        }


        private void habilitar_todo_nuevo(bool a)
        {
            txbTitulo.Enabled = a;
            TxtDesc.Enabled = a;
            cboprod.Enabled = a;
            cborestrc.Enabled = a;
            btnSubirImagen.Enabled = a;
            numDuracion.Enabled = a;

        }


        private void habilitar_todo_btn(bool a)
        {
            btnNuevo.Enabled = a;
            btnMod.Enabled = a;
            btnBorrar.Enabled = a;
            BtnGuardar.Enabled = a;
        }
        private void picdesplegar_Click(object sender, EventArgs e)
        {
            pnlCrud.Visible = false;
            habilitar_todo_btn(true);
            btnMod.Enabled = false;
            BtnGuardar.Enabled = false;
            btnBorrar.Enabled = false;
            Limpiar();

        }

        private void picLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            txbTitulo.Text = "";
            TxtDesc.Text = "";
            numDuracion.Value = 0;
            cboprod.SelectedIndex = -1;
            cborestrc.SelectedIndex = -1;
            picImage.Image = Resources.carrete_de_pelicula;
            picImage.Tag = "NO";
            pelSelected = new Pelicula();

        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            deshabilitar_Campos(true);

            btnMod.Enabled = false;
            BtnGuardar.Enabled = true;
            btnBorrar.Enabled = false;
        }

        private async  void btnBorrar_Click(object sender, EventArgs e)
        {

            if (await Bajar_pel(pelSelected.id_pel))
            {
                MessageBox.Show("Pelicula bajada con Exito");
            }
            else
            {
                MessageBox.Show("Problema al bajar la pelicula, Intentelo de nuevo más tarde");

            }
            lp = await CargarPelicula();
            cargar_dgv();
            pnlCrud.Visible = false;
            habilitar_todo_btn(true);
            btnMod.Enabled = false;
            BtnGuardar.Enabled = false;
            btnBorrar.Enabled = false;
        }

        private async void BtnGuardar_Click(object sender, EventArgs e)
        {

            if (validar_campos())
            {
                Pelicula p = new Pelicula();
                AbstraerPeli(p);
                if (await Buscar_Pel(pelSelected.id_pel))
                {
                    p.id_pel = pelSelected.id_pel;
                    if (await updatePeli(p))
                    {
                        MessageBox.Show("Modificado Correctamente");
                        lp = await CargarPelicula();
                        cargar_dgv();
                        pnlCrud.Visible = false;
                        habilitar_todo_btn(true);
                        btnMod.Enabled = false;
                        BtnGuardar.Enabled = false;
                        btnBorrar.Enabled = false;
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Problema con el servidor, Intentelo de nuevo más tarde");

                    }
                }
                else
                {
                    if (await InsertPeli(p))
                    {
                        MessageBox.Show("Pelicula Agregada Correctamente");
                        lp = await CargarPelicula();
                        cargar_dgv();
                        pnlCrud.Visible = false;
                        habilitar_todo_btn(true);
                        btnMod.Enabled = false;
                        BtnGuardar.Enabled = false;
                        btnBorrar.Enabled = false;
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Problema con el servidor, Intentelo de nuevo más tarde");

                    }
                }
            }

        }

        private void AbstraerPeli(Pelicula p)
        {
            p.Titulo = txbTitulo.Text;
            p.Descripcion = TxtDesc.Text;
            p.Duracion = Convert.ToInt32(numDuracion.Value);
            p.id_edad = Convert.ToInt32(cborestrc.SelectedValue);
            p.id_prod = Convert.ToInt32(cborestrc.SelectedValue);
            p.Imagen = Convertir_Imagen();
        }
        private async Task<bool> updatePeli(Pelicula c)
        {
            string url = "https://localhost:7271/api/CPelicula/Modificar_Pel";
            string FiltrosJson = JsonConvert.SerializeObject(c);
            var data = await ClaseSingleton.GetInstance().PostAsync(url, FiltrosJson);
            return JsonConvert.DeserializeObject<bool>(data);

        }

        private async Task<bool> InsertPeli(Pelicula c)
        {
            string url = "https://localhost:7271/api/CPelicula/Insert_Pel";
            string FiltrosJson = JsonConvert.SerializeObject(c);
            var data = await ClaseSingleton.GetInstance().PostAsync(url, FiltrosJson);
            return JsonConvert.DeserializeObject<bool>(data);

        }
        private bool validar_campos()
        {
            if (txbTitulo.Text == "")
            {
                MessageBox.Show("Debe cargar el titulo de la pelicua");
                return false;
            }
            else if (cborestrc.SelectedIndex == -1)
            {
                MessageBox.Show("Debe la Restriccion de edad");
                return false;

            }
            else if (cboprod.SelectedIndex == -1)
            {
                MessageBox.Show("Debe cargar el productor de la pelicula");

                return false;

            }
            else if (TxtDesc.Text == "")
            {
                MessageBox.Show("Debe cargar la descripcion");

                return false;

            }
            else if (picImage.Tag.ToString() == "NO")
            {
                MessageBox.Show("Debe cargar una imagen");

                return false;
            }
            else if (numDuracion.Value == 0)
            {
                MessageBox.Show("Debe cargar la duracion");

                return false;
            }
            return true;

        }

        private void dgvPel_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            pelSelected = new Pelicula();
            pelSelected.id_pel =  lp[dgvPel.CurrentRow.Index].id_pel;
            pelSelected.Titulo = lp[dgvPel.CurrentRow.Index].Titulo;
            pelSelected.Duracion = lp[dgvPel.CurrentRow.Index].Duracion;
            pelSelected.Edad = lp[dgvPel.CurrentRow.Index].Edad;
            pelSelected.productor = lp[dgvPel.CurrentRow.Index].productor;
            pelSelected.Descripcion = lp[dgvPel.CurrentRow.Index].Descripcion;
            pelSelected.id_edad = lp[dgvPel.CurrentRow.Index].id_edad;
            pelSelected.id_prod = lp[dgvPel.CurrentRow.Index].id_prod;
            pelSelected.Imagen = lp[dgvPel.CurrentRow.Index].Imagen;



            txbTitulo.Text = pelSelected.Titulo;
            TxtDesc.Text = pelSelected.Descripcion;
            numDuracion.Value = pelSelected.Duracion;
            cborestrc.SelectedValue = pelSelected.Edad;
            cboprod.SelectedValue = pelSelected.id_prod;
            cborestrc.SelectedValue = pelSelected.id_edad;
            MemoryStream ms = new MemoryStream(pelSelected.Imagen);
            picImage.Image = Image.FromStream(ms);
            picImage.Tag = "SI";



            pnlCrud.Visible = true;
            picLimpiar.Visible = false;
            habilitar_todo_btn(false);
            btnMod.Enabled = true;
            btnBorrar.Enabled = true;
            deshabilitar_Campos(false);



        }


        private void deshabilitar_Campos(bool a)
        {
            txbTitulo.Enabled = a;
            TxtDesc.Enabled = a;
            cboprod.Enabled = a;
            cborestrc.Enabled = a;
            btnSubirImagen.Enabled = a;
            numDuracion.Enabled = a;

        }

        private async Task<bool> Bajar_pel(int a)
        {
            string url = "https://localhost:7271/api/CPelicula/BajarPel?a=" + a.ToString();
            var data = await ClaseSingleton.GetInstance().GetAsync(url);
            return JsonConvert.DeserializeObject<bool>(data);

        }

        private async Task<bool> Buscar_Pel(int a)
        {
            string url = "https://localhost:7271/api/CPelicula/SearchPel?a=" + a.ToString();
            var data = await ClaseSingleton.GetInstance().GetAsync(url);

            return JsonConvert.DeserializeObject<bool>(data);

        }

        private void btnSubirImagen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picImage.Image = Image.FromFile(@"" + openFileDialog1.FileName + "");
                picImage.SizeMode = PictureBoxSizeMode.Zoom;
                picImage.Tag = "SI";
            }

        }



        private byte[] Convertir_Imagen()
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            picImage.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.GetBuffer();
        }
    }
}
