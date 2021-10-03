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
    public partial class NivRandom : Form
    {
        public NivRandom()
        {
            InitializeComponent();

            //afisam data si ora
            timerDataSiOra.Start();
            Data.Text += DateTime.Now.ToLongDateString();  //ca sa scrie si cuv "data"
            Timp.Text = DateTime.Now.ToLongTimeString();  //nu merge ca la data (apare de prea multe ori), asa ca am mai facut un label cu "Ora:"
        }

        public Button[,] mat = new Button[5, 5];
        int nivfacute = 0, miscari = 0;
        private void NivRandom_Load(object sender, EventArgs e)
        {
            Random k = new Random();
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                {
                    mat[i, j] = new Button();
                    mat[i, j].Text = k.Next(2).ToString();   //.Next(2) da un numar mai mare ca 0 si mai mic ca 1 (primele 2 numere)
                    mat[i, j].Height = 30;
                    mat[i, j].Width = 30;
                    mat[i, j].Top = 0 + 30 * j;
                    mat[i, j].Left = 0 + 30 * i;
                    mat[i, j].Parent = panelrandom;
                    mat[i, j].BackColor = Color.MediumAquamarine;
                    mat[i, j].Click += new EventHandler(ButonAll_Click);
                }

            int sti, stj, fini, finj;
            sti = k.Next(4);
            stj = k.Next(4);
            fini = k.Next(4);
            finj = k.Next(4);

            if(sti == fini && stj == finj)      //sa nu se suprapuna startul cu finalul
            {
                for (int i = 0; i < 5; i++)
                    for (int j = 0; j < 5; j++)
                    {
                        mat[i, j].Dispose();  //reseteaza toate caracteristicile butoanelor
                    }

                NivRandom_Load(sender, e);  //le dam din nou caracteristici butoanelor
            }
            else
            {
                mat[stj, sti].Text = "Start";           //prima e coloana, a2a linia
                mat[finj, fini].Text = "Final";

                mat[stj, sti].BackColor = Color.Wheat;
                mat[finj, fini].BackColor = Color.Wheat;
            }           
        }

        private void ButonAll_Click(object sender, EventArgs e)
        {                
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                    mat[i, j].Visible = false;
        }

        private void TimerDataSiOra_Tick(object sender, EventArgs e)
        {
            Timp.Text = DateTime.Now.ToLongTimeString();
            timerDataSiOra.Start();
        }

        private void Panelrandom_DoubleClick(object sender, EventArgs e)
        {
            int linie = 0, coloana = 0, sem = 0;

            linie = Convert.ToInt32(label1.Text);
            coloana = Convert.ToInt32(label2.Text);

            linie /= 30;       //impartit la 30 pt. ca butoanele sunt de 30 pe 30
            coloana /= 30;

            if (mat[linie, coloana].Text == "0" || mat[linie, coloana].Text == "Start")
            {
                if (miscari == 0)
                    sem = 1;

                //conditii pt colturi si in margini
                if (linie == 0 && coloana == 0)
                {
                    if (mat[linie, coloana + 1].BackColor == Color.Red || mat[linie + 1, coloana].BackColor == Color.Red || mat[linie + 1, coloana + 1].BackColor == Color.Red)
                        sem = 1;
                }
                if (linie == 0 && coloana == 4)
                {
                    if (mat[linie, coloana - 1].BackColor == Color.Red || mat[linie + 1, coloana - 1].BackColor == Color.Red || mat[linie + 1, coloana].BackColor == Color.Red)
                        sem = 1;
                }
                if (linie == 4 && coloana == 0)
                {
                    if (mat[linie, coloana + 1].BackColor == Color.Red || mat[linie - 1, coloana].BackColor == Color.Red || mat[linie - 1, coloana + 1].BackColor == Color.Red)
                        sem = 1;
                }
                if (linie == 4 && coloana == 4)
                {
                    if (mat[linie, coloana - 1].BackColor == Color.Red || mat[linie - 1, coloana - 1].BackColor == Color.Red || mat[linie - 1, coloana].BackColor == Color.Red)
                        sem = 1;
                }

                if (linie == 0 && coloana == 0 && sem == 0)         //daca e pe colturi facem sem=2 ca sa nu mai intre in urmatoarele if-uri pt. ca da eroaarea "index out of bounds" pt. ca verifica -1 si 5
                    sem = 2;
                if (linie == 0 && coloana == 4 && sem == 0)
                    sem = 2;
                if (linie == 4 && coloana == 0 && sem == 0)
                    sem = 2;
                if (linie == 4 && coloana == 4 && sem == 0)
                    sem = 2;

                if (linie == 0 && sem == 0)
                {
                    if (mat[linie, coloana - 1].BackColor == Color.Red || mat[linie, coloana + 1].BackColor == Color.Red || mat[linie + 1, coloana - 1].BackColor == Color.Red || mat[linie + 1, coloana].BackColor == Color.Red || mat[linie + 1, coloana + 1].BackColor == Color.Red)
                        sem = 1;
                }
                if (linie == 4 && sem == 0)
                {
                    if (mat[linie, coloana - 1].BackColor == Color.Red || mat[linie, coloana + 1].BackColor == Color.Red || mat[linie - 1, coloana - 1].BackColor == Color.Red || mat[linie - 1, coloana].BackColor == Color.Red || mat[linie - 1, coloana + 1].BackColor == Color.Red)
                        sem = 1;
                }
                if (coloana == 0 && sem == 0)
                {
                    if (mat[linie, coloana + 1].BackColor == Color.Red || mat[linie + 1, coloana].BackColor == Color.Red || mat[linie + 1, coloana + 1].BackColor == Color.Red || mat[linie - 1, coloana].BackColor == Color.Red || mat[linie - 1, coloana + 1].BackColor == Color.Red)
                        sem = 1;
                }
                if (coloana == 4 && sem == 0)
                {
                    if (mat[linie, coloana - 1].BackColor == Color.Red || mat[linie - 1, coloana - 1].BackColor == Color.Red || mat[linie - 1, coloana].BackColor == Color.Red || mat[linie + 1, coloana - 1].BackColor == Color.Red || mat[linie + 1, coloana].BackColor == Color.Red)
                        sem = 1;
                }
                if (linie != 0 && linie != 4 && coloana != 0 && coloana != 4)
                {
                    if (mat[linie - 1, coloana - 1].BackColor == Color.Red || mat[linie - 1, coloana].BackColor == Color.Red || mat[linie - 1, coloana + 1].BackColor == Color.Red || mat[linie, coloana - 1].BackColor == Color.Red || mat[linie - 1, coloana + 1].BackColor == Color.Red || mat[linie + 1, coloana - 1].BackColor == Color.Red || mat[linie + 1, coloana].BackColor == Color.Red || mat[linie + 1, coloana + 1].BackColor == Color.Red)
                        sem = 1;
                }
                if (sem == 1)
                {
                    if (mat[linie, coloana].BackColor == Color.Red)
                    {
                        MessageBox.Show("Ai mai fost aici!");

                        /*for (int i = 0; i < 5; i++)
                            for (int j = 0; j < 5; j++)        //o avem la sfarsit
                                mat[i, j].Visible = true;*/
                    }
                    else
                    {
                        miscari++;

                        /*for (int i = 0; i < 5; i++)
                            for (int j = 0; j < 5; j++)
                                mat[i, j].Visible = true;*/

                        mat[linie, coloana].BackColor = Color.Red;  //asta e buna
                    }
                }
                else
                {
                    MessageBox.Show("Nu trisa!");

                    /*for (int i = 0; i < 5; i++)
                        for (int j = 0; j < 5; j++)
                            mat[i, j].Visible = true;*/
                }
            }
            if(mat[linie, coloana].Text == "1")
            {
                MessageBox.Show("Mai incearca!");

                for (int i = 0; i < 5; i++)
                    for (int j = 0; j < 5; j++)
                    {
                        mat[i, j].Dispose();  //reseteaza toate caracteristicile butoanelor
                    }

                NivRandom_Load(sender, e);  //le dam din nou caracteristici butoanelor
                miscari = 0;
            }

            if (mat[linie, coloana].Text == "Final")
            {
                //conditii pt colturi si in margini
                if (linie == 0 && coloana == 0)
                {
                    if (mat[linie, coloana + 1].BackColor == Color.Red || mat[linie + 1, coloana].BackColor == Color.Red || mat[linie + 1, coloana + 1].BackColor == Color.Red)
                        sem = 1;
                }
                if (linie == 0 && coloana == 4)
                {
                    if (mat[linie, coloana - 1].BackColor == Color.Red || mat[linie + 1, coloana - 1].BackColor == Color.Red || mat[linie + 1, coloana].BackColor == Color.Red)
                        sem = 1;
                }
                if (linie == 4 && coloana == 0)
                {
                    if (mat[linie, coloana + 1].BackColor == Color.Red || mat[linie - 1, coloana].BackColor == Color.Red || mat[linie - 1, coloana + 1].BackColor == Color.Red)
                        sem = 1;
                }
                if (linie == 4 && coloana == 4)
                {
                    if (mat[linie, coloana - 1].BackColor == Color.Red || mat[linie - 1, coloana - 1].BackColor == Color.Red || mat[linie - 1, coloana].BackColor == Color.Red)
                        sem = 1;
                }

                if (linie == 0 && coloana == 0 && sem == 0)         //daca e pe colturi facem sem=2 ca sa nu mai intre in urmatoarele if-uri pt. ca da eroaarea "index out of bounds" pt. ca verifica -1 si 5
                    sem = 2;
                if (linie == 0 && coloana == 4 && sem == 0)
                    sem = 2;
                if (linie == 4 && coloana == 0 && sem == 0)
                    sem = 2;
                if (linie == 4 && coloana == 4 && sem == 0)
                    sem = 2;

                if (linie == 0 && sem == 0)
                {
                    if (mat[linie, coloana - 1].BackColor == Color.Red || mat[linie, coloana + 1].BackColor == Color.Red || mat[linie + 1, coloana - 1].BackColor == Color.Red || mat[linie + 1, coloana].BackColor == Color.Red || mat[linie + 1, coloana + 1].BackColor == Color.Red)
                        sem = 1;
                }
                if (linie == 4 && sem == 0)
                {
                    if (mat[linie, coloana - 1].BackColor == Color.Red || mat[linie, coloana + 1].BackColor == Color.Red || mat[linie - 1, coloana - 1].BackColor == Color.Red || mat[linie - 1, coloana].BackColor == Color.Red || mat[linie - 1, coloana + 1].BackColor == Color.Red)
                        sem = 1;
                }
                if (coloana == 0 && sem == 0)
                {
                    if (mat[linie, coloana + 1].BackColor == Color.Red || mat[linie + 1, coloana].BackColor == Color.Red || mat[linie + 1, coloana + 1].BackColor == Color.Red || mat[linie - 1, coloana].BackColor == Color.Red || mat[linie - 1, coloana + 1].BackColor == Color.Red)
                        sem = 1;
                }
                if (coloana == 4 && sem == 0)
                {
                    if (mat[linie, coloana - 1].BackColor == Color.Red || mat[linie - 1, coloana - 1].BackColor == Color.Red || mat[linie - 1, coloana].BackColor == Color.Red || mat[linie + 1, coloana - 1].BackColor == Color.Red || mat[linie + 1, coloana].BackColor == Color.Red)
                        sem = 1;
                }
                if (linie != 0 && linie != 4 && coloana != 0 && coloana != 4)
                {
                    if (mat[linie - 1, coloana - 1].BackColor == Color.Red || mat[linie - 1, coloana].BackColor == Color.Red || mat[linie - 1, coloana + 1].BackColor == Color.Red || mat[linie, coloana - 1].BackColor == Color.Red || mat[linie - 1, coloana + 1].BackColor == Color.Red || mat[linie + 1, coloana - 1].BackColor == Color.Red || mat[linie + 1, coloana].BackColor == Color.Red || mat[linie + 1, coloana + 1].BackColor == Color.Red)
                        sem = 1;
                }
                if (sem == 1)
                {
                    MessageBox.Show("Bravo!");
                    miscari = 0;
                    nivfacute++;
                    labelNivFac.Text = "Niveluri făcute: ";
                    labelNivFac.Text += nivfacute.ToString();

                    for (int i = 0; i < 5; i++)
                        for (int j = 0; j < 5; j++)
                        {
                            mat[i, j].Dispose();  //reseteaza toate caracteristicile butoanelor
                        }

                    NivRandom_Load(sender, e);  //le dam din nou caracteristici butoanelor
                }
                else
                    MessageBox.Show("Nu trisa!");              
            }

            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                    mat[i, j].Visible = true;
        }

        private void Panelrandom_MouseClick(object sender, MouseEventArgs e)
        {
            //label1.Text = "X = " & e.X & " ; Y = " & e.Y;
            //label1.Text = "X = ";
            label1.Text = e.X.ToString();
            //label1.Text += " ; Y = ";
            label2.Text = e.Y.ToString();
        }
        private void ButtonReset_Click(object sender, EventArgs e)  //daca nivelul este imposibil
        {
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                {
                    mat[i, j].Dispose();  //reseteaza toate caracteristicile butoanelor
                }
            miscari = 0;
            NivRandom_Load(sender, e);  //le dam din nou caracteristici butoanelor
        }
    }
}
