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
    public partial class Loading : Form
    {
        int loc = 0;
        int loc1 = 0;
        public Loading(int loc, int loc1)
        {
            InitializeComponent();
            this.loc = loc;
            this.loc1 = loc1;
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            this.Location= new Point(loc, loc1);
            Pbcargando.Location = new Point(this.Width/2-Pbcargando.Width/2
                , this.Height / 2 - Pbcargando.Height / 2);
        }

        private void Pbcargando_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
