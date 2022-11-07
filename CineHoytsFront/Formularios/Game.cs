using CineHoytsFront.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CineHoytsFront.Formularios;
using Cine_Hoyts.Formularios;

namespace CineHoytsFront
{
    public partial class Game : Form
    {
        int cont = 0;
        int objetivo = 0;
        public Game()
        {
            InitializeComponent();
        }




        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cambiar_sarten(int a)
        {
            vaciar();
            if (a == 1)
            {
                pic1.Image = Resources.sartenconpururu;
                pic1.Tag = "si";
            }
            else if (a == 2)
            {
                pic2.Image = Resources.sartenconpururu;
                pic2.Tag = "si";

            }
            else if (a == 3)
            {
                pic3.Image = Resources.sartenconpururu;
                pic3.Tag = "si";

            }
            else if (a == 4)
            {
                pic4.Image = Resources.sartenconpururu;
                pic4.Tag = "si";

            }
            else if (a == 5)
            {
                pic5.Image = Resources.sartenconpururu;
                pic5.Tag = "si";

            }
            else if (a == 6)
            {
                pic6.Image = Resources.sartenconpururu;
                pic6.Tag = "si";

            }
            else if (a == 7)
            {
                pic7.Image = Resources.sartenconpururu;
                pic7.Tag = "si";

            }
            else if (a == 8)
            {
                pic8.Image = Resources.sartenconpururu;
                pic8.Tag = "si";

            }
            else if (a == 9)
            {
                pic9.Image = Resources.sartenconpururu;
                pic9.Tag = "si";

            }
            else if (a == 10)
            {
                pic10.Image = Resources.sartenconpururu;
                pic10.Tag = "si";

            }
            else if (a == 11)
            {
                pic11.Image = Resources.sartenconpururu;
                pic11.Tag = "si";

            }
            else if (a == 12)
            {
                pic12.Image = Resources.sartenconpururu;
                pic12.Tag = "si";

            }
            else if (a == 13)
            {
                pic13.Image = Resources.sartenconpururu;
                pic13.Tag = "si";

            }
            else if (a == 14)
            {
                pic14.Image = Resources.sartenconpururu;
                pic14.Tag = "si";

            }
            else if (a == 15)
            {
                pic15.Image = Resources.sartenconpururu;
                pic15.Tag = "si";

            }
            else if (a == 16)
            {
                pic16.Image = Resources.sartenconpururu;
                pic16.Tag = "si";

            }
            else if (a == 17)
            {
                pic17.Image = Resources.sartenconpururu;
                pic17.Tag = "si";

            }
            else if (a == 18)
            {
                pic18.Image = Resources.sartenconpururu;
                pic18.Tag = "si";

            }
            else if (a == 19)
            {
                pic19.Image = Resources.sartenconpururu;
                pic19.Tag = "si";

            }
            else if (a == 20)
            {
                pic20.Image = Resources.sartenconpururu;
                pic20.Tag = "si";

            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            cont++;

            if (cont == 6)
            {
                Random rnd = new Random();
                rnd.Next(1, 20);
                cambiar_sarten(rnd.Next(1, 20));
                cont = 0;
            }
            pocholo();
            if (objetivo == 7)
            {
                timer2.Enabled = false;
                vaciar();
                MessageBox.Show("Felicidades, Ganaste ahora podras ver a los Developers del programa");
                Login.obtenerCine().visible_dev();
                
            }

        }

        private void pic1_Click(object sender, EventArgs e)
        {
            if (pic1.Tag.ToString() == "si")
            {
                objetivo += 1;
                lbconseguido.Text = objetivo.ToString();
            }

        }

        private void vaciar()
        {

            pic1.Image = Resources.sarten__2_1;
            pic1.Tag = "no";


            pic2.Image = Resources.sarten__2_1;
            pic2.Tag = "no";


            pic3.Image = Resources.sarten__2_1;
            pic3.Tag = "no";

            pic4.Image = Resources.sarten__2_1;
            pic4.Tag = "no";


            pic5.Image = Resources.sarten__2_1;
            pic5.Tag = "no";


            pic6.Image = Resources.sarten__2_1;
                    pic6.Tag = "no";


            pic7.Image = Resources.sarten__2_1;
                    pic7.Tag = "no";


            pic8.Image = Resources.sarten__2_1;
                    pic8.Tag = "no";

            pic9.Image = Resources.sarten__2_1;
                    pic9.Tag = "no";


            pic10.Image = Resources.sarten__2_1;
                    pic10.Tag = "no";


            pic11.Image = Resources.sarten__2_1;
                    pic11.Tag = "no";


            pic12.Image = Resources.sarten__2_1;
                    pic12.Tag = "no";


            pic13.Image = Resources.sarten__2_1;
                    pic13.Tag = "no";


            pic14.Image = Resources.sarten__2_1;
                    pic14.Tag = "no";


            pic15.Image = Resources.sarten__2_1;
                    pic15.Tag = "no";


            pic16.Image = Resources.sarten__2_1;
                    pic16.Tag = "no";


            pic17.Image = Resources.sarten__2_1;
                    pic17.Tag = "no";


            pic18.Image = Resources.sarten__2_1;
                    pic18.Tag = "no";


            pic19.Image = Resources.sarten__2_1;
                    pic19.Tag = "no";


            pic20.Image = Resources.sarten__2_1;
                    pic20.Tag = "no";

        }

        private void pic2_Click(object sender, EventArgs e)
        {
            if (pic2.Tag.ToString() == "si")
            {
                objetivo += 1;
                lbconseguido.Text = objetivo.ToString();
            }
        }

        private void pic3_Click(object sender, EventArgs e)
        {
            if (pic3.Tag.ToString() == "si")
            {
                objetivo += 1;
                lbconseguido.Text = objetivo.ToString();
            }
        }

        private void pic4_Click(object sender, EventArgs e)
        {
            if (pic4.Tag.ToString() == "si")
            {
                objetivo += 1;
                lbconseguido.Text = objetivo.ToString();
            }
        }

        private void pic5_Click(object sender, EventArgs e)
        {
            if (pic5.Tag.ToString() == "si")
            {
                objetivo += 1;
                lbconseguido.Text = objetivo.ToString();
            }
        }

        private void pic6_Click(object sender, EventArgs e)
        {
            if (pic6.Tag.ToString() == "si")
            {
                objetivo += 1;
                lbconseguido.Text = objetivo.ToString();
            }
        }

        private void pic7_Click(object sender, EventArgs e)
        {
            if (pic7.Tag.ToString() == "si")
            {
                objetivo += 1;
                lbconseguido.Text = objetivo.ToString();
            }
        }

        private void pic8_Click(object sender, EventArgs e)
        {
            if (pic8.Tag.ToString() == "si")
            {
                objetivo += 1;
                lbconseguido.Text = objetivo.ToString();
            }
        }

        private void pic9_Click(object sender, EventArgs e)
        {
            if (pic9.Tag.ToString() == "si")
            {
                objetivo += 1;
                lbconseguido.Text = objetivo.ToString();
            }
        }

        private void pic10_Click(object sender, EventArgs e)
        {
            if (pic10.Tag.ToString() == "si")
            {
                objetivo += 1;
                lbconseguido.Text = objetivo.ToString();
            }
        }

        private void pic11_Click(object sender, EventArgs e)
        {
            if (pic11.Tag.ToString() == "si")
            {
                objetivo += 1;
                lbconseguido.Text = objetivo.ToString();
            }
        }

        private void pic12_Click(object sender, EventArgs e)
        {
            if (pic12.Tag.ToString() == "si")
            {
                objetivo += 1;
                lbconseguido.Text = objetivo.ToString();
            }
        }

        private void pic13_Click(object sender, EventArgs e)
        {
            if (pic13.Tag.ToString() == "si")
            {
                objetivo += 1;
                lbconseguido.Text = objetivo.ToString();
            }
        }

        private void pic14_Click(object sender, EventArgs e)
        {
            if (pic4.Tag.ToString() == "si")
            {
                objetivo += 1;
                lbconseguido.Text = objetivo.ToString();
            }
        }

        private void pic15_Click(object sender, EventArgs e)
        {
            if (pic15.Tag.ToString() == "si")
            {
                objetivo += 1;
                lbconseguido.Text = objetivo.ToString();
            }
        }

        private void pic16_Click(object sender, EventArgs e)
        {
            if (pic16.Tag.ToString() == "si")
            {
                objetivo += 1;
                lbconseguido.Text = objetivo.ToString();
            }
        }

        private void pic17_Click(object sender, EventArgs e)
        {
            if (pic17.Tag.ToString() == "si")
            {
                objetivo += 1;
                lbconseguido.Text = objetivo.ToString();
            }
        }

        private void pic18_Click(object sender, EventArgs e)
        {
            if (pic18.Tag.ToString() == "si")
            {
                objetivo += 1;
                lbconseguido.Text = objetivo.ToString();
            }
        }

        private void pic19_Click(object sender, EventArgs e)
        {
            if (pic19.Tag.ToString() == "si")
            {
                objetivo += 1;
                lbconseguido.Text = objetivo.ToString();
            }
        }

        private void pic20_Click(object sender, EventArgs e)
        {
            if (pic20.Tag.ToString() == "si")
            {
                objetivo += 1;
                lbconseguido.Text = objetivo.ToString();
            }
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            objetivo = 0;
            cont = 0;
            picpocholo.Image = Resources.pocholovacio;
            lbconseguido.Text = "0";
            timer2.Enabled = true;
        }


        private void pocholo()
        {
            if (objetivo >= 1 && objetivo <=2)
            {
                picpocholo.Image = Resources.pocholo2;
            }else if (objetivo >= 3 && objetivo <= 6)
            {
                picpocholo.Image = Resources.pocholo3;

            }
            else if (objetivo == 7)
            {
                picpocholo.Image = Resources.pocholowin;

            }
        }
    }
}
