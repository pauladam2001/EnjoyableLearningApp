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
    public partial class QuizCap3 : Form
    {
        public QuizCap3()
        {
            InitializeComponent();

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

        private void ButTextBoxI1_Click(object sender, EventArgs e)
        {
            if (textBoxI1.Text != "")
            {
                string text = textBoxI1.Text.ToLower();
                quiz.nrintreb++;
                if (text == "elefantul")
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

                Intreb1.Visible = false;
                textBoxI1.Visible = false;
                butTextBoxI1.Visible = false;

                Intreb2.Visible = true;
                textBoxI2.Visible = true;
                butTextBoxI2.Visible = true;
            }
            else
                MessageBox.Show("Introdu un raspuns.");
        }

        private void TextBoxI1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBoxI1.Text != "")
                {
                    string text = textBoxI1.Text.ToLower();
                    quiz.nrintreb++;
                    if (text == "elefantul")
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

                    Intreb1.Visible = false;
                    textBoxI1.Visible = false;
                    butTextBoxI1.Visible = false;

                    Intreb2.Visible = true;
                    textBoxI2.Visible = true;
                    butTextBoxI2.Visible = true;
                }
                else
                    MessageBox.Show("Introdu un raspuns.");
            }
        }

        private void ButTextBoxI2_Click(object sender, EventArgs e)
        {
            if (textBoxI2.Text != "")
            {
                string text = textBoxI2.Text.ToLower();
                quiz.nrintreb++;
                if (text == "liliacul")
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

                Intreb2.Visible = false;
                textBoxI2.Visible = false;
                butTextBoxI2.Visible = false;

                Intreb3.Visible = true;
                R1I3.Visible = true;
                R2I3.Visible = true;
                R3I3.Visible = true;
                R4I3.Visible = true;
            }
            else
                MessageBox.Show("Introdu un raspuns.");
        }

        private void TextBoxI2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBoxI2.Text != "")
                {
                    string text = textBoxI2.Text.ToLower();
                    quiz.nrintreb++;
                    if (text == "liliacul")
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

                    Intreb2.Visible = false;
                    textBoxI2.Visible = false;
                    butTextBoxI2.Visible = false;

                    Intreb3.Visible = true;
                    R1I3.Visible = true;
                    R2I3.Visible = true;
                    R3I3.Visible = true;
                    R4I3.Visible = true;
                }
                else
                    MessageBox.Show("Introdu un raspuns.");
            }
        }

        private void Intr3Corect_Click(object sender, EventArgs e)
        {
            R1I3.BackColor = Color.Green;
            R2I3.BackColor = Color.Red;
            R3I3.BackColor = Color.Red;
            R4I3.BackColor = Color.Red;

            quiz.raspcor++;
            quiz.nrintreb++;

            string raspcorstr = Convert.ToString(quiz.raspcor);
            string nrintrebstr = Convert.ToString(quiz.nrintreb);

            MessageBox.Show("Corect!");

            labelScor.Text = raspcorstr;
            labelScor.Text += "/";
            labelScor.Text += nrintrebstr;

            Intreb3.Visible = false;
            R1I3.Visible = false;
            R2I3.Visible = false;
            R3I3.Visible = false;
            R4I3.Visible = false;

            Intreb4.Visible = true;
            R1I4.Visible = true;
            R2I4.Visible = true;
            R3I4.Visible = true;
            R4I4.Visible = true;
        }

        private void Intr3Gresit_Click(object sender, EventArgs e)
        {
            R1I3.BackColor = Color.Green;
            R2I3.BackColor = Color.Red;
            R3I3.BackColor = Color.Red;
            R4I3.BackColor = Color.Red;

            quiz.nrintreb++;

            string raspcorstr = Convert.ToString(quiz.raspcor);
            string nrintrebstr = Convert.ToString(quiz.nrintreb);

            MessageBox.Show("Gresit!");

            labelScor.Text = raspcorstr;
            labelScor.Text += "/";
            labelScor.Text += nrintrebstr;

            Intreb3.Visible = false;
            R1I3.Visible = false;
            R2I3.Visible = false;
            R3I3.Visible = false;
            R4I3.Visible = false;

            Intreb4.Visible = true;
            R1I4.Visible = true;
            R2I4.Visible = true;
            R3I4.Visible = true;
            R4I4.Visible = true;
        }

        private void Intr4Corect_Click(object sender, EventArgs e)
        {
            R3I4.BackColor = Color.Green;
            R1I4.BackColor = Color.Red;
            R2I4.BackColor = Color.Red;
            R4I4.BackColor = Color.Red;

            quiz.raspcor++;
            quiz.nrintreb++;

            string raspcorstr = Convert.ToString(quiz.raspcor);
            string nrintrebstr = Convert.ToString(quiz.nrintreb);

            MessageBox.Show("Corect!");

            labelScor.Text = raspcorstr;
            labelScor.Text += "/";
            labelScor.Text += nrintrebstr;

            Intreb4.Visible = false;
            R1I4.Visible = false;
            R2I4.Visible = false;
            R3I4.Visible = false;
            R4I4.Visible = false;

            Intreb5.Visible = true;
            R1I5.Visible = true;
            R2I5.Visible = true;
            R3I5.Visible = true;
            R4I5.Visible = true;
        }

        private void Intr4Gresit_Click(object sender, EventArgs e)
        {
            R3I4.BackColor = Color.Green;
            R1I4.BackColor = Color.Red;
            R2I4.BackColor = Color.Red;
            R4I4.BackColor = Color.Red;

            quiz.nrintreb++;

            string raspcorstr = Convert.ToString(quiz.raspcor);
            string nrintrebstr = Convert.ToString(quiz.nrintreb);

            MessageBox.Show("Gresit!");

            labelScor.Text = raspcorstr;
            labelScor.Text += "/";
            labelScor.Text += nrintrebstr;

            Intreb4.Visible = false;
            R1I4.Visible = false;
            R2I4.Visible = false;
            R3I4.Visible = false;
            R4I4.Visible = false;

            Intreb5.Visible = true;
            R1I5.Visible = true;
            R2I5.Visible = true;
            R3I5.Visible = true;
            R4I5.Visible = true;
        }

        private void Intr5Corect_Click(object sender, EventArgs e)
        {
            R2I5.BackColor = Color.Green;
            R1I5.BackColor = Color.Red;
            R3I5.BackColor = Color.Red;
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
            R2I5.BackColor = Color.Green;
            R1I5.BackColor = Color.Red;
            R3I5.BackColor = Color.Red;
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
    }
}
