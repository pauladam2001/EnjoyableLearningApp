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
    public partial class Cap1 : Form
    {
        public Cap1()
        {
            InitializeComponent();

            //afisam data si ora
            timerDataSiOra.Start();
            Data.Text += DateTime.Now.ToLongDateString();  //ca sa scrie si cuv "data"
            Timp.Text = DateTime.Now.ToLongTimeString();  //nu merge ca la data (apare de prea multe ori), asa ca am mai facut un label cu "Ora:"
        }

        private void Butinchidecap1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Butinapoicap1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Butquizcap1_Click(object sender, EventArgs e)
        {
            QuizCap1 varquizCap1Cap = new QuizCap1();
            varquizCap1Cap.Show();
        }

        private void TimerDataSiOra_Tick(object sender, EventArgs e)
        {
            Timp.Text = DateTime.Now.ToLongTimeString();
            timerDataSiOra.Start();
        }
    }
}
