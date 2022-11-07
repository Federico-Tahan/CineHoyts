using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineHoytsFront.Formularios.Reporte
{
    public partial class RecaudacionxPromo : Form
    {
        public RecaudacionxPromo()
        {
            InitializeComponent();
        }

        private void RecaudacionxPromo_Load(object sender, EventArgs e)
        {
            this.sP_RECAUDACIONxPROMOTableAdapter.Fill(this.datReport.SP_RECAUDACIONxPROMO,0);
            this.reportViewer1.RefreshReport();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.sP_RECAUDACIONxPROMOTableAdapter.Fill(this.datReport.SP_RECAUDACIONxPROMO, numericUpDown1.Value);
            this.reportViewer1.RefreshReport();
        }

        private void picreset_Click(object sender, EventArgs e)
        {
            this.sP_RECAUDACIONxPROMOTableAdapter.Fill(this.datReport.SP_RECAUDACIONxPROMO, 0);
            this.reportViewer1.RefreshReport();
        }
    }
}
