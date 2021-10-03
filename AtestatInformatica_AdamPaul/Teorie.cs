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
    public partial class Teorie : Form
    {
        public Teorie()
        {
            InitializeComponent();

            //afisam data si ora
            timerDataSiOra.Start();
            Data.Text += DateTime.Now.ToLongDateString();  //ca sa scrie si cuv "data"
            Timp.Text = DateTime.Now.ToLongTimeString();  //nu merge ca la data (apare de prea multe ori), asa ca am mai facut un label cu "Ora:"
        }

        private void Butinchid5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Butinapoi5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButCap1_Click(object sender, EventArgs e)
        {
            Cap1 varcap1 = new Cap1();
            varcap1.Show();
        }

        private void ButCap2_Click(object sender, EventArgs e)
        {
            Cap2 varcap2 = new Cap2();
            varcap2.Show();
        }

        private void ButCap3_Click(object sender, EventArgs e)
        {
            Cap3 varcap3 = new Cap3();
            varcap3.Show();
        }

        private void TimerDataSiOra_Tick(object sender, EventArgs e)
        {
            Timp.Text = DateTime.Now.ToLongTimeString();
            timerDataSiOra.Start();
        }
    }
}
