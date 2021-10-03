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
    public partial class MeniuNivPredef : Form
    {
        public MeniuNivPredef()
        {
            InitializeComponent();

            //afisam data si ora
            timerDataSiOra.Start();
            Data.Text += DateTime.Now.ToLongDateString();  //ca sa scrie si cuv "data"
            Timp.Text = DateTime.Now.ToLongTimeString();  //nu merge ca la data (apare de prea multe ori), asa ca am mai facut un label cu "Ora:"
        }

        private void ButInapoiPredef_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButInchidePredef_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButNiv1Predef_Click(object sender, EventArgs e)
        {
            Niv1Predef niv1Predef = new Niv1Predef();
            niv1Predef.Show();
        }

        private void ButNiv2Predef_Click(object sender, EventArgs e)
        {
            Niv2Predef niv2Predef = new Niv2Predef();
            niv2Predef.Show();
        }

        private void ButNiv3Predef_Click(object sender, EventArgs e)
        {
            Niv3Predef niv3Predef = new Niv3Predef();
            niv3Predef.Show();
        }

        private void TimerDataSiOra_Tick(object sender, EventArgs e)
        {
            Timp.Text = DateTime.Now.ToLongTimeString();
            timerDataSiOra.Start();
        }
    }
}
