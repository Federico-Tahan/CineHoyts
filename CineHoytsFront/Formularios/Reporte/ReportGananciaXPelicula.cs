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
    public partial class ReportGananciaXPelicula : Form
    {
        public ReportGananciaXPelicula()
        {
            InitializeComponent();
        }

        private async void ReportGananciaXPelicula_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'datReport.SP_GananciasXPelicula' Puede moverla o quitarla según sea necesario.
            List<GananciaXPel> gp = new List<GananciaXPel>();
            gp = await gananciaxpeli();
            this.sPGananciasXPeliculaBindingSource.DataSource = gp;
            this.reportViewer1.RefreshReport();
        }

        private async Task<List<GananciaXPel>> gananciaxpeli()
        {
            string url = "https://localhost:7271/api/Reportes/gananciaxpeli";
            var data = await ClaseSingleton.GetInstance().GetAsync(url);
            if (data == "")
            {
                return new List<GananciaXPel>();
            }
            return JsonConvert.DeserializeObject<List<GananciaXPel>>(data);
        }
    }
}
