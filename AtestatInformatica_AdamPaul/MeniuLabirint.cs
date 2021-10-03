﻿using System;
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
    public partial class MeniuLabirint : Form
    {
        public MeniuLabirint()
        {
            InitializeComponent();

            //afisam data si ora
            timerDataSiOra.Start();
            Data.Text += DateTime.Now.ToLongDateString();  //ca sa scrie si cuv "data"
            Timp.Text = DateTime.Now.ToLongTimeString();  //nu merge ca la data (apare de prea multe ori), asa ca am mai facut un label cu "Ora:"
        }

        private void CuMouse_Click(object sender, EventArgs e)
        {
            JoacaCuMouse varCuMouse = new JoacaCuMouse();
            varCuMouse.Show();
        }

        private void CuTastatura_Click(object sender, EventArgs e)
        {
            JoacaCuMouseDrag varCuMouseDrag = new JoacaCuMouseDrag();
            varCuMouseDrag.Show();
        }

        private void Butinchid3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Butinapoi3_Click(object sender, EventArgs e)
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
