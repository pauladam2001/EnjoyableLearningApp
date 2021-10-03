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
    public partial class DragGreu : Form
    {
        Bitmap drawing;
        public DragGreu()
        {
            InitializeComponent();

            //afisam data si ora
            timerDataSiOra.Start();
            Data.Text += DateTime.Now.ToLongDateString();  //ca sa scrie si cuv "data"
            Timp.Text = DateTime.Now.ToLongTimeString();  //nu merge ca la data (apare de prea multe ori), asa ca am mai facut un label cu "Ora:"

            drawing = new Bitmap(panelgreu.Width, panelgreu.Height, panelgreu.CreateGraphics());
            //drawing = Image.FromFile(@"E:\C#\A_AtestatInformatica_AdamPaul\back1.jpg") as Bitmap;

            Graphics.FromImage(drawing).Clear(Color.Transparent);  //daca voiam doar o culoare simpla, nu o imagine

            Point punctstart = label10.Location;
            Cursor.Position = PointToScreen(punctstart);
        }

        //int nrincercari = 0;   //nu facem cu nrincercari pt ca este un bug la label-uri si nu arata corect

        VariabileTimpJoc DragGreuTimpJoc = new VariabileTimpJoc();

        int sem = 1;

        private void Final_MouseEnter(object sender, EventArgs e)
        {
            if (DragGreuTimpJoc.minutIntjoc < 2 && DragGreuTimpJoc.secundaIntjoc < 30)
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
            Point punctstart = label10.Location;
            Cursor.Position = PointToScreen(punctstart);   //pentru pozitia mouse-ului

            //this.Refresh();    //daca voiam sa se stearga si linia de ajutor

            drawing = new Bitmap(panelgreu.Width, panelgreu.Height, panelgreu.CreateGraphics());   //urmatoarea data cand dam click se resteaza liniile
            //drawing = Image.FromFile(@"E:\C#\A_AtestatInformatica_AdamPaul\back1.jpg") as Bitmap;  //daca voiam sa punem din nou background-ul pe panel,dar e acelasi background si in form deci mai bine il facem transparent

            Graphics.FromImage(drawing).Clear(Color.Transparent);  //daca vrem doar o culoare simpla, nu o imagine
        }

        private void DragGreu_MouseEnter(object sender, EventArgs e)
        {
            /* DragGreu draggreuvar = new DragGreu();
             draggreuvar.Show();                         //nu am cum sa folosesc asta pentru ca am comenzi in form, eventual sa fac panel-ul mai mare
             this.Close(); */
        }

        private void Panelgreu_MouseMove(object sender, MouseEventArgs e)
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
                    panelgreu.CreateGraphics().DrawImageUnscaled(drawing, new Point(0, 0));
                    break;

                case MouseButtons.Right:
                    rellipse.X = e.X;
                    rellipse.Y = e.Y;
                    rellipse.Width = 3;
                    rellipse.Height = 3;
                    panel.DrawEllipse(System.Drawing.Pens.Red, rellipse);
                    panelgreu.CreateGraphics().DrawImageUnscaled(drawing, new Point(0, 0));
                    break;

                case MouseButtons.Middle:
                    rellipse.X = e.X;
                    rellipse.Y = e.Y;
                    rellipse.Width = 3;
                    rellipse.Height = 3;
                    panel.DrawEllipse(System.Drawing.Pens.Red, rellipse);
                    panelgreu.CreateGraphics().DrawImageUnscaled(drawing, new Point(0, 0));
                    break;

                default:
                    return;
            }
        }

        private void TimerTimpJocEfectiv_Tick(object sender, EventArgs e)
        {
            if(sem == 0)
            {
                secundaTura.Text = "00";
                minutTura.Text = "00";
                oraTura.Text = "00";
            }
            sem = 1;
            DragGreuTimpJoc.secundaIntjoc = Convert.ToInt32(secundaTura.Text);
            if (DragGreuTimpJoc.secundaIntjoc < 59)
            {
                secundaTura.Text = Convert.ToString(DragGreuTimpJoc.secundaIntjoc + 1);
            }
            else
            {
                secundaTura.Text = "0";
                DragGreuTimpJoc.minutIntjoc = Convert.ToInt32(minutTura.Text);
                if (DragGreuTimpJoc.minutIntjoc < 59)
                {
                    minutTura.Text = Convert.ToString(DragGreuTimpJoc.minutIntjoc + 1);
                }
                else
                {
                    minutTura.Text = "0";
                    DragGreuTimpJoc.oraIntjoc = Convert.ToInt32(oraTura.Text);
                    if (DragGreuTimpJoc.oraIntjoc < 23)
                    {
                        oraTura.Text = Convert.ToString(DragGreuTimpJoc.oraIntjoc + 1);
                    }
                    else
                    {
                        oraTura.Text = "0";
                    }
                }
            }
        }

        private void TimerTimpJocGreu_Tick(object sender, EventArgs e)
        {
            DragGreuTimpJoc.secundaInt = Convert.ToInt32(secunda.Text);
            if (DragGreuTimpJoc.secundaInt < 59)
            {
                secunda.Text = Convert.ToString(DragGreuTimpJoc.secundaInt + 1);
            }
            else
            {
                secunda.Text = "0";
                DragGreuTimpJoc.minutInt = Convert.ToInt32(minut.Text);
                if (DragGreuTimpJoc.minutInt < 59)
                {
                    minut.Text = Convert.ToString(DragGreuTimpJoc.minutInt + 1);
                }
                else
                {
                    minut.Text = "0";
                    DragGreuTimpJoc.oraInt = Convert.ToInt32(ora.Text);
                    if (DragGreuTimpJoc.oraInt < 23)
                    {
                        ora.Text = Convert.ToString(DragGreuTimpJoc.oraInt + 1);
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
