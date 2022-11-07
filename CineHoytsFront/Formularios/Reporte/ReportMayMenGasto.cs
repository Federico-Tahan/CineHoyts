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
    public partial class ReportMayMenGasto : Form
    {
        public ReportMayMenGasto()
        {
            InitializeComponent();
        }

        private async void ReportMayMenGasto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'datReport.SP_MAYOR_MENOR_GASTO' Puede moverla o quitarla según sea necesario.
            List<MayMenGasto> lmay = new List<MayMenGasto>();
            lmay = await maymenGasto();
            this.sPMAYORMENORGASTOBindingSource.DataSource = lmay;

            this.reportViewer1.RefreshReport();
        }
        private async Task<List<MayMenGasto>> maymenGasto()
        {
            string url = "https://localhost:7271/api/Reportes/MayMen";
            var data = await ClaseSingleton.GetInstance().GetAsync(url);
            if (data == "")
            {
                return new List<MayMenGasto>();
            }
            return JsonConvert.DeserializeObject<List<MayMenGasto>>(data);
        }
    }
}
