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
    public partial class JoacaCuMouseDrag : Form
    {
        public JoacaCuMouseDrag()
        {
            InitializeComponent();

            //afisam data si ora
            timerDataSiOra.Start();
            Data.Text += DateTime.Now.ToLongDateString();  //ca sa scrie si cuv "data"
            Timp.Text = DateTime.Now.ToLongTimeString();  //nu merge ca la data (apare de prea multe ori), asa ca am mai facut un label cu "Ora:"
        }

        private void Butinchid1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Butusor_Click(object sender, EventArgs e)
        {
            DragUsor varusor = new DragUsor();
            varusor.Show();
        }

        private void Butmediu_Click(object sender, EventArgs e)
        {
            DragMediu varmediu = new DragMediu();
            varmediu.Show();
        }

        private void Butgreu_Click(object sender, EventArgs e)
        {
            DragGreu vargreu = new DragGreu();
            vargreu.Show();
        }

        private void Butinapoi7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TimerDataSiOra_Tick(object sender, EventArgs e)
        {
            Timp.Text = DateTime.Now.ToLongTimeString();
            timerDataSiOra.Start();
        }
    }
}
