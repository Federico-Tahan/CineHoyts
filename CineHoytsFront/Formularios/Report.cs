using CineHoytsFront.Formularios.Reporte;
using CineHoytsFront.Formularios.Reporte.RDLC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cine_Hoyts.Formularios
{
    public partial class Report : Form
    {
        Form form;
        public void AbrirFormEnPanel(Form Formhijo)
        {
            if (form != null)
            {
                form.Close();
            }
            form = Formhijo;
            Formhijo.TopLevel = false;
            Formhijo.Dock = DockStyle.Fill;
            panelReport.Controls.Add(Formhijo);
            panelReport.Tag = Formhijo;
            this.Size = new Size(Formhijo.Size.Width + 256, Formhijo.Size.Height);
            Formhijo.BringToFront();
            Formhijo.Show();
        }

        public Report()
        {
            InitializeComponent();
        }

        private void btnReport2_Click(object sender, EventArgs e)
        {
            panelReport.Visible = true;
            AbrirFormEnPanel(new ReportMayMenGasto());
        }

        private void btnReport1_Click(object sender, EventArgs e)
        {
            panelReport.Visible = true;
            AbrirFormEnPanel(new FormGastoCliente());

        }

        private void btnReport3_Click(object sender, EventArgs e)
        {
            panelReport.Visible = true;
            AbrirFormEnPanel(new GastoTotalClientes());

        }

        private void btnReport8_Click(object sender, EventArgs e)
        {
            panelReport.Visible = true;
            AbrirFormEnPanel(new RecaudacionxPromo());


        }

        private void btnReport7_Click(object sender, EventArgs e)
        {
            panelReport.Visible = true;

            AbrirFormEnPanel(new ReportGananciaXPelicula());

        }

        private void btnReport6_Click(object sender, EventArgs e)
        {
            panelReport.Visible = true;

            AbrirFormEnPanel(new RecauPorProductora());
        }

        private void btnReport5_Click(object sender, EventArgs e)
        {
            panelReport.Visible = true;

            AbrirFormEnPanel(new ReporteEspectadores());
        }

        private void Report_Load(object sender, EventArgs e)
        {
        }

        private void btnReport4_Click(object sender, EventArgs e)
        {
            panelReport.Visible = true;
            AbrirFormEnPanel(new TicketXVendor());

        }
    }
}
