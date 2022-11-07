using CineHoytsBack.Dominio.ClasesReportes;
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

namespace CineHoytsFront.Formularios.Reporte
{
    public partial class ReporteEspectadores : Form
    {
        public ReporteEspectadores()
        {
            InitializeComponent();
        }

        private async void ReporteEspectadores_Load(object sender, EventArgs e)
        {
            List<Espectadoresxpeli> lc = new List<Espectadoresxpeli>();
            lc = await espec(0);
            this.sPCANTIDADENTRADASMINBindingSource.DataSource = lc;
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click_1(object sender, EventArgs e)
        {
            List<Espectadoresxpeli> lc = new List<Espectadoresxpeli>();
            lc = await espec(Convert.ToInt32(numericUpDown1.Value));
            this.sPCANTIDADENTRADASMINBindingSource.DataSource = lc;
            this.reportViewer1.RefreshReport();
        }

        private async void picreset_Click(object sender, EventArgs e)
        {
            List<Espectadoresxpeli> lc = new List<Espectadoresxpeli>();
            lc = await espec(0);
            this.sPCANTIDADENTRADASMINBindingSource.DataSource = lc;
            this.reportViewer1.RefreshReport();
        }

        private async Task<List<Espectadoresxpeli>> espec(int a)
        {
            string url = "https://localhost:7271/api/Reportes/espect?a="+ a.ToString();
            var data = await ClaseSingleton.GetInstance().GetAsync(url);
            if (data == "")
            {
                return new List<Espectadoresxpeli>();
            }
            return JsonConvert.DeserializeObject<List<Espectadoresxpeli>>(data);
        }
    }
}
