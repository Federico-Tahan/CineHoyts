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
    public partial class RecauPorProductora : Form
    {
        public RecauPorProductora()
        {
            InitializeComponent();
        }

        private async void RecauPorProductora_Load(object sender, EventArgs e)
        {
            List<RecauPorProductora> lp = new List<RecauPorProductora>();
            lp = await espec();
            this.sPRecaudacionPorFechasBindingSource.DataSource = lp;
            this.reportViewer1.RefreshReport();
        }

        private async Task<List<RecauPorProductora>> espec()
        {
            string url = "https://localhost:7271/api/Reportes/rec";
            var data = await ClaseSingleton.GetInstance().GetAsync(url);
            if (data == "")
            {
                return new List<RecauPorProductora>();
            }
            return JsonConvert.DeserializeObject<List<RecauPorProductora>>(data);
        }
    }
}
