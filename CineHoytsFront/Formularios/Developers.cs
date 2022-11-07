using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineHoytsFront.Formularios
{
    public partial class Developers : Form
    {
        public Developers()
        {
            InitializeComponent();
        }
        private void Developers_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            pnlDescMatiu.Visible = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            pnlDescFede.Visible = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            pnlDescAgus.Visible = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            pnlDescLuis.Visible = true;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            pnlDescMatia.Visible = true;
        }

        private void btnReport4_Click(object sender, EventArgs e)
        {
            pnlDescMatiu.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlDescFede.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnlDescAgus.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pnlDescLuis.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pnlDescMatia.Visible = false;
        }

        private void picGmailMateo_Click(object sender, EventArgs e)
        {
            Process.Start("mailto:mateoscns@gmail.com");
        }

        private void PicLinkMateo_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.linkedin.com/in/leandro-mateo-scienza-697235226/");

        }

        private void PicGitMateo_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/LeanMateoScNs");
        }

        private void PicLinkedinFede_Click(object sender, EventArgs e)
        {
            Process.Start("www.linkedin.com/in/federico-tahan");

        }

        private void PicGitHubFede_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/MrFedet?tab=repositories");

        }

        private void PicGmailFede_Click_1(object sender, EventArgs e)
        {
            Process.Start("mailto:fedetahan8@gmail.com");

        }

        private void PicGmailAgus_Click(object sender, EventArgs e)
        {
            Process.Start("mailto:fedetahan8@gmail.com");

        }

        private void PicLinkedinAgus_Click(object sender, EventArgs e)
        {
            Process.Start("www.linkedin.com/in/federico-tahan");

        }

        private void PicGithubAgus_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/MrFedet?tab=repositories");

        }

        private void PicGmailLuis_Click(object sender, EventArgs e)
        {
            Process.Start("mailto:fedetahan8@gmail.com");

        }

        private void PicLinkedinLuis_Click(object sender, EventArgs e)
        {
            Process.Start("www.linkedin.com/in/federico-tahan");

        }

        private void PicGithubLuis_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/MrFedet?tab=repositories");

        }

        private void PicGmailMatias_Click(object sender, EventArgs e)
        {
            Process.Start("mailto:fedetahan8@gmail.com");

        }

        private void PicLinkedinMatias_Click(object sender, EventArgs e)
        {
            Process.Start("www.linkedin.com/in/federico-tahan");

        }

        private void PicGithubMatias_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/MrFedet?tab=repositories");

        }
    }
}
