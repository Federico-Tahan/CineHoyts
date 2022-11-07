using CineHoytsBack.Dominio;
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
    public partial class GastoTotalClientes : Form
    {
        public GastoTotalClientes()
        {
            InitializeComponent();
        }

        private async void GastoTotalClientes_Load(object sender, EventArgs e)
        {

            List<Parametro> lp = new List<Parametro>();
            List<GastoClienteTot> a = new List<GastoClienteTot>();

            lp.Add(new Parametro("","01/01/2001"));
            lp.Add(new Parametro("", "01/01/2100"));
            lp.Add(new Parametro("", "z"));

            a = await Posta(lp);
            //// TODO: This line of code loads data into the 'datReport.SP_GastoTotalDeClientes1' table. You can move, or remove it, as needed.
            this.sPGastoTotalDeClientesBindingSource.DataSource = a;
            this.reportViewer1.RefreshReport();
            comboBox1.SelectedIndex = 0;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value > dateTimePicker2.Value)
            {
                MessageBox.Show("La fecha de inicio debe ser menor a la de fin");
            }
            else
            {
                List<Parametro> lp = new List<Parametro>();
                List<GastoClienteTot> a = new List<GastoClienteTot>();

                lp.Add(new Parametro("", dateTimePicker1.Value.ToShortDateString()));
                lp.Add(new Parametro("", dateTimePicker2.Value.ToShortDateString()));
                lp.Add(new Parametro("", comboBox1.Text));

                a = await Posta(lp);
                //// TODO: This line of code loads data into the 'datReport.SP_GastoTotalDeClientes1' table. You can move, or remove it, as needed.
                this.sPGastoTotalDeClientesBindingSource.DataSource = a;
                this.reportViewer1.RefreshReport();
            }
        }

        private async void picreset_Click(object sender, EventArgs e)
        {
            List<Parametro> lp = new List<Parametro>();
            List<GastoClienteTot> a = new List<GastoClienteTot>();
            lp.Add(new Parametro("", "01/01/2001"));
            lp.Add(new Parametro("", "01/01/2100"));
            lp.Add(new Parametro("", "Z"));

            a = await Posta(lp);
            //// TODO: This line of code loads data into the 'datReport.SP_GastoTotalDeClientes1' table. You can move, or remove it, as needed.
            this.sPGastoTotalDeClientesBindingSource.DataSource = a;
            this.reportViewer1.RefreshReport();
            comboBox1.SelectedIndex = 0;
        }

        private async Task<List<GastoClienteTot>> Posta(List<Parametro> pm)
        {
            string url = "https://localhost:7271/api/Reportes/Postclienterecau";
            string FiltrosJson = JsonConvert.SerializeObject(pm);
            var data = await ClaseSingleton.GetInstance().PostAsync(url, FiltrosJson);
            return JsonConvert.DeserializeObject<List<GastoClienteTot>>(data);

        }
    }
}
