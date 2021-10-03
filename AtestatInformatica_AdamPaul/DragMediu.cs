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
    public partial class DragMediu : Form
    {
        Bitmap drawing;
        public DragMediu()
        {
            InitializeComponent();

            //afisam data si ora
            timerDataSiOra.Start();
            Data.Text += DateTime.Now.ToLongDateString();  //ca sa scrie si cuv "data"
            Timp.Text = DateTime.Now.ToLongTimeString();  //nu merge ca la data (apare de prea multe ori), asa ca am mai facut un label cu "Ora:"

            Bitmap drawing = new Bitmap(panelmediu.Width, panelmediu.Height, panelmediu.CreateGraphics());
            //drawing = Image.FromFile(@"E:\C#\A_AtestatInformatica_AdamPaul\back1.jpg") as Bitmap;

            Graphics.FromImage(drawing).Clear(Color.Transparent);  //daca voiam doar o culoare simpla, nu o imagine

            Point punctstart = label16.Location;
            Cursor.Position = PointToScreen(punctstart);
        }

        //int nrincercari = 0;   //nu facem cu nrincercari pt ca este un bug la label-uri si nu arata corect

        VariabileTimpJoc DragMediuTimpJoc = new VariabileTimpJoc();

        int sem = 1;

        private void TimerTimpJocEfectiv_Tick(object sender, EventArgs e)
        {
            if (sem == 0)
            {
                secundaTura.Text = "00";
                minutTura.Text = "00";
                oraTura.Text = "00";
            }
            sem = 1;
            DragMediuTimpJoc.secundaIntjoc = Convert.ToInt32(secundaTura.Text);
            if (DragMediuTimpJoc.secundaIntjoc < 59)
            {
                secundaTura.Text = Convert.ToString(DragMediuTimpJoc.secundaIntjoc + 1);
            }
            else
            {
                secundaTura.Text = "0";
                DragMediuTimpJoc.minutIntjoc = Convert.ToInt32(minutTura.Text);
                if (DragMediuTimpJoc.minutIntjoc < 59)
                {
                    minutTura.Text = Convert.ToString(DragMediuTimpJoc.minutIntjoc + 1);
                }
                else
                {
                    minutTura.Text = "0";
                    DragMediuTimpJoc.oraIntjoc = Convert.ToInt32(oraTura.Text);
                    if (DragMediuTimpJoc.oraIntjoc < 23)
                    {
                        oraTura.Text = Convert.ToString(DragMediuTimpJoc.oraIntjoc + 1);
                    }
                    else
                    {
                        oraTura.Text = "0";
                    }
                }
            }
        }

        private void Final_MouseEnter(object sender, EventArgs e)
        {
            if (DragMediuTimpJoc.minutIntjoc < 1 && DragMediuTimpJoc.secundaIntjoc < 8)
                MessageBox.Show("Bravo, ai terminat nivelul intr-un timp mai bun ca al creatorului!");
            else
                MessageBox.Show("Bravo, incearca sa fii mai rapid!");
            //MessageBox.Show("Bravo! Ai terminat nivelul din " + nrincercari.ToString() + " incercari");
            this.Close();
        }

        private void Start_MouseEnter(object sender, EventArgs e)
        {
            //nrincercari++;
            sem = 0;
            Point punctstart = label16.Location;
            Cursor.Position = PointToScreen(punctstart);   //pentru pozitia mouse-ului

            //this.Refresh();    //daca voiam sa se stearga si linia de ajutor

            drawing = new Bitmap(panelmediu.Width, panelmediu.Height, panelmediu.CreateGraphics());   //urmatoarea data cand dam click se resteaza liniile
            //drawing = Image.FromFile(@"E:\C#\A_AtestatInformatica_AdamPaul\back1.jpg") as Bitmap;  //daca voiam sa punem din nou background-ul pe panel,dar e acelasi background si in form deci mai bine il facem transparent

            Graphics.FromImage(drawing).Clear(Color.Transparent);  //daca vrem doar o culoare simpla, nu o imagine
        }

        private void DragMediu_MouseEnter(object sender, EventArgs e)
        {
           /* DragMediu dragmediuvar = new DragMediu();
            dragmediuvar.Show();                                 //nu am cum sa folosesc asta pentru ca am comenzi in form, eventual sa fac panel-ul mai mare
            this.Close(); */
        }

        private void Panelmediu_MouseMove(object sender, MouseEventArgs e)
        {
            Rectangle rellipse = new Rectangle();
            Graphics panel = Graphics.FromImage(drawing);
            switch (e.Button)
            {
                case MouseButtons.Left:
                    rellipse.X = e.X;
                    rellipse.Y = e.Y;
                    rellipse.Width = 3;
                    rellipse.Height = 3;
                    panel.DrawEllipse(System.Drawing.Pens.Red, rellipse);
                    panelmediu.CreateGraphics().DrawImageUnscaled(drawing, new Point(0, 0));
                    break;

                case MouseButtons.Right:
                    rellipse.X = e.X;
                    rellipse.Y = e.Y;
                    rellipse.Width = 3;
                    rellipse.Height = 3;
                    panel.DrawEllipse(System.Drawing.Pens.Red, rellipse);
                    panelmediu.CreateGraphics().DrawImageUnscaled(drawing, new Point(0, 0));
                    break;

                case MouseButtons.Middle:
                    rellipse.X = e.X;
                    rellipse.Y = e.Y;
                    rellipse.Width = 3;
                    rellipse.Height = 3;
                    panel.DrawEllipse(System.Drawing.Pens.Red, rellipse);
                    panelmediu.CreateGraphics().DrawImageUnscaled(drawing, new Point(0, 0));
                    break;

                default:
                    return;
            }
        }

        private void TimerTimpJocGreu_Tick(object sender, EventArgs e)
        {
            DragMediuTimpJoc.secundaInt = Convert.ToInt32(secunda.Text);
            if (DragMediuTimpJoc.secundaInt < 59)
            {
                secunda.Text = Convert.ToString(DragMediuTimpJoc.secundaInt + 1);
            }
            else
            {
                secunda.Text = "0";
                DragMediuTimpJoc.minutInt = Convert.ToInt32(minut.Text);
                if (DragMediuTimpJoc.minutInt < 59)
                {
                    minut.Text = Convert.ToString(DragMediuTimpJoc.minutInt + 1);
                }
                else
                {
                    minut.Text = "0";
                    DragMediuTimpJoc.oraInt = Convert.ToInt32(ora.Text);
                    if (DragMediuTimpJoc.oraInt < 23)
                    {
                        ora.Text = Convert.ToString(DragMediuTimpJoc.oraInt + 1);
                    }
                    else
                    {
                        ora.Text = "0";
                    }
                }
            }
        }

        private void TimerDataSiOra_Tick(object sender, EventArgs e)
        {
            Timp.Text = DateTime.Now.ToLongTimeString();
            timerDataSiOra.Start();
        }
    }
}
