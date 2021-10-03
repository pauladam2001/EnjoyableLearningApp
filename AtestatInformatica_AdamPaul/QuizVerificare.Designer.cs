namespace AtestatInformatica_AdamPaul
{
    partial class QuizVerificare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuizVerificare));
            this.butinapoi6 = new System.Windows.Forms.Button();
            this.butinchid6 = new System.Windows.Forms.Button();
            this.butquizcap1 = new System.Windows.Forms.Button();
            this.butquizcap2 = new System.Windows.Forms.Button();
            this.butquizcap3 = new System.Windows.Forms.Button();
            this.timerDataSiOra = new System.Windows.Forms.Timer(this.components);
            this.Timp = new System.Windows.Forms.Label();
            this.OraText = new System.Windows.Forms.Label();
            this.Data = new System.Windows.Forms.Label();
            this.labelQuizVerif = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butinapoi6
            // 
            this.butinapoi6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butinapoi6.BackgroundImage")));
            this.butinapoi6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.butinapoi6.Location = new System.Drawing.Point(26, 401);
            this.butinapoi6.Name = "butinapoi6";
            this.butinapoi6.Size = new System.Drawing.Size(75, 23);
            this.butinapoi6.TabIndex = 0;
            this.butinapoi6.Text = "Înapoi";
            this.butinapoi6.UseVisualStyleBackColor = true;
            this.butinapoi6.Click += new System.EventHandler(this.Butinapoi6_Click);
            // 
            // butinchid6
            // 
            this.butinchid6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butinchid6.BackgroundImage")));
            this.butinchid6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.butinchid6.Location = new System.Drawing.Point(689, 396);
            this.butinchid6.Name = "butinchid6";
            this.butinchid6.Size = new System.Drawing.Size(83, 28);
            this.butinchid6.TabIndex = 1;
            this.butinchid6.Text = "Închide";
            this.butinchid6.UseVisualStyleBackColor = true;
            this.butinchid6.Click += new System.EventHandler(this.Butinchid6_Click);
            // 
            // butquizcap1
            // 
            this.butquizcap1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butquizcap1.BackgroundImage")));
            this.butquizcap1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.butquizcap1.Location = new System.Drawing.Point(338, 141);
            this.butquizcap1.Name = "butquizcap1";
            this.butquizcap1.Size = new System.Drawing.Size(75, 29);
            this.butquizcap1.TabIndex = 2;
            this.butquizcap1.Text = "Cap. 1";
            this.butquizcap1.UseVisualStyleBackColor = true;
            this.butquizcap1.Click += new System.EventHandler(this.Butquizcap1_Click);
            // 
            // butquizcap2
            // 
            this.butquizcap2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butquizcap2.BackgroundImage")));
            this.butquizcap2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.butquizcap2.Location = new System.Drawing.Point(338, 200);
            this.butquizcap2.Name = "butquizcap2";
            this.butquizcap2.Size = new System.Drawing.Size(75, 30);
            this.butquizcap2.TabIndex = 3;
            this.butquizcap2.Text = "Cap. 2";
            this.butquizcap2.UseVisualStyleBackColor = true;
            this.butquizcap2.Click += new System.EventHandler(this.Butquizcap2_Click);
            // 
            // butquizcap3
            // 
            this.butquizcap3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butquizcap3.BackgroundImage")));
            this.butquizcap3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.butquizcap3.Location = new System.Drawing.Point(338, 258);
            this.butquizcap3.Name = "butquizcap3";
            this.butquizcap3.Size = new System.Drawing.Size(75, 27);
            this.butquizcap3.TabIndex = 4;
            this.butquizcap3.Text = "Cap. 3";
            this.butquizcap3.UseVisualStyleBackColor = true;
            this.butquizcap3.Click += new System.EventHandler(this.Butquizcap3_Click);
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
            this.Timp.Location = new System.Drawing.Point(274, 421);
            this.Timp.Name = "Timp";
            this.Timp.Size = new System.Drawing.Size(0, 17);
            this.Timp.TabIndex = 13;
            // 
            // OraText
            // 
            this.OraText.AutoSize = true;
            this.OraText.BackColor = System.Drawing.Color.Transparent;
            this.OraText.Location = new System.Drawing.Point(242, 421);
            this.OraText.Name = "OraText";
            this.OraText.Size = new System.Drawing.Size(40, 17);
            this.OraText.TabIndex = 12;
            this.OraText.Text = "Ora: ";
            // 
            // Data
            // 
            this.Data.AutoSize = true;
            this.Data.BackColor = System.Drawing.Color.Transparent;
            this.Data.Location = new System.Drawing.Point(242, 404);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(46, 17);
            this.Data.TabIndex = 11;
            this.Data.Text = "Data: ";
            // 
            // labelQuizVerif
            // 
            this.labelQuizVerif.AutoSize = true;
            this.labelQuizVerif.BackColor = System.Drawing.Color.Transparent;
            this.labelQuizVerif.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuizVerif.Location = new System.Drawing.Point(180, 34);
            this.labelQuizVerif.Name = "labelQuizVerif";
            this.labelQuizVerif.Size = new System.Drawing.Size(408, 46);
            this.labelQuizVerif.TabIndex = 14;
            this.labelQuizVerif.Text = "Quiz-uri de verificare";
            // 
            // QuizVerificare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.labelQuizVerif);
            this.Controls.Add(this.Timp);
            this.Controls.Add(this.OraText);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.butquizcap3);
            this.Controls.Add(this.butquizcap2);
            this.Controls.Add(this.butquizcap1);
            this.Controls.Add(this.butinchid6);
            this.Controls.Add(this.butinapoi6);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "QuizVerificare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuizVerificare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butinapoi6;
        private System.Windows.Forms.Button butinchid6;
        private System.Windows.Forms.Button butquizcap1;
        private System.Windows.Forms.Button butquizcap2;
        private System.Windows.Forms.Button butquizcap3;
        private System.Windows.Forms.Timer timerDataSiOra;
        private System.Windows.Forms.Label Timp;
        private System.Windows.Forms.Label OraText;
        private System.Windows.Forms.Label Data;
        private System.Windows.Forms.Label labelQuizVerif;
    }
}