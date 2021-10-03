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
    public partial class Niv2Predef : Form
    {
        public Niv2Predef()
        {
            InitializeComponent();

            //afisam data si ora
            timerDataSiOra.Start();
            Data.Text += DateTime.Now.ToLongDateString();  //ca sa scrie si cuv "data"
            Timp.Text = DateTime.Now.ToLongTimeString();  //nu merge ca la data (apare de prea multe ori), asa ca am mai facut un label cu "Ora:"
        }

        public Button[,] mat = new Button[8, 8];
        int miscari = 0;

        private void Niv2Predef_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                {
                    mat[i, j] = new Button();
                    mat[i, j].Height = 30;
                    mat[i, j].Width = 30;
                    mat[i, j].Top = 0 + 30 * j;
                    mat[i, j].Left = 0 + 30 * i;
                    mat[i, j].Parent = panelNiv2;
                    mat[i, j].BackColor = Color.OrangeRed;
                }
            mat[0, 0].Text = "0";
            mat[0, 1].Text = "1";
            mat[0, 2].Text = "0";
            mat[0, 3].Text = "1";
            mat[0, 4].Text = "0";
            mat[0, 5].Text = "0";
            mat[0, 6].Text = "1";
            mat[0, 7].Text = "0";
            mat[1, 0].Text = "0";
            mat[1, 1].Text = "0";
            mat[1, 2].Text = "1";
            mat[1, 3].Text = "0";
            mat[1, 4].Text = "1";
            mat[1, 5].Text = "1";
            mat[1, 6].Text = "0";
            mat[1, 7].Text = "0";
            mat[2, 0].Text = "1";                    //primul indice e coloana, al doilea linia
            mat[2, 1].Text = "0";
            mat[2, 2].Text = "0";
            mat[2, 3].Text = "1";
            mat[2, 4].Text = "1";
            mat[2, 5].Text = "Final";
            mat[2, 6].Text = "1";
            mat[2, 7].Text = "1";
            mat[3, 0].Text = "0";
            mat[3, 1].Text = "1";
            mat[3, 2].Text = "1";
            mat[3, 3].Text = "1";
            mat[3, 4].Text = "0";
            mat[3, 5].Text = "1";
            mat[3, 6].Text = "1";
            mat[3, 7].Text = "1";
            mat[4, 0].Text = "1";
            mat[4, 1].Text = "0";
            mat[4, 2].Text = "0";
            mat[4, 3].Text = "1";
            mat[4, 4].Text = "1";
            mat[4, 5].Text = "0";
            mat[4, 6].Text = "1";
            mat[4, 7].Text = "0";
            mat[5, 0].Text = "0";
            mat[5, 1].Text = "1";
            mat[5, 2].Text = "1";
            mat[5, 3].Text = "1";
            mat[5, 4].Text = "0";
            mat[5, 5].Text = "0";
            mat[5, 6].Text = "1";
            mat[5, 7].Text = "0";
            mat[6, 0].Text = "Start";
            mat[6, 1].Text = "0";
            mat[6, 2].Text = "1";
            mat[6, 3].Text = "0";
            mat[6, 4].Text = "0";
            mat[6, 5].Text = "0";
            mat[6, 6].Text = "0";
            mat[6, 7].Text = "1";
            mat[7, 0].Text = "0";
            mat[7, 1].Text = "1";
            mat[7, 2].Text = "0";
            mat[7, 3].Text = "1";
            mat[7, 4].Text = "1";
            mat[7, 5].Text = "1";
            mat[7, 6].Text = "0";
            mat[7, 7].Text = "1";

            mat[2, 5].BackColor = Color.LimeGreen;
            mat[6, 0].BackColor = Color.LimeGreen;

            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                {
                    //mat[i, j].MouseMove += new MouseEventHandler(ButonPoz_MouseMove);
                    if (mat[i, j].Text == "0")
                        mat[i, j].Click += new EventHandler(Buton0_Click);
                    if (mat[i, j].Text == "1")
                        mat[i, j].Click += new EventHandler(Buton1_Click);
                }

            mat[6, 0].Click += new EventHandler(Buton0_Click);//butonul "Start" face acelasi lucru ca si cum am apasa "0"
            mat[2,5].Click += new EventHandler(ButonFinal_Click);  //cand putem apasa butonul "Final"
        }

        /* private void ButonPoz_MouseMove(object sender, MouseEventArgs e)  //coordonatele nu sunt cele din panel, fiecare buton are coordonate proprii
        {
            //label1.Text = "X = " & e.X & " ; Y = " & e.Y;
            //label1.Text = "X = ";
            label1.Text = e.X.ToString();
            //label2.Text = "Y = ";
            label2.Text = e.Y.ToString();
        }*/

        private void ButonFinal_Click(object sender, EventArgs e)
        {
            if (miscari == 7)
            {
                MessageBox.Show("Bravo, ai terminat nivelul din numarul minim de miscari!");
                this.Close();
                miscari = 0; //?trebe?
            }
            else
            {
                MessageBox.Show("Incearca sa termini din numarul de miscari afisat pe ecran, fara sa trisezi!");
                miscari = 0;

                for (int i = 0; i < 8; i++)
                    for (int j = 0; j < 8; j++)
                    {
                        mat[i, j].Dispose();  //reseteaza toate caracteristicile butoanelor
                    }
                Niv2Predef_Load(sender, e);
            }
        }

        private void Buton0_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                    mat[i, j].Visible = false;

            /*//this.Cursor = new Cursor(Cursor.Current.Handle);  //e neaparat????
            //int posX = Cursor.Position.X;
            //int posY = Cursor.Position.Y;

            //int linie = 0, coloana = 0;
            //linie = posX / 30;    //ar fi fost posX / 30 + 1 daca i si j incepeau de la 1, dar incep de la 0
            //coloana = posY / 30;   //SAU posX aici si posY la linie??? tot nu merge

            //linie = Cursor.Position.X;
            //coloana = Cursor.Position.Y;

            //linie = MousePosition.Y;                 // LINIA E Y
            //coloana = MousePosition.X;


            //linie = Convert.ToInt32(label1.Text);
            //coloana = Convert.ToInt32(label2.Text);

            //linie = Int32.Parse(label1.Text);
            //coloana = Int32.Parse(label2.Text);

            //int x=0, y=0;
            //linie = Int32.TryParse(label1.Text, out x);     //asta e bool
            //coloana = Int32.TryParse(label2.Text, out y);

            //linie /= 30;
            //coloana /= 30;

            //mat[coloana, linie].BackColor = Color.Red;

            //for (int i = 0; i < 5; i++)
            //for (int j = 0; j < 5; j++)
            //mat[i, j].Visible = true;

            //mat[coloana, linie].BackColor = Color.Red; 
            //mat[linie, coloana].BackColor = Color.Red;*/
        }

        private void Buton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mai incearca!");

            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                {
                    mat[i, j].Dispose();  //reseteaza toate caracteristicile butoanelor
                }

            miscari = 0;
            Niv2Predef_Load(sender, e);  //le dam din nou caracteristici butoanelor
        }

        private void TimerDataSiOra_Tick(object sender, EventArgs e)
        {
            Timp.Text = DateTime.Now.ToLongTimeString();
            timerDataSiOra.Start();
        }

        private void PanelNiv2_MouseClick(object sender, MouseEventArgs e)
        {
            //label1.Text = "X = " & e.X & " ; Y = " & e.Y;
            //label1.Text = "X = ";
            label1.Text = e.X.ToString();
            //label1.Text += " ; Y = ";
            label2.Text = e.Y.ToString();
        }

        private void PanelNiv2_DoubleClick(object sender, EventArgs e)
        {
            int linie = 0, coloana = 0, sem = 0;

            linie = Convert.ToInt32(label1.Text);
            coloana = Convert.ToInt32(label2.Text);

            linie /= 30;       //impartit la 30 pt. ca butoanele sunt de 30 pe 30
            coloana /= 30;

            if (miscari == 0)
                sem = 1;

            //conditii pt colturi si in margini
            if (linie == 0 && coloana == 0)
            {
                if (mat[linie, coloana + 1].BackColor == Color.Yellow || mat[linie + 1, coloana].BackColor == Color.Yellow || mat[linie + 1, coloana + 1].BackColor == Color.Yellow)
                    sem = 1;
            }
            if (linie == 0 && coloana == 7)
            {
                if (mat[linie, coloana - 1].BackColor == Color.Yellow || mat[linie + 1, coloana - 1].BackColor == Color.Yellow || mat[linie + 1, coloana].BackColor == Color.Yellow)
                    sem = 1;
            }
            if (linie == 7 && coloana == 0)
            {
                if (mat[linie, coloana + 1].BackColor == Color.Yellow || mat[linie - 1, coloana].BackColor == Color.Yellow || mat[linie - 1, coloana + 1].BackColor == Color.Yellow)
                    sem = 1;
            }
            if (linie == 7 && coloana == 7)
            {
                if (mat[linie, coloana - 1].BackColor == Color.Yellow || mat[linie - 1, coloana - 1].BackColor == Color.Yellow || mat[linie - 1, coloana].BackColor == Color.Yellow)
                    sem = 1;
            }

            if (linie == 0 && coloana == 0 && sem == 0)         //daca e pe colturi facem sem=2 ca sa nu mai intre in urmatoarele if-uri pt. ca da eroaarea "index out of bounds" pt. ca verifica -1 si 8
                sem = 2;
            if (linie == 0 && coloana == 7 && sem == 0)
                sem = 2;
            if (linie == 7 && coloana == 0 && sem == 0)
                sem = 2;
            if (linie == 7 && coloana == 7 && sem == 0)
                sem = 2;

            if (linie == 0 && sem == 0)
            {
                if (mat[linie, coloana - 1].BackColor == Color.Yellow || mat[linie, coloana + 1].BackColor == Color.Yellow || mat[linie + 1, coloana - 1].BackColor == Color.Yellow || mat[linie + 1, coloana].BackColor == Color.Yellow || mat[linie + 1, coloana + 1].BackColor == Color.Yellow)
                    sem = 1;
            }
            if (linie == 7 && sem == 0)
            {
                if (mat[linie, coloana - 1].BackColor == Color.Yellow || mat[linie, coloana + 1].BackColor == Color.Yellow || mat[linie - 1, coloana - 1].BackColor == Color.Yellow || mat[linie - 1, coloana].BackColor == Color.Yellow || mat[linie - 1, coloana + 1].BackColor == Color.Yellow)
                    sem = 1;
            }
            if (coloana == 0 && sem == 0)
            {
                if (mat[linie, coloana + 1].BackColor == Color.Yellow || mat[linie + 1, coloana].BackColor == Color.Yellow || mat[linie + 1, coloana + 1].BackColor == Color.Yellow || mat[linie - 1, coloana].BackColor == Color.Yellow || mat[linie - 1, coloana + 1].BackColor == Color.Yellow)
                    sem = 1;
            }
            if (coloana == 7 && sem == 0)
            {
                if (mat[linie, coloana - 1].BackColor == Color.Yellow || mat[linie - 1, coloana - 1].BackColor == Color.Yellow || mat[linie - 1, coloana].BackColor == Color.Yellow || mat[linie + 1, coloana - 1].BackColor == Color.Yellow || mat[linie + 1, coloana].BackColor == Color.Yellow)
                    sem = 1;
            }
            if (linie != 0 && linie != 7 && coloana != 0 && coloana != 7)
            {
                if (mat[linie - 1, coloana - 1].BackColor == Color.Yellow || mat[linie - 1, coloana].BackColor == Color.Yellow || mat[linie - 1, coloana + 1].BackColor == Color.Yellow || mat[linie, coloana - 1].BackColor == Color.Yellow || mat[linie - 1, coloana + 1].BackColor == Color.Yellow || mat[linie + 1, coloana - 1].BackColor == Color.Yellow || mat[linie + 1, coloana].BackColor == Color.Yellow || mat[linie + 1, coloana + 1].BackColor == Color.Yellow)
                    sem = 1;
            }
            if (sem == 1)
            {
                if (mat[linie, coloana].BackColor == Color.Yellow)
                {
                    MessageBox.Show("Ai mai fost aici!");

                    for (int i = 0; i < 8; i++)
                        for (int j = 0; j < 8; j++)
                            mat[i, j].Visible = true;
                }
                else
                {
                    miscari++;

                    for (int i = 0; i < 8; i++)
                        for (int j = 0; j < 8; j++)
                            mat[i, j].Visible = true;

                    mat[linie, coloana].BackColor = Color.Yellow;  //asta e buna
                }
            }
            else
            {
                MessageBox.Show("Nu trisa!");

                for (int i = 0; i < 8; i++)
                    for (int j = 0; j < 8; j++)
                        mat[i, j].Visible = true;
            }
        }

        /*private void PanelNiv2_MouseMove(object sender, MouseEventArgs e) //am pus-o in comentariu si in designer
        {
            //label1.Text = "X = " & e.X & " ; Y = " & e.Y;
            //label1.Text = "X = ";
            label1.Text = e.X.ToString();
            //label1.Text += " ; Y = ";
            label2.Text = e.Y.ToString();
        }*/
    }
}
