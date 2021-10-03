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
    public partial class MeniuPrincipal : Form
    {
        public MeniuPrincipal()
        {
            InitializeComponent();
        }

        private void TimerLoadScreen_Tick(object sender, EventArgs e)
        {
            progressBarLoadScreen.Increment(1);
            if(progressBarLoadScreen.Value == 99)  //se blocheaza putin ca sa para ca se face 100% si se deschide aplicatia
            {
                TimerLoadScreen.Stop();
            }
        }
    }
}
