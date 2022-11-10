using Cine_Hoyts.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Newtonsoft.Json;
using CineHoytsFront.Servicio;

namespace Cine_Hoyts.Formularios
{
    public partial class Login : Form
    {
        Loading loading;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public static Login instancia;

        public static Vendedor v;
        public static Cine c;

        public static Cine obtenerCine()
        {
            if (c == null)
            {
                c = new Cine();
            }
            return c;
        }
        public static Login obtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new Login();
            }
            return instancia;
        }
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void pnltop_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void picCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cerrar el programa", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        public void Cerrar()
        {
            this.Close();
        }

        private bool validar()
        {
            if(txbUsuario.Text == " ")
            {
                MessageBox.Show("Debe ingresar el nombre de usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbUsuario.Focus();
                return false;
            }
            else if (txbContraseña.Text == " ")
            {
                MessageBox.Show("Debe ingresar una contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbContraseña.Focus();
                return  false;
            }
            return true;

        }

        private async void btnLogIn_Click_1(object sender, EventArgs e)
        {
            if (validar())
            {
                try
                {
                    v = new Vendedor();
                    v.Usuario = txbUsuario.Text;
                    v.Contraseña = txbContraseña.Text;
                    if (await Cargar_Loged(v))
                    {
                        v = await Cargar_Datos_Vendedor(v);
                        this.Hide();
                        mostrar();
                        Task oTask = new Task(Carga);
                        oTask.Start();
                        await oTask;
                        loading.Close();
                        await obtenerCine().Ejecutar();
                        obtenerCine().Show();
                        txbContraseña.Clear();
                        txbUsuario.Clear();

                    }
                    else
                    {
                        MessageBox.Show("Nombre de Usuario/Contraseña Incorrecto", "Error de Logeo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Demasiadas solicitudes, intentelo de nuevo mas tarde");

                }

            }
        }

        public async Task<Vendedor> Cargar_Datos_Vendedor(Vendedor pm)
        {
            string FiltrosJson = JsonConvert.SerializeObject(pm);
            string url = "https://localhost:7271/api/Login/GetDatos";
            var data = await ClaseSingleton.GetInstance().PostAsync(url, FiltrosJson);

            return JsonConvert.DeserializeObject<Vendedor>(data);
        }
        public async Task<bool> Cargar_Loged(Vendedor pm)
        {
            string FiltrosJson = JsonConvert.SerializeObject(pm);
            string url = "https://localhost:7271/api/Login/GetLoged";
            var data = await ClaseSingleton.GetInstance().PostAsync(url, FiltrosJson);

            return JsonConvert.DeserializeObject<bool>(data);
        }
        private void picBoxMostrar_Click(object sender, EventArgs e)
        {
            PicBoxOculto.BringToFront();
            txbContraseña.UseSystemPasswordChar = false;
        }

        private void PicBoxOculto_Click(object sender, EventArgs e)
        {
            picBoxMostrar.BringToFront();
            txbContraseña.UseSystemPasswordChar = true;
        }


        private void Carga()
        {
            Thread.Sleep(2000);
        }
        public void mostrar()
        {
            loading = new Loading(this.Location.X, this.Location.Y);
            loading.Show();
        }

        private void picLogo_Click(object sender, EventArgs e)
        {

        }

        public void desecharCine()
        {
            c = null;
        }
    }
}
