namespace AtestatInformatica_AdamPaul
{
    partial class Teorie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teorie));
            this.lblTeorie = new System.Windows.Forms.Label();
            this.butinchid5 = new System.Windows.Forms.Button();
            this.butinapoi5 = new System.Windows.Forms.Button();
            this.butCap1 = new System.Windows.Forms.Button();
            this.butCap2 = new System.Windows.Forms.Button();
            this.butCap3 = new System.Windows.Forms.Button();
            this.timerDataSiOra = new System.Windows.Forms.Timer(this.components);
            this.Timp = new System.Windows.Forms.Label();
            this.OraText = new System.Windows.Forms.Label();
            this.Data = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTeorie
            // 
            this.lblTeorie.AutoSize = true;
            this.lblTeorie.BackColor = System.Drawing.Color.Transparent;
            this.lblTeorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeorie.Location = new System.Drawing.Point(308, 44);
            this.lblTeorie.Name = "lblTeorie";
            this.lblTeorie.Size = new System.Drawing.Size(139, 46);
            this.lblTeorie.TabIndex = 0;
            this.lblTeorie.Text = "Teorie";
            // 
            // butinchid5
            // 
            this.butinchid5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butinchid5.BackgroundImage")));
            this.butinchid5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.butinchid5.Location = new System.Drawing.Point(689, 399);
            this.butinchid5.Name = "butinchid5";
            this.butinchid5.Size = new System.Drawing.Size(83, 23);
            this.butinchid5.TabIndex = 9;
            this.butinchid5.Text = "Închide";
            this.butinchid5.UseVisualStyleBackColor = true;
            this.butinchid5.Click += new System.EventHandler(this.Butinchid5_Click);
            // 
            // butinapoi5
            // 
            this.butinapoi5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butinapoi5.BackgroundImage")));
            this.butinapoi5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.butinapoi5.Location = new System.Drawing.Point(24, 399);
            this.butinapoi5.Name = "butinapoi5";
            this.butinapoi5.Size = new System.Drawing.Size(75, 23);
            this.butinapoi5.TabIndex = 10;
            this.butinapoi5.Text = "Înapoi";
            this.butinapoi5.UseVisualStyleBackColor = true;
            this.butinapoi5.Click += new System.EventHandler(this.Butinapoi5_Click);
            // 
            // butCap1
            // 
            this.butCap1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butCap1.BackgroundImage")));
            this.butCap1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.butCap1.Location = new System.Drawing.Point(291, 154);
            this.butCap1.Name = "butCap1";
            this.butCap1.Size = new System.Drawing.Size(173, 23);
            this.butCap1.TabIndex = 11;
            this.butCap1.Text = "Cap. 1: Corpul uman";
            this.butCap1.UseVisualStyleBackColor = true;
            this.butCap1.Click += new System.EventHandler(this.ButCap1_Click);
            // 
            // butCap2
            // 
            this.butCap2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butCap2.BackgroundImage")));
            this.butCap2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.butCap2.Location = new System.Drawing.Point(291, 213);
            this.butCap2.Name = "butCap2";
            this.butCap2.Size = new System.Drawing.Size(173, 23);
            this.butCap2.TabIndex = 12;
            this.butCap2.Text = "Cap. 2: Sistemul Solar";
            this.butCap2.UseVisualStyleBackColor = true;
            this.butCap2.Click += new System.EventHandler(this.ButCap2_Click);
            // 
            // butCap3
            // 
            this.butCap3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butCap3.BackgroundImage")));
            this.butCap3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.butCap3.Location = new System.Drawing.Point(291, 266);
            this.butCap3.Name = "butCap3";
            this.butCap3.Size = new System.Drawing.Size(173, 23);
            this.butCap3.TabIndex = 13;
            this.butCap3.Text = "Cap. 3: Mamiferele";
            this.butCap3.UseVisualStyleBackColor = true;
            this.butCap3.Click += new System.EventHandler(this.ButCap3_Click);
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
            this.Timp.Location = new System.Drawing.Point(276, 422);
            this.Timp.Name = "Timp";
            this.Timp.Size = new System.Drawing.Size(0, 17);
            this.Timp.TabIndex = 16;
            // 
            // OraText
            // 
            this.OraText.AutoSize = true;
            this.OraText.BackColor = System.Drawing.Color.Transparent;
            this.OraText.Location = new System.Drawing.Point(244, 422);
            this.OraText.Name = "OraText";
            this.OraText.Size = new System.Drawing.Size(40, 17);
            this.OraText.TabIndex = 15;
            this.OraText.Text = "Ora: ";
            // 
            // Data
            // 
            this.Data.AutoSize = true;
            this.Data.BackColor = System.Drawing.Color.Transparent;
            this.Data.Location = new System.Drawing.Point(244, 405);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(46, 17);
            this.Data.TabIndex = 14;
            this.Data.Text = "Data: ";
            // 
            // Teorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.Timp);
            this.Controls.Add(this.OraText);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.butCap3);
            this.Controls.Add(this.butCap2);
            this.Controls.Add(this.butCap1);
            this.Controls.Add(this.butinapoi5);
            this.Controls.Add(this.butinchid5);
            this.Controls.Add(this.lblTeorie);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "Teorie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teorie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTeorie;
        private System.Windows.Forms.Button butinchid5;
        private System.Windows.Forms.Button butinapoi5;
        private System.Windows.Forms.Button butCap1;
        private System.Windows.Forms.Button butCap2;
        private System.Windows.Forms.Button butCap3;
        private System.Windows.Forms.Timer timerDataSiOra;
        private System.Windows.Forms.Label Timp;
        private System.Windows.Forms.Label OraText;
        private System.Windows.Forms.Label Data;
    }
}