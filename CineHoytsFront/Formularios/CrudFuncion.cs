using Cine_Hoyts.Dominio;
using CineHoytsBack.Dominio;
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

namespace CineHoytsFront.Formularios
{
    public partial class CrudFuncion : Form
    {

        List<Funcion> lp = new List<Funcion>();
        Funcion funSelected = new Funcion();
        public CrudFuncion()
        {
            InitializeComponent();
        }

        private async void CrudFuncion_Load(object sender, EventArgs e)
        {
            await CargarComboAsyncPelicula();
            await CargarComboAsyncIdioma();
            await CargarComboAsyncHora();
            await CargarComboAsyncTipoSala();
            await CargarComboAsyncFuncion();
            Cargar_DGV();
        }

        private async Task CargarComboAsyncPelicula()
        {
            string url = "https://localhost:7271/api/Tablas/PeliculaCbofun";
            var data = await ClaseSingleton.GetInstance().GetAsync(url);
            List<Pelicula> lst = JsonConvert.DeserializeObject<List<Pelicula>>(data);
            cboPel.DataSource = lst;
            cboPel.ValueMember = "id_pel";
            cboPel.DisplayMember = "titulo";
            cboPel.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPel.SelectedIndex = -1;

        }

        private async Task CargarComboAsyncFuncion()
        {
            string url = "https://localhost:7271/api/Tablas/Fun";
            var data = await ClaseSingleton.GetInstance().GetAsync(url);
            if(data == null)
            {
                lp = new List<Funcion>();
            }
            else
            {
                lp = JsonConvert.DeserializeObject<List<Funcion>>(data);

            }
        }
        private async Task CargarComboAsyncHora()
        {
            string url = "https://localhost:7271/api/Tablas/HorarioCboFun";
            var data = await ClaseSingleton.GetInstance().GetAsync(url);

            List<Hora> lst = JsonConvert.DeserializeObject<List<Hora>>(data);
            cboHorario.DataSource = lst;
            cboHorario.ValueMember = "id_hora";
            cboHorario.DisplayMember = "Horario";
            cboHorario.DropDownStyle = ComboBoxStyle.DropDownList;
            cboHorario.SelectedIndex = -1;

        }

        private async Task CargarComboAsyncTipoSala()
        {
            string url = "https://localhost:7271/api/Tablas/SalaFun";
            var data = await ClaseSingleton.GetInstance().GetAsync(url);

            List<TipoSala> lst = JsonConvert.DeserializeObject<List<TipoSala>>(data);
            Cbosala.DataSource = lst;
            Cbosala.ValueMember = "id_tipoSala";
            Cbosala.DisplayMember = "tiposala";
            Cbosala.DropDownStyle = ComboBoxStyle.DropDownList;
            Cbosala.SelectedIndex = -1;

        }

        private async Task CargarComboAsyncIdioma()
        {
            string url = "https://localhost:7271/api/Tablas/IdiomaCBO_crud_fun";
            var data = await ClaseSingleton.GetInstance().GetAsync(url);

            List<Idioma> lst = JsonConvert.DeserializeObject<List<Idioma>>(data);
            Cboidioma.DataSource = lst;
            Cboidioma.ValueMember = "id_idioma";
            Cboidioma.DisplayMember = "idiom";
            Cboidioma.DropDownStyle = ComboBoxStyle.DropDownList;
            Cboidioma.SelectedIndex = -1;

        }

        private async Task<bool> Bajar_fun(int a)
        {
            string url = "https://localhost:7271/api/Tablas/BajaFun?a=" + a.ToString(); ;
            var data = await ClaseSingleton.GetInstance().GetAsync(url);

            return JsonConvert.DeserializeObject<bool>(data);


        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            pnlCrud.Visible = true;
            habilitar_todo_btn(true);
            habilitar_todo_nuevo(true);
            Limpiar();
            btnNuevo.Enabled = false;
            btnBorrar.Enabled = false;
            btnMod.Enabled = false;
            BtnGuardar.Enabled = true;
            pnlCrud.Visible = true;
        }

        private void habilitar_todo_nuevo(bool a)
        {
            cboHorario.Enabled = a;
            cboPel.Enabled = a;
            Cboidioma.Enabled = a;
            Cbosala.Enabled = a;
            numMonto.Enabled = a;
            dtpFechaFun.Enabled = a;

        }

        private void picLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }


        private void Limpiar()
        {
            cboPel.SelectedIndex = -1;
            cboHorario.SelectedIndex = -1;
            Cboidioma.SelectedIndex = -1;
            Cbosala.SelectedIndex = -1;
            dtpFechaFun.Value = DateTime.Now;
            numMonto.Value = 0;
            funSelected = new Funcion();
            
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

        private void habilitar_todo_btn(bool a)
        {
            btnNuevo.Enabled = a;
            btnMod.Enabled = a;
            btnBorrar.Enabled = a;
            BtnGuardar.Enabled = a;
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            deshabilitar_Campos(true);

            btnMod.Enabled = false;
            BtnGuardar.Enabled = true;
            btnBorrar.Enabled = false;
        }

        private void deshabilitar_Campos(bool a)
        {
            cboPel.Enabled = a;
            cboHorario.Enabled = a;
            Cboidioma.Enabled = a;
            Cbosala.Enabled = a;
            dtpFechaFun.Enabled = a;
            numMonto.Enabled = a;

        }

        private async void btnBorrar_Click(object sender, EventArgs e)
        {
            if (await Bajar_fun(funSelected.id_funcion))
            {
                MessageBox.Show("Funcion Bajada conExito");
                pnlCrud.Visible = false;
                habilitar_todo_btn(true);
                btnMod.Enabled = false;
                BtnGuardar.Enabled = false;
                btnBorrar.Enabled = false;
                await CargarComboAsyncFuncion();
                Cargar_DGV();
            }
            else
            {
                MessageBox.Show("Problema al bajar Funcion");

            }

        }

        private async Task<bool> AltaFun(Funcion pm)
        {
            string url = "https://localhost:7271/api/Tablas/AltaFun";
            string FiltrosJson = JsonConvert.SerializeObject(pm);
            var data = await ClaseSingleton.GetInstance().PostAsync(url, FiltrosJson);
            return JsonConvert.DeserializeObject<bool>(data);
           
        }

        private async void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                Funcion f = new Funcion();
                AbstraerFuncion(f);
                if (await buscar(funSelected.id_funcion))
                {
                    f.id_funcion = funSelected.id_funcion;
                    if (await UpdateFun(f))
                    {
                        MessageBox.Show("Modificacion de funcion realizada con Exito");
                        pnlCrud.Visible = false;
                        habilitar_todo_btn(true);
                        btnMod.Enabled = false;
                        BtnGuardar.Enabled = false;
                        btnBorrar.Enabled = false;
                        Limpiar();
                        await CargarComboAsyncFuncion();
                        Cargar_DGV();
                    }
                }
                else
                {
                    if (await AltaFun(f))
                    {
                        MessageBox.Show("Alta de funcion realizada con Exito");
                        pnlCrud.Visible = false;
                        habilitar_todo_btn(true);
                        btnMod.Enabled = false;
                        BtnGuardar.Enabled = false;
                        btnBorrar.Enabled = false;
                        Limpiar();
                        await CargarComboAsyncFuncion();
                        Cargar_DGV();
                    }
                    else
                    {
                        MessageBox.Show("Alta de funcion no se pudo realizar");

                    }
                }
            }


        }

        private async Task<bool> UpdateFun(Funcion f)
        {
            string url = "https://localhost:7271/api/Tablas/UpdateFun";
            string FiltrosJson = JsonConvert.SerializeObject(f);
            var data = await ClaseSingleton.GetInstance().PostAsync(url, FiltrosJson);
            return JsonConvert.DeserializeObject<bool>(data);
        }

        private async Task<bool> buscar(int id_funcion)
        {
            string url = "https://localhost:7271/api/Tablas/BuscarFun?a=" + id_funcion.ToString(); ;
            var data = await ClaseSingleton.GetInstance().GetAsync(url);
            return JsonConvert.DeserializeObject<bool>(data);
        }

        private void AbstraerFuncion(Funcion f)
        {
            f.Id_pelicula = Convert.ToInt32(cboPel.SelectedValue);
            f.Id_idioma = Convert.ToInt32(Cboidioma.SelectedValue);
            f.Id_horario = Convert.ToInt32(cboHorario.SelectedValue);
            f.Id_sala = Convert.ToInt32(Cbosala.SelectedValue);
            f.monto = Convert.ToDouble(numMonto.Value);
            f.Fecha = dtpFechaFun.Value.ToShortDateString();
        }

        private bool validar()
        {
            if (cboPel.SelectedIndex == -1)
            {
                MessageBox.Show("Debe cargar La pelicula", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (cboHorario.SelectedIndex == -1)
            {
                MessageBox.Show("Debe cargar el Horario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Cboidioma.SelectedIndex == -1)
            {
                MessageBox.Show("Debe cargar el Idioma", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Cbosala.SelectedIndex == -1)
            {
                MessageBox.Show("Debe cargar la Sala", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (dtpFechaFun.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Debe cargar una fecha de hoy en adelante", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (numMonto.Value <= 0)
            {
                MessageBox.Show("Debe cargar el monto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void Cargar_DGV()
        {
            dgvFuncion.Rows.Clear();
            if (lp is null)
            {
            }
            foreach (Funcion f in lp)
            {
                try
                {
                    dgvFuncion.Rows.Add(f.id_funcion,f.Pelicula,f.Idioma,f.Sala,f.Fecha,f.Hora,"$" + f.monto);
                }
                catch (Exception)
                {
                }
            }
        }

        private void dgvFuncion_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            funSelected = new Funcion();
            funSelected.id_funcion = lp[dgvFuncion.CurrentRow.Index].id_funcion;
            funSelected.Fecha = lp[dgvFuncion.CurrentRow.Index].Fecha;
            funSelected.Pelicula = lp[dgvFuncion.CurrentRow.Index].Pelicula;
            funSelected.Id_pelicula = lp[dgvFuncion.CurrentRow.Index].Id_pelicula;
            funSelected.Id_idioma = lp[dgvFuncion.CurrentRow.Index].Id_idioma;
            funSelected.Idioma = lp[dgvFuncion.CurrentRow.Index].Idioma;
            funSelected.Id_sala = lp[dgvFuncion.CurrentRow.Index].Id_sala;
            funSelected.Sala = lp[dgvFuncion.CurrentRow.Index].Sala;
            funSelected.Id_horario = lp[dgvFuncion.CurrentRow.Index].Id_horario;
            funSelected.Hora = lp[dgvFuncion.CurrentRow.Index].Hora;
            funSelected.monto = lp[dgvFuncion.CurrentRow.Index].monto;
            funSelected.Id_TipoSala = lp[dgvFuncion.CurrentRow.Index].Id_TipoSala;




            cboPel.SelectedValue = funSelected.Id_pelicula;
            Cbosala.SelectedValue = funSelected.Id_TipoSala;
            cboHorario.SelectedValue = funSelected.Id_horario;
            Cboidioma.SelectedValue = funSelected.Id_idioma;
            dtpFechaFun.Value = Convert.ToDateTime(funSelected.Fecha);
            numMonto.Value = Convert.ToDecimal(funSelected.monto);

            pnlCrud.Visible = true;
            picLimpiar.Visible = false;
            habilitar_todo_btn(false);
            btnMod.Enabled = true;
            btnBorrar.Enabled = true;
            deshabilitar_Campos(false);





        }
    }
}
