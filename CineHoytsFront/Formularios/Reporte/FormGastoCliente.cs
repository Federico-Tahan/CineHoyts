using CineHoytsBack.Dominio.ClasesReportes;
using CineHoytsFront.Servicio;
using Microsoft.Reporting.WinForms;
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

namespace CineHoytsFront.Formularios.Reporte.RDLC
{
    public partial class FormGastoCliente : Form
    {
        List<GastoTotalClientes> lcliente = new List<GastoTotalClientes>();
        public FormGastoCliente()
        {
            InitializeComponent();
        }

        private async void FormGastoCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'datReport.SP_GetAvg' Puede moverla o quitarla según sea necesario.
            this.sP_GetAvgTableAdapter.Fill(this.datReport.SP_GetAvg);
            // TODO: esta línea de código carga datos en la tabla 'datReport.SP_GastoClientes' Puede moverla o quitarla según sea necesario.
            this.sP_GastoClientesTableAdapter.Fill(this.datReport.SP_GastoClientes);
            this.reportViewer1.RefreshReport();
        }

        private async Task<List<GastoTotalClientes>> GastoCliente()
        {
            string url = "https://localhost:7271/api/Reportes/GastoTotalClientes";
            var data = await ClaseSingleton.GetInstance().GetAsync(url);
            if (data == "")
            {
                return new List<GastoTotalClientes>();
            }
            return JsonConvert.DeserializeObject<List<GastoTotalClientes>>(data);
        }

        private async Task<avg> Avg()
        {
            string url = "https://localhost:7271/api/Reportes/Gasto";
            var data = await ClaseSingleton.GetInstance().GetAsync(url);
            if (data == "")
            {
                return new avg();
            }
            return JsonConvert.DeserializeObject<avg>(data);
        }



    }
}
