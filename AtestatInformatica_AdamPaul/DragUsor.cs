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
    public partial class DragUsor : Form
    {
        Bitmap drawing;
        public DragUsor()
        {
            InitializeComponent();

            //afisam data si ora
            timerDataSiOra.Start();
            Data.Text += DateTime.Now.ToLongDateString();  //ca sa scrie si cuv "data"
            Timp.Text = DateTime.Now.ToLongTimeString();  //nu merge ca la data (apare de prea multe ori), asa ca am mai facut un label cu "Ora:"

            Bitmap drawing = new Bitmap(panelusor.Width, panelusor.Height, panelusor.CreateGraphics());
            drawing = Image.FromFile(@"E:\C#\A_AtestatInformatica_AdamPaul\back1.jpg") as Bitmap;

            //Graphics.FromImage(drawing).Clear(Color.White);  //daca voiam doar o culoare simpla, nu o imagine

            Point punctstart = label11.Location;
            Cursor.Position = PointToScreen(punctstart);
        }

        //int nrincercari = 0;   //nu facem cu nrincercari pt ca este un bug la label-uri si nu arata corect

        VariabileTimpJoc DragUsorTimpJoc = new VariabileTimpJoc();

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
            DragUsorTimpJoc.secundaIntjoc = Convert.ToInt32(secundaTura.Text);
            if (DragUsorTimpJoc.secundaIntjoc < 59)
            {
                secundaTura.Text = Convert.ToString(DragUsorTimpJoc.secundaIntjoc + 1);
            }
            else
            {
                secundaTura.Text = "0";
                DragUsorTimpJoc.minutIntjoc = Convert.ToInt32(minutTura.Text);
                if (DragUsorTimpJoc.minutIntjoc < 59)
                {
                    minutTura.Text = Convert.ToString(DragUsorTimpJoc.minutIntjoc + 1);
                }
                else
                {
                    minutTura.Text = "0";
                    DragUsorTimpJoc.oraIntjoc = Convert.ToInt32(oraTura.Text);
                    if (DragUsorTimpJoc.oraIntjoc < 23)
                    {
                        oraTura.Text = Convert.ToString(DragUsorTimpJoc.oraIntjoc + 1);
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
            if(DragUsorTimpJoc.minutIntjoc < 1 && DragUsorTimpJoc.secundaIntjoc < 3)
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
            Point punctstart = label11.Location;
            Cursor.Position = PointToScreen(punctstart);   //pentru pozitia mouse-ului

            //this.Refresh();    //daca voiam sa se stearga si linia de ajutor

            drawing = new Bitmap(panelusor.Width, panelusor.Height, panelusor.CreateGraphics());   //urmatoarea data cand dam click se resteaza liniile
            //drawing = Image.FromFile(@"E:\C#\A_AtestatInformatica_AdamPaul\back1.jpg") as Bitmap;  //daca voiam sa punem din nou background-ul pe panel,dar e acelasi background si in form deci mai bine il facem transparent

            Graphics.FromImage(drawing).Clear(Color.Transparent);  //daca voiam doar o culoare simpla, nu o imagine
        }

        private void DragUsor_MouseEnter(object sender, EventArgs e)
        {
            /* DragUsor dragusorvar = new DragUsor();
            dragusorvar.Show();                         //nu am cum sa folosesc asta pentru ca am comenzi in form, eventual sa fac panel-ul mai mare
            this.Close(); */
        }

        private void Panelusor_MouseMove(object sender, MouseEventArgs e)
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
                    panelusor.CreateGraphics().DrawImageUnscaled(drawing, new Point(0, 0));
                    break;

                case MouseButtons.Right:
                    rellipse.X = e.X;
                    rellipse.Y = e.Y;
                    rellipse.Width = 3;
                    rellipse.Height = 3;
                    panel.DrawEllipse(System.Drawing.Pens.Red, rellipse);
                    panelusor.CreateGraphics().DrawImageUnscaled(drawing, new Point(0, 0));
                    break;

                case MouseButtons.Middle:
                    rellipse.X = e.X;
                    rellipse.Y = e.Y;
                    rellipse.Width = 3;
                    rellipse.Height = 3;
                    panel.DrawEllipse(System.Drawing.Pens.Red, rellipse);
                    panelusor.CreateGraphics().DrawImageUnscaled(drawing, new Point(0, 0));
                    break;

                default:
                    return;
            }
        }

        private void TimerTimpJocUsor_Tick(object sender, EventArgs e)
        {
            DragUsorTimpJoc.secundaInt = Convert.ToInt32(secunda.Text);
            if (DragUsorTimpJoc.secundaInt < 59)
            {
                secunda.Text = Convert.ToString(DragUsorTimpJoc.secundaInt + 1);
            }
            else
            {
                secunda.Text = "0";
                DragUsorTimpJoc.minutInt = Convert.ToInt32(minut.Text);
                if (DragUsorTimpJoc.minutInt < 59)
                {
                    minut.Text = Convert.ToString(DragUsorTimpJoc.minutInt + 1);
                }
                else
                {
                    minut.Text = "0";
                    DragUsorTimpJoc.oraInt = Convert.ToInt32(ora.Text);
                    if (DragUsorTimpJoc.oraInt < 23)
                    {
                        ora.Text = Convert.ToString(DragUsorTimpJoc.oraInt + 1);
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
