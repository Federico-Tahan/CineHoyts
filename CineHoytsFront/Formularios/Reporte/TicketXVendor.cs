using Cine_Hoyts.Datos;
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
    public partial class TicketXVendor : Form
    {
        public TicketXVendor()
        {
            InitializeComponent();
        }

        private async void TicketXVendor_Load(object sender, EventArgs e)
        {
            List<TicketXVendedor> gt = new List<TicketXVendedor>();
            gt = await CargarTicketxvendedor();
            this.sPTICKETSxVENDEDORBindingSource.DataSource = gt;
            this.reportViewer1.RefreshReport();
        }

        private async Task<List<TicketXVendedor>> CargarTicketxvendedor()
        {
            string url = "https://localhost:7271/api/Reportes/VentaXTicket";
            var data = await ClaseSingleton.GetInstance().GetAsync(url);
            if (data == "")
            {
                return new List<TicketXVendedor>();
            }
            return JsonConvert.DeserializeObject<List<TicketXVendedor>>(data);
        }

    }
}
