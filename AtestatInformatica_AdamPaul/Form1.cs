using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;  //acesta il folosim ca sa se deschida meniul principal

namespace AtestatInformatica_AdamPaul
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Thread t = new Thread(new ThreadStart(startMeniuPrinc));  //"thread" e folosita pentru a putea deschide meniul principal
            t.Start();
            Thread.Sleep(5000);

            InitializeComponent();

            t.Abort();

            //afisam data si ora
            timerDataSiOra.Start();
            Data.Text += DateTime.Now.ToLongDateString();  //ca sa scrie si cuv "data"
            Timp.Text = DateTime.Now.ToLongTimeString();  //nu merge ca la data (apare de prea multe ori), asa ca am mai facut un label cu "Ora:"
        }

        public void startMeniuPrinc()
        {
            Application.Run(new MeniuPrincipal());
        }

        private void Teorie_Click(object sender, EventArgs e)
        {
            Teorie varTeorie = new Teorie();
            varTeorie.Show();
        }

        private void Labirint_Click(object sender, EventArgs e)
        {
            MeniuLabirint varMeniuLabirint = new MeniuLabirint();
            varMeniuLabirint.Show();
        }

        private void Butinchid4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Quiz_Click(object sender, EventArgs e)
        {
            QuizVerificare varQuizFerif = new QuizVerificare();
            varQuizFerif.Show();
        }

        private void TimerDataSiOra_Tick(object sender, EventArgs e)
        {
            Timp.Text = DateTime.Now.ToLongTimeString();
            timerDataSiOra.Start();
        }

        private void ButonInfAtestat_Click(object sender, EventArgs e)
        {
            InformatiiAtestat varInformatiiAtestat = new InformatiiAtestat();
            varInformatiiAtestat.Show();
        }
    }
}
