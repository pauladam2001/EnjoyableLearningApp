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
    public partial class QuizCap2 : Form
    {
        public QuizCap2()
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

        private void Intr1Corect_Click(object sender, EventArgs e)
        {
            R1I1.BackColor = Color.Green;
            R2I1.BackColor = Color.Red;
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
            R1I1.BackColor = Color.Green;
            R2I1.BackColor = Color.Red;
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
            R4I2.BackColor = Color.Green;
            R1I2.BackColor = Color.Red;
            R2I2.BackColor = Color.Red;
            R3I2.BackColor = Color.Red;

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
            R4I2.BackColor = Color.Green;
            R1I2.BackColor = Color.Red;
            R2I2.BackColor = Color.Red;
            R3I2.BackColor = Color.Red;

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
                if (text == "jupiter")
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
                R1I4.Visible = true;
                R2I4.Visible = true;
                R3I4.Visible = true;
                R4I4.Visible = true;
            }
            else
                MessageBox.Show("Introdu un raspuns.");
        }

        private void Intr4Corect_Click(object sender, EventArgs e)
        {
            R2I4.BackColor = Color.Green;
            R1I4.BackColor = Color.Red;
            R3I4.BackColor = Color.Red;
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
            textBoxI5.Visible = true;
            butTextBoxI5.Visible = true;
        }

        private void Intr4Gresit_Click(object sender, EventArgs e)
        {
            R2I4.BackColor = Color.Green;
            R1I4.BackColor = Color.Red;
            R3I4.BackColor = Color.Red;
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
            textBoxI5.Visible = true;
            butTextBoxI5.Visible = true;
        }

        private void ButTextBoxI5_Click(object sender, EventArgs e)
        {
            if (textBoxI5.Text != "")
            {
                string text = textBoxI5.Text.ToLower();
                quiz.nrintreb++;
                if (text == "pluto")
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

                Intreb5.Visible = false;
                textBoxI5.Visible = false;
                butTextBoxI5.Visible = false;

                labelSfarsit.Text = label1.Text;
                labelSfarsit.Text += labelScor.Text;

                label1.Visible = false;
                labelScor.Visible = false;

                MessageBox.Show(labelSfarsit.Text);

                this.Close();
            }
            else
                MessageBox.Show("Introdu un raspuns.");
        }

        private void TextBoxI3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBoxI3.Text != "")
                {
                    string text = textBoxI3.Text.ToLower();
                    quiz.nrintreb++;
                    if (text == "jupiter")
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
                    R1I4.Visible = true;
                    R2I4.Visible = true;
                    R3I4.Visible = true;
                    R4I4.Visible = true;
                }
                else
                    MessageBox.Show("Introdu un raspuns.");
            }
        }

        private void TextBoxI5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBoxI5.Text != "")
                {
                    string text = textBoxI5.Text.ToLower();
                    quiz.nrintreb++;
                    if (text == "pluto")
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

                    Intreb5.Visible = false;
                    textBoxI5.Visible = false;
                    butTextBoxI5.Visible = false;

                    labelSfarsit.Text = label1.Text;
                    labelSfarsit.Text += labelScor.Text;

                    label1.Visible = false;
                    labelScor.Visible = false;

                    MessageBox.Show(labelSfarsit.Text);

                    this.Close();
                }
                else
                    MessageBox.Show("Introdu un raspuns.");
            }
        }
    }
}
