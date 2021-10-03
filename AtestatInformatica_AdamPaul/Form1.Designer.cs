namespace AtestatInformatica_AdamPaul
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MeniuPrincipal = new System.Windows.Forms.Label();
            this.Teorie = new System.Windows.Forms.Button();
            this.Labirint = new System.Windows.Forms.Button();
            this.butinchid4 = new System.Windows.Forms.Button();
            this.Quiz = new System.Windows.Forms.Button();
            this.timerDataSiOra = new System.Windows.Forms.Timer(this.components);
            this.Timp = new System.Windows.Forms.Label();
            this.OraText = new System.Windows.Forms.Label();
            this.Data = new System.Windows.Forms.Label();
            this.butonInfAtestat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MeniuPrincipal
            // 
            this.MeniuPrincipal.AutoSize = true;
            this.MeniuPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.MeniuPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MeniuPrincipal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MeniuPrincipal.Location = new System.Drawing.Point(265, 53);
            this.MeniuPrincipal.Name = "MeniuPrincipal";
            this.MeniuPrincipal.Size = new System.Drawing.Size(288, 46);
            this.MeniuPrincipal.TabIndex = 0;
            this.MeniuPrincipal.Text = "Meniu principal";
            // 
            // Teorie
            // 
            this.Teorie.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Teorie.BackgroundImage")));
            this.Teorie.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Teorie.Location = new System.Drawing.Point(194, 247);
            this.Teorie.Name = "Teorie";
            this.Teorie.Size = new System.Drawing.Size(75, 37);
            this.Teorie.TabIndex = 1;
            this.Teorie.Text = "Învățare";
            this.Teorie.UseVisualStyleBackColor = true;
            this.Teorie.Click += new System.EventHandler(this.Teorie_Click);
            // 
            // Labirint
            // 
            this.Labirint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Labirint.BackgroundImage")));
            this.Labirint.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Labirint.Location = new System.Drawing.Point(512, 247);
            this.Labirint.Name = "Labirint";
            this.Labirint.Size = new System.Drawing.Size(85, 37);
            this.Labirint.TabIndex = 2;
            this.Labirint.Text = "Recreație";
            this.Labirint.UseVisualStyleBackColor = true;
            this.Labirint.Click += new System.EventHandler(this.Labirint_Click);
            // 
            // butinchid4
            // 
            this.butinchid4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butinchid4.BackgroundImage")));
            this.butinchid4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.butinchid4.Location = new System.Drawing.Point(689, 399);
            this.butinchid4.Name = "butinchid4";
            this.butinchid4.Size = new System.Drawing.Size(83, 23);
            this.butinchid4.TabIndex = 8;
            this.butinchid4.Text = "Închide";
            this.butinchid4.UseVisualStyleBackColor = true;
            this.butinchid4.Click += new System.EventHandler(this.Butinchid4_Click);
            // 
            // Quiz
            // 
            this.Quiz.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Quiz.BackgroundImage")));
            this.Quiz.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Quiz.Location = new System.Drawing.Point(353, 235);
            this.Quiz.Name = "Quiz";
            this.Quiz.Size = new System.Drawing.Size(79, 60);
            this.Quiz.TabIndex = 9;
            this.Quiz.Text = "Quiz-uri de verificare";
            this.Quiz.UseVisualStyleBackColor = true;
            this.Quiz.Click += new System.EventHandler(this.Quiz_Click);
            // 
            // timerDataSiOra
            // 
            this.timerDataSiOra.Enabled = true;
            this.timerDataSiOra.Interval = 1000;
            this.timerDataSiOra.Tick += new System.EventHandler(this.TimerDataSiOra_Tick);
            // 
            // Timp
            // 
            this.Timp.AutoSize = true;
            this.Timp.BackColor = System.Drawing.Color.Transparent;
            this.Timp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Timp.Location = new System.Drawing.Point(44, 422);
            this.Timp.Name = "Timp";
            this.Timp.Size = new System.Drawing.Size(0, 17);
            this.Timp.TabIndex = 13;
            // 
            // OraText
            // 
            this.OraText.AutoSize = true;
            this.OraText.BackColor = System.Drawing.Color.Transparent;
            this.OraText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.OraText.Location = new System.Drawing.Point(12, 422);
            this.OraText.Name = "OraText";
            this.OraText.Size = new System.Drawing.Size(40, 17);
            this.OraText.TabIndex = 12;
            this.OraText.Text = "Ora: ";
            // 
            // Data
            // 
            this.Data.AutoSize = true;
            this.Data.BackColor = System.Drawing.Color.Transparent;
            this.Data.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Data.Location = new System.Drawing.Point(12, 405);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(46, 17);
            this.Data.TabIndex = 11;
            this.Data.Text = "Data: ";
            // 
            // butonInfAtestat
            // 
            this.butonInfAtestat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butonInfAtestat.BackgroundImage")));
            this.butonInfAtestat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butonInfAtestat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.butonInfAtestat.Location = new System.Drawing.Point(-1, 0);
            this.butonInfAtestat.Name = "butonInfAtestat";
            this.butonInfAtestat.Size = new System.Drawing.Size(153, 59);
            this.butonInfAtestat.TabIndex = 14;
            this.butonInfAtestat.Text = "Informații atestat";
            this.butonInfAtestat.UseVisualStyleBackColor = true;
            this.butonInfAtestat.Click += new System.EventHandler(this.ButonInfAtestat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.butonInfAtestat);
            this.Controls.Add(this.Timp);
            this.Controls.Add(this.OraText);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.Quiz);
            this.Controls.Add(this.butinchid4);
            this.Controls.Add(this.Labirint);
            this.Controls.Add(this.Teorie);
            this.Controls.Add(this.MeniuPrincipal);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MeniuSelectareMod";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MeniuPrincipal;
        private System.Windows.Forms.Button Teorie;
        private System.Windows.Forms.Button Labirint;
        private System.Windows.Forms.Button butinchid4;
        private System.Windows.Forms.Button Quiz;
        private System.Windows.Forms.Timer timerDataSiOra;
        private System.Windows.Forms.Label Timp;
        private System.Windows.Forms.Label OraText;
        private System.Windows.Forms.Label Data;
        private System.Windows.Forms.Button butonInfAtestat;
    }
}

