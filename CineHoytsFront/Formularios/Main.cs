using Cine_Hoyts.Dominio;
using Cine_Hoyts.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cine_Hoyts.Datos;
using Cine_Project;
using CineHoytsFront.Formularios;
using CineHoytsFront.Servicio;
using Newtonsoft.Json;
using CineHoytsBack.Dominio;
using CineHoytsFront;

namespace Cine_Hoyts.Formularios
{
    public partial class Cine : Form
    {
        Form FormActual;
        int cont = 0;
        int cont2 = 0;
        int Cont_tool = 0;
        public Cine()
        {
            InitializeComponent();
            this.Size = new Size(1130, 647);
            this.tT.SetToolTip(this.Logo,"Inicio");
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            cont++;
            cont2++;
            lbhora.Text = DateTime.Now.ToLongTimeString();
            lbDate.Text = DateTime.Now.ToString("dddd MMMM  yyyy");
            if (cont2 == 350)
            {
                await Ejecutar();
                cont2 = 0;
            }
            if (cont == 600)
            {
                Picegg.Visible = true;
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private static Cine instancia;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        public static Cine obtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new Cine();
            }
            return instancia;
        }
        private void Logo_Click(object sender, EventArgs e)
        {
            LimpiarColor();
            pnlControl.Controls.Remove(FormActual);
            this.Size = new Size(1130, 634);
            subMenu1.Visible = false;
            submenu2.Visible = false;
            panel2.Visible = false;


        }
        public void cerrar()
        {
            pnlControl.Controls.Remove(FormActual);

        }
        private async void Cine_Load(object sender, EventArgs e)
        {
            lbnombre.Text = Login.v.per.Nombre + " " + Login.v.per.Apellido;
            if (Login.v.per.Sexo == 0)
            {
                picFotoHombre.Visible = false;
            }
            if(Login.v.admin == 1)
            {
                btnAdmin.Visible = true;
                Picayuda.Visible = false;

            }

            subMenu1.Visible = false;
            submenu2.Visible = false;
            panel2.Visible = false;

            await Ejecutar();



        }
        private void picCerrar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Cerrar el programa","Cerrar",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Program.Log.Close();
            }
        }

        private void btnCCliente_Click(object sender, EventArgs e)
        {
            LimpiarColor();
            btnCCliente.BackColor = Color.Red;
            AbrirFormEnPanel(new ConCliente()); hideartt();


        }

        public void AbrirFormEnPanel(Form Formhijo)
        {
            if (FormActual != null)
            {
                FormActual.Close();
            }
            FormActual = Formhijo;
            Formhijo.TopLevel = false;
            Formhijo.Dock = DockStyle.Fill;
            pnlControl.Controls.Add(Formhijo);
            pnlControl.Tag = Formhijo;
            this.Size = new Size(Formhijo.Size.Width + 256, Formhijo.Size.Height);
            Formhijo.BringToFront();
            Formhijo.Show();
        }

        private void BtnCPelicula_Click(object sender, EventArgs e)
        {
            LimpiarColor();
            BtnCPelicula.BackColor = Color.Red;
            AbrirFormEnPanel(new ConPelicula()); hideartt();

        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }

        private void lbLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea cerrar sesion", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
                Login.c = null;

                Login.obtenerInstancia().Show();
            }
        }

        private void LimpiarColor()
        {
            BtnCliente.BackColor = Color.Transparent;
            BtnFacturas.BackColor = Color.Transparent;
            btnCCliente.BackColor = Color.Transparent;
            BtnCliente.BackColor = Color.Transparent;
            BtnCFactura.BackColor = Color.Transparent;
            BtnCPelicula.BackColor = Color.Transparent;
            BtnFacutrar.BackColor = Color.Transparent;
            btnEstado.BackColor = Color.Transparent;
            btnDevelopers.BackColor = Color.Transparent;
            btnVendedor.BackColor = Color.Transparent;
            btnPeliculas.BackColor = Color.Transparent;
            btnFun.BackColor = Color.Transparent;
        }

        private void BtnFacturar_Click(object sender, EventArgs e)
        {
            LimpiarColor();

            if (subMenu1.Visible == true)
            {
                subMenu1.Visible = false;
            }
            if(panel2.Visible == true)
            {
                panel2.Visible = false;
            }
            if (submenu2.Visible == true)
            {
                submenu2.Visible = false;
            }
            else
            {
                submenu2.Visible = true;
            }
        }

        private void BtnCliente_Click(object sender, EventArgs e)
        {
            LimpiarColor();
            subMenu1.Visible = false;
            submenu2.Visible = false;
            panel2.Visible = false;
            BtnCliente.BackColor = Color.Red;
            AbrirFormEnPanel(new CrudCliente()); hideartt();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            LimpiarColor();
        }

        private void btnConsulta_Click_1(object sender, EventArgs e)
        {
            LimpiarColor();
            if (submenu2.Visible == true)
            {
                submenu2.Visible = false;
            }
            if (panel2.Visible == true)
            {
                panel2.Visible = false;
            }
            if (subMenu1.Visible == true)
            {
                subMenu1.Visible = false;
            }
            else
            {
                subMenu1.Visible = true;
            }
        }

        private void btnCCliente_Click_1(object sender, EventArgs e)
        {
            LimpiarColor();
            btnCCliente.BackColor = Color.Red;
            AbrirFormEnPanel(new ConCliente()); hideartt();

        }

        private void BtnCPelicula_Click_1(object sender, EventArgs e)
        {
            LimpiarColor();
            BtnCPelicula.BackColor = Color.Red;
            AbrirFormEnPanel(new ConPelicula()); hideartt();

        }

        private void BtnCFactura_Click_1(object sender, EventArgs e)
        {
            LimpiarColor();
            BtnCFactura.BackColor = Color.Red;
            AbrirFormEnPanel(new ConFactura()); hideartt();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            LimpiarColor();
            BtnFacutrar.BackColor = Color.Red;
            AbrirFormEnPanel(new Facturar()); hideartt();

        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            LimpiarColor();
            btnEstado.BackColor = Color.Red;
            AbrirFormEnPanel(new EstadoFactura()); hideartt();


        }

        private async Task debytea_imagen()
        {
            string url = "https://localhost:7271/api/Tablas/Imagen";
            var data = await ClaseSingleton.GetInstance().GetAsync(url);
            if (JsonConvert.DeserializeObject<byte[]>(data) is null)
            {
            }
            else
            {
                MemoryStream ms = new MemoryStream(JsonConvert.DeserializeObject<byte[]>(data));
                picPel.Image = Image.FromStream(ms);
            }
        }

        private async Task cant_entradas()
        {
            string url = "https://localhost:7271/api/Tablas/Entradas";
            var data = await ClaseSingleton.GetInstance().GetAsync(url);
            lbcant.Text = Convert.ToString(JsonConvert.DeserializeObject<int>(data));

        }

        private async Task TOTAL_VENDIDO()
        {
            string url = "https://localhost:7271/api/Tablas/Recaudado";
            var data = await ClaseSingleton.GetInstance().GetAsync(url);
            lbtotal.Text = "$ "+  Convert.ToString(JsonConvert.DeserializeObject<double>(data));


        }

        private async Task BAJAR_FUNCIONES()
        {   

            string FiltrosJson = JsonConvert.SerializeObject(new Parametro("@fecha",DateTime.Now.ToShortDateString()));
            string url = "https://localhost:7271/api/Tablas/BajarFuncion";
            await ClaseSingleton.GetInstance().PostAsync(url, FiltrosJson);

        }

        private void BtnReporte_Click(object sender, EventArgs e)
        {
            LimpiarColor();
            subMenu1.Visible = false;
            submenu2.Visible = false;
            panel2.Visible = false;
            AbrirFormEnPanel(new Report()); hideartt();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Developers()); hideartt();


        }

        private void Picegg_Click(object sender, EventArgs e)
        {
            LimpiarColor();
            subMenu1.Visible = false;
            submenu2.Visible = false;
            panel2.Visible = false;
            AbrirFormEnPanel(new Game()); hideartt();


        }

        private async Task Ejecutar()
        {
            try
            {
                await cant_entradas();
            }
            catch (Exception)
            {

            }
            try
            {
                await TOTAL_VENDIDO();

            }
            catch (Exception)
            {

            }
            try
            {
                await BAJAR_FUNCIONES();
            }
            catch (Exception)
            {

            }
            try
            {
                await debytea_imagen();
            }
            catch (Exception)
            {

            }
        }

        private void btnDevelopers_Click(object sender, EventArgs e)
        {
            LimpiarColor();
            btnDevelopers.BackColor = Color.Red;
            subMenu1.Visible = false;
            submenu2.Visible = false;
            panel2.Visible = false;
            AbrirFormEnPanel(new Developers()); hideartt();

        }

        public void visible_dev()
        {
            if(Login.v.admin == 0)
            {
                btnDevelopers.Visible = true;
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            LimpiarColor();
            subMenu1.Visible = false;
            submenu2.Visible = false;
            panel2.Visible = !panel2.Visible;
        }

        private void btnFun_Click(object sender, EventArgs e)
        {
            LimpiarColor();
            btnFun.BackColor = Color.Red;
            AbrirFormEnPanel(new CrudFuncion()); hideartt();

        }

        private void btnPeliculas_Click(object sender, EventArgs e)
        {
            LimpiarColor();
            btnPeliculas.BackColor = Color.Red;
            AbrirFormEnPanel(new CrudPelicula()); hideartt();

        }

        private void btnVendedor_Click(object sender, EventArgs e)
        {
            LimpiarColor();
            btnVendedor.BackColor = Color.Red;
            AbrirFormEnPanel(new CrudVendedor());
            hideartt();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pic_volver.Visible = !pic_volver.Visible;
            pcsig.Visible = !pcsig.Visible;
            Cont_tool = 0;
            if(pcsig.Visible == false)
            {
                subMenu1.Visible = false;
                submenu2.Visible = false;
                panel2.Visible = false;
                hideartt();
            }
        }

        private void pic_volver_Click(object sender, EventArgs e)
        {
            if (Cont_tool > 0) 
            {
                Cont_tool--;
            }
            if (Cont_tool == 0)
            {
                subMenu1.Visible = false;
                submenu2.Visible = false;
                panel2.Visible = false;
                hideartt();
            }else if (Cont_tool == 1)
            {
                subMenu1.Visible = false;
                submenu2.Visible = false;
                panel2.Visible = false;
                hideartt();
                tT.Show("Click para ir a Inicio", this.Logo, 185, 68);
            }
            else if (Cont_tool == 2)
            {
                subMenu1.Visible = false;
                submenu2.Visible = false;
                panel2.Visible = false;
                hideartt();
                tT.Show("Click para Cargar Clientes", this.BtnCliente, 185, 0);
            }
            else if (Cont_tool == 3)
            {
                subMenu1.Visible = false;
                submenu2.Visible = false;
                panel2.Visible = false;
                submenu2.Visible = true;

                hideartt();
                tT.Show("Click para Facturar", this.BtnFacutrar, 185, 0);
            }
            else if (Cont_tool == 4)
            {
                subMenu1.Visible = false;
                submenu2.Visible = false;
                panel2.Visible = false;
                submenu2.Visible = true;

                hideartt();
                tT.Show("Click para Ver los estados de las facturas", this.btnEstado, 185, -25);
            }
            else if (Cont_tool == 5)
            {
                subMenu1.Visible = false;
                submenu2.Visible = false;
                panel2.Visible = false;
                subMenu1.Visible = true;

                hideartt();
                tT.Show("Click para Consultar Clientes", this.btnCCliente, 185, -25);
            }
            else if (Cont_tool == 6)
            {
                subMenu1.Visible = false;
                submenu2.Visible = false;
                panel2.Visible = false;
                subMenu1.Visible = true;

                hideartt();
                tT.Show("Click para Consultar peliculas", this.BtnCPelicula, 185, -25);
            }
            else if (Cont_tool == 7)
            {
                subMenu1.Visible = false;
                submenu2.Visible = false;
                panel2.Visible = false;
                subMenu1.Visible = true;

                hideartt();
                tT.Show("Click para Consultar peliculas", this.BtnCFactura, 185, -25);
            }
            else if (Cont_tool == 8)
            {
                subMenu1.Visible = false;
                submenu2.Visible = false;
                panel2.Visible = false;

                hideartt();
                tT.Show("Click para Ver los reportes", this.BtnReporte, 185, -25);
            }
        }

        private void pcsig_Click(object sender, EventArgs e)
        {
            if (Cont_tool < 8)
            {
                Cont_tool++;
            }

            if (Cont_tool == 1)
            {
                tT.Show("Click para ir a Inicio", this.Logo, 185,68);
            }
            else if (Cont_tool == 2)
            {
                hideartt();
                tT.Show("Click para Cargar Clientes", this.BtnCliente, 185, 0);
            }
            else if (Cont_tool == 3)
            {
                subMenu1.Visible = false;
                submenu2.Visible = false;
                panel2.Visible = false;
                submenu2.Visible = true;

                hideartt();
                tT.Show("Click para Facturar", this.BtnFacutrar, 185, 0);
            }
            else if (Cont_tool == 4)
            {
                subMenu1.Visible = false;
                submenu2.Visible = false;
                panel2.Visible = false;
                submenu2.Visible = true;

                hideartt();
                tT.Show("Click para Ver los estados de las facturas", this.btnEstado, 185, -25);
            }
            else if (Cont_tool == 5)
            {
                subMenu1.Visible = false;
                submenu2.Visible = false;
                panel2.Visible = false;
                subMenu1.Visible = true;

                hideartt();
                tT.Show("Click para Consultar Clientes", this.btnCCliente, 185, -25);
            }
            else if (Cont_tool == 6)
            {
                subMenu1.Visible = false;
                submenu2.Visible = false;
                panel2.Visible = false;
                subMenu1.Visible = true;

                hideartt();
                tT.Show("Click para Consultar peliculas", this.BtnCPelicula, 185, -25);
            }
            else if (Cont_tool == 7)
            {
                subMenu1.Visible = false;
                submenu2.Visible = false;
                panel2.Visible = false;
                subMenu1.Visible = true;

                hideartt();
                tT.Show("Click para Consultar peliculas", this.BtnCFactura, 185, -25);
            }
            else if (Cont_tool == 8)
            {
                subMenu1.Visible = false;
                submenu2.Visible = false;
                panel2.Visible = false;

                hideartt();
                tT.Show("Click para Ver los reportes", this.BtnReporte, 185, -25);
            }
        }



        private void hideartt()
        {
            tT.Hide(this.Logo);


            tT.Hide(this.BtnCliente);
            tT.Hide(this.BtnFacutrar);

            tT.Hide(this.btnEstado);
            tT.Hide(this.btnCCliente);
            tT.Hide(this.BtnCPelicula);

            tT.Hide(this.BtnCFactura);

        }
    }
}
