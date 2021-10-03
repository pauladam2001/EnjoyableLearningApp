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
    public partial class QuizCap1 : Form
    {
        public QuizCap1()
        {
            InitializeComponent();

            textBoxI3.MaxLength = 10;
            textBoxI4.MaxLength = 10;

            //afisam data si ora
            timerDataSiOra.Start();
            Data.Text += DateTime.Now.ToLongDateString();  //ca sa scrie si cuv "data"
            Timp.Text = DateTime.Now.ToLongTimeString();  //nu merge ca la data (apare de prea multe ori), asa ca am mai facut un label cu "Ora:"
        }

        private void TimerDataSiOra_Tick(object sender, EventArgs e)
        {
            Timp.Text = DateTime.Now.ToLongTimeString();
            timerDataSiOra.Start();
        }

        VariabileQuiz quiz = new VariabileQuiz();

        private void Intr1Corect_Click(object sender, EventArgs e)
        {
            R2I1.BackColor = Color.Green;
            R1I1.BackColor = Color.Red;
            R3I1.BackColor = Color.Red;
            R4I1.BackColor = Color.Red;

            quiz.raspcor++;
            quiz.nrintreb++;

            string raspcorstr = Convert.ToString(quiz.raspcor);
            string nrintrebstr = Convert.ToString(quiz.nrintreb);

            MessageBox.Show("Corect!");

            labelScor.Text = raspcorstr;
            labelScor.Text += "/";
            labelScor.Text += nrintrebstr;


            Intreb1.Visible = false;
            R1I1.Visible = false;
            R2I1.Visible = false;
            R3I1.Visible = false;
            R4I1.Visible = false;

            Intreb2.Visible = true;
            R1I2.Visible = true;
            R2I2.Visible = true;
            R3I2.Visible = true;
            R4I2.Visible = true;
        }

        private void Intr1Gresit_Click(object sender, EventArgs e)
        {
            R2I1.BackColor = Color.Green;
            R1I1.BackColor = Color.Red;
            R3I1.BackColor = Color.Red;
            R4I1.BackColor = Color.Red;

            quiz.nrintreb++;

            string raspcorstr = Convert.ToString(quiz.raspcor);
            string nrintrebstr = Convert.ToString(quiz.nrintreb);

            MessageBox.Show("Gresit!");

            labelScor.Text = raspcorstr;
            labelScor.Text += "/";
            labelScor.Text += nrintrebstr;

            Intreb1.Visible = false;
            R1I1.Visible = false;
            R2I1.Visible = false;
            R3I1.Visible = false;
            R4I1.Visible = false;

            Intreb2.Visible = true;
            R1I2.Visible = true;
            R2I2.Visible = true;
            R3I2.Visible = true;
            R4I2.Visible = true;
        }

        private void Intr2Corect_Click(object sender, EventArgs e)
        {
            R2I2.BackColor = Color.Green;
            R1I2.BackColor = Color.Red;
            R3I2.BackColor = Color.Red;
            R4I2.BackColor = Color.Red;

            quiz.raspcor++;
            quiz.nrintreb++;

            string raspcorstr = Convert.ToString(quiz.raspcor);
            string nrintrebstr = Convert.ToString(quiz.nrintreb);

            MessageBox.Show("Corect!");

            labelScor.Text = raspcorstr;
            labelScor.Text += "/";
            labelScor.Text += nrintrebstr;

            Intreb2.Visible = false;
            R1I2.Visible = false;
            R2I2.Visible = false;
            R3I2.Visible = false;
            R4I2.Visible = false;

            Intreb3.Visible = true;
            textBoxI3.Visible = true;
            butTextBoxI3.Visible = true;
        }

        private void Intr2Gresit_Click(object sender, EventArgs e)
        {
            R2I2.BackColor = Color.Green;
            R1I2.BackColor = Color.Red;
            R3I2.BackColor = Color.Red;
            R4I2.BackColor = Color.Red;

            quiz.nrintreb++;

            string raspcorstr = Convert.ToString(quiz.raspcor);
            string nrintrebstr = Convert.ToString(quiz.nrintreb);

            MessageBox.Show("Gresit!");

            labelScor.Text = raspcorstr;
            labelScor.Text += "/";
            labelScor.Text += nrintrebstr;

            Intreb2.Visible = false;
            R1I2.Visible = false;
            R2I2.Visible = false;
            R3I2.Visible = false;
            R4I2.Visible = false;

            Intreb3.Visible = true;
            textBoxI3.Visible = true;
            butTextBoxI3.Visible = true;
        }

        private void ButTextBoxI3_Click(object sender, EventArgs e)
        {
            if (textBoxI3.Text != "")
            {
                string text = textBoxI3.Text.ToLower();
                quiz.nrintreb++;
                if (text == "ovulul")
                {
                    quiz.raspcor++;
                    MessageBox.Show("Corect!");
                }

                else
                    MessageBox.Show("Gresit!");

                string raspcorstr = Convert.ToString(quiz.raspcor);
                string nrintrebstr = Convert.ToString(quiz.nrintreb);

                labelScor.Text = raspcorstr;
                labelScor.Text += "/";
                labelScor.Text += nrintrebstr;

                Intreb3.Visible = false;
                textBoxI3.Visible = false;
                butTextBoxI3.Visible = false;

                Intreb4.Visible = true;
                textBoxI4.Visible = true;
                butTextBoxI4.Visible = true;
            }
            else
                MessageBox.Show("Introdu un raspuns.");
        }

        private void ButTextBoxI4_Click(object sender, EventArgs e)
        {
            if (textBoxI4.Text != "")
            {
                string text = textBoxI4.Text.ToLower();
                quiz.nrintreb++;
                if (text == "vazul")
                {
                    quiz.raspcor++;
                    MessageBox.Show("Corect!");
                }
                else
                    MessageBox.Show("Gresit!");

                string raspcorstr = Convert.ToString(quiz.raspcor);
                string nrintrebstr = Convert.ToString(quiz.nrintreb);

                labelScor.Text = raspcorstr;
                labelScor.Text += "/";
                labelScor.Text += nrintrebstr;

                Intreb4.Visible = false;
                textBoxI4.Visible = false;
                butTextBoxI4.Visible = false;

                Intreb5.Visible = true;
                R1I5.Visible = true;
                R2I5.Visible = true;
                R3I5.Visible = true;
                R4I5.Visible = true;
            }
            else
                MessageBox.Show("Introdu un raspuns.");
        }

        private void Intr5Corect_Click(object sender, EventArgs e)
        {
            R3I5.BackColor = Color.Green;
            R1I5.BackColor = Color.Red;
            R2I5.BackColor = Color.Red;
            R4I5.BackColor = Color.Red;

            quiz.raspcor++;
            quiz.nrintreb++;

            string raspcorstr = Convert.ToString(quiz.raspcor);
            string nrintrebstr = Convert.ToString(quiz.nrintreb);

            MessageBox.Show("Corect!");

            labelScor.Text = raspcorstr;
            labelScor.Text += "/";
            labelScor.Text += nrintrebstr;

            Intreb5.Visible = false;
            R1I5.Visible = false;
            R2I5.Visible = false;
            R3I5.Visible = false;
            R4I5.Visible = false;

            labelSfarsit.Text = label1.Text;
            labelSfarsit.Text += labelScor.Text;

            label1.Visible = false;
            labelScor.Visible = false;

            MessageBox.Show(labelSfarsit.Text);

            this.Close();
        }

        private void Intr5Gresit_Click(object sender, EventArgs e)
        {
            R3I5.BackColor = Color.Green;
            R1I5.BackColor = Color.Red;
            R2I5.BackColor = Color.Red;
            R4I5.BackColor = Color.Red;

            quiz.nrintreb++;

            string raspcorstr = Convert.ToString(quiz.raspcor);
            string nrintrebstr = Convert.ToString(quiz.nrintreb);

            MessageBox.Show("Gresit!");

            labelScor.Text = raspcorstr;
            labelScor.Text += "/";
            labelScor.Text += nrintrebstr;

            Intreb5.Visible = false;
            R1I5.Visible = false;
            R2I5.Visible = false;
            R3I5.Visible = false;
            R4I5.Visible = false;

            labelSfarsit.Text = label1.Text;
            labelSfarsit.Text += labelScor.Text;

            label1.Visible = false;
            labelScor.Visible = false;

            MessageBox.Show(labelSfarsit.Text);

            this.Close();
        }

        private void TextBoxI3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBoxI3.Text != "")
                {
                    string text = textBoxI3.Text.ToLower();
                    quiz.nrintreb++;
                    if (text == "ovulul")
                    {
                        quiz.raspcor++;
                        MessageBox.Show("Corect!");
                    }
                    else
                        MessageBox.Show("Gresit!");

                    string raspcorstr = Convert.ToString(quiz.raspcor);
                    string nrintrebstr = Convert.ToString(quiz.nrintreb);

                    labelScor.Text = raspcorstr;
                    labelScor.Text += "/";
                    labelScor.Text += nrintrebstr;

                    Intreb3.Visible = false;
                    textBoxI3.Visible = false;
                    butTextBoxI3.Visible = false;

                    Intreb4.Visible = true;
                    textBoxI4.Visible = true;
                    butTextBoxI4.Visible = true;
                }
                else
                    MessageBox.Show("Introdu un raspuns.");
            }
        }

        private void TextBoxI4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBoxI4.Text != "")
                {
                    string text = textBoxI4.Text.ToLower();
                    quiz.nrintreb++;
                    if (text == "vazul")
                    {
                        quiz.raspcor++;
                        MessageBox.Show("Corect!");
                    }
                    else
                        MessageBox.Show("Gresit!");

                    string raspcorstr = Convert.ToString(quiz.raspcor);
                    string nrintrebstr = Convert.ToString(quiz.nrintreb);

                    labelScor.Text = raspcorstr;
                    labelScor.Text += "/";
                    labelScor.Text += nrintrebstr;

                    Intreb4.Visible = false;
                    textBoxI4.Visible = false;
                    butTextBoxI4.Visible = false;

                    Intreb5.Visible = true;
                    R1I5.Visible = true;
                    R2I5.Visible = true;
                    R3I5.Visible = true;
                    R4I5.Visible = true;
                }
                else
                    MessageBox.Show("Introdu un raspuns.");
            }
        }
    }
}
