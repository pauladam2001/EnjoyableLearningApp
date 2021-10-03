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
    public partial class QuizVerificare : Form
    {
        public QuizVerificare()
        {
            InitializeComponent();

            //afisam data si ora
            timerDataSiOra.Start();
            Data.Text += DateTime.Now.ToLongDateString();  //ca sa scrie si cuv "data"
            Timp.Text = DateTime.Now.ToLongTimeString();  //nu merge ca la data (apare de prea multe ori), asa ca am mai facut un label cu "Ora:"
        }

        private void Butinchid6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Butinapoi6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Butquizcap1_Click(object sender, EventArgs e)
        {
            QuizCap1 varquizCap1 = new QuizCap1();
            varquizCap1.Show();
        }

        private void Butquizcap2_Click(object sender, EventArgs e)
        {
            QuizCap2 varquizCap2 = new QuizCap2();
            varquizCap2.Show();
        }

        private void Butquizcap3_Click(object sender, EventArgs e)
        {
            QuizCap3 varquizCap3 = new QuizCap3();
            varquizCap3.Show();
        }

        private void TimerDataSiOra_Tick(object sender, EventArgs e)
        {
            Timp.Text = DateTime.Now.ToLongTimeString();
            timerDataSiOra.Start();
        }
    }
}
