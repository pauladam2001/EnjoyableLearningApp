namespace AtestatInformatica_AdamPaul
{
    partial class InformatiiAtestat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformatiiAtestat));
            this.timerDataSiOra = new System.Windows.Forms.Timer(this.components);
            this.Timp = new System.Windows.Forms.Label();
            this.OraText = new System.Windows.Forms.Label();
            this.Data = new System.Windows.Forms.Label();
            this.butInapoiInf = new System.Windows.Forms.Button();
            this.butInchideInf = new System.Windows.Forms.Button();
            this.textBoxInfAtestat = new System.Windows.Forms.TextBox();
            this.pictureBoxSigla = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSigla)).BeginInit();
            this.SuspendLayout();
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
            this.Timp.Location = new System.Drawing.Point(277, 422);
            this.Timp.Name = "Timp";
            this.Timp.Size = new System.Drawing.Size(0, 17);
            this.Timp.TabIndex = 16;
            // 
            // OraText
            // 
            this.OraText.AutoSize = true;
            this.OraText.BackColor = System.Drawing.Color.Transparent;
            this.OraText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.OraText.Location = new System.Drawing.Point(245, 422);
            this.OraText.Name = "OraText";
            this.OraText.Size = new System.Drawing.Size(40, 17);
            this.OraText.TabIndex = 15;
            this.OraText.Text = "Ora: ";
            // 
            // Data
            // 
            this.Data.AutoSize = true;
            this.Data.BackColor = System.Drawing.Color.Transparent;
            this.Data.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Data.Location = new System.Drawing.Point(245, 405);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(46, 17);
            this.Data.TabIndex = 14;
            this.Data.Text = "Data: ";
            // 
            // butInapoiInf
            // 
            this.butInapoiInf.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butInapoiInf.BackgroundImage")));
            this.butInapoiInf.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.butInapoiInf.Location = new System.Drawing.Point(21, 402);
            this.butInapoiInf.Name = "butInapoiInf";
            this.butInapoiInf.Size = new System.Drawing.Size(75, 23);
            this.butInapoiInf.TabIndex = 17;
            this.butInapoiInf.Text = "Înapoi";
            this.butInapoiInf.UseVisualStyleBackColor = true;
            this.butInapoiInf.Click += new System.EventHandler(this.ButInapoiInf_Click);
            // 
            // butInchideInf
            // 
            this.butInchideInf.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butInchideInf.BackgroundImage")));
            this.butInchideInf.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.butInchideInf.Location = new System.Drawing.Point(699, 402);
            this.butInchideInf.Name = "butInchideInf";
            this.butInchideInf.Size = new System.Drawing.Size(75, 23);
            this.butInchideInf.TabIndex = 18;
            this.butInchideInf.Text = "Închide";
            this.butInchideInf.UseVisualStyleBackColor = true;
            this.butInchideInf.Click += new System.EventHandler(this.ButInchideInf_Click);
            // 
            // textBoxInfAtestat
            // 
            this.textBoxInfAtestat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxInfAtestat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInfAtestat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxInfAtestat.Location = new System.Drawing.Point(-1, 32);
            this.textBoxInfAtestat.Multiline = true;
            this.textBoxInfAtestat.Name = "textBoxInfAtestat";
            this.textBoxInfAtestat.ReadOnly = true;
            this.textBoxInfAtestat.Size = new System.Drawing.Size(477, 233);
            this.textBoxInfAtestat.TabIndex = 19;
            this.textBoxInfAtestat.Text = "Titlul atestatului: Soft învățare și                                          rel" +
    "axare\r\nElev: Adam Paul\r\nProfesor coordonator: Maier Cornelia\r\nClasa: A XII-A Mat" +
    "ematică-Informatică\r\n\r\n";
            // 
            // pictureBoxSigla
            // 
            this.pictureBoxSigla.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSigla.Image")));
            this.pictureBoxSigla.Location = new System.Drawing.Point(500, -1);
            this.pictureBoxSigla.Name = "pictureBoxSigla";
            this.pictureBoxSigla.Size = new System.Drawing.Size(300, 300);
            this.pictureBoxSigla.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSigla.TabIndex = 20;
            this.pictureBoxSigla.TabStop = false;
            // 
            // InformatiiAtestat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBoxSigla);
            this.Controls.Add(this.textBoxInfAtestat);
            this.Controls.Add(this.butInchideInf);
            this.Controls.Add(this.butInapoiInf);
            this.Controls.Add(this.Timp);
            this.Controls.Add(this.OraText);
            this.Controls.Add(this.Data);
            this.Name = "InformatiiAtestat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proiect pentru susținerea atestatului profesional";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSigla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerDataSiOra;
        private System.Windows.Forms.Label Timp;
        private System.Windows.Forms.Label OraText;
        private System.Windows.Forms.Label Data;
        private System.Windows.Forms.Button butInapoiInf;
        private System.Windows.Forms.Button butInchideInf;
        private System.Windows.Forms.TextBox textBoxInfAtestat;
        private System.Windows.Forms.PictureBox pictureBoxSigla;
    }
}