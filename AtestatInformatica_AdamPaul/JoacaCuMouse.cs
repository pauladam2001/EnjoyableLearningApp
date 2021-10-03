using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtestatInformatica_AdamPaul
{
    public partial class JoacaCuMouse : Form
    {
        public JoacaCuMouse()
        {
            InitializeComponent();

            //afisam data si ora
            timerDataSiOra.Start();
            Data.Text += DateTime.Now.ToLongDateString();  //ca sa scrie si cuv "data"
            Timp.Text = DateTime.Now.ToLongTimeString();  //nu merge ca la data (apare de prea multe ori), asa ca am mai facut un label cu "Ora:"
        }

        private void Butinchid2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Butinapoi2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButCuNivelMouse_Click(object sender, EventArgs e)
        {
            MeniuNivPredef meniuNivPredef = new MeniuNivPredef();
            meniuNivPredef.Show();
        }

        private void ButRandomMouse_Click(object sender, EventArgs e)
        {
            NivRandom nivRandom = new NivRandom();
            nivRandom.Show();
        }

        private void TimerDataSiOra_Tick(object sender, EventArgs e)
        {
            Timp.Text = DateTime.Now.ToLongTimeString();
            timerDataSiOra.Start();
        }
    }
}
