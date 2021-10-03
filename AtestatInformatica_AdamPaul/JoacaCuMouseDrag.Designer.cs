namespace AtestatInformatica_AdamPaul
{
    partial class JoacaCuMouseDrag
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JoacaCuMouseDrag));
            this.butinchid1 = new System.Windows.Forms.Button();
            this.butusor = new System.Windows.Forms.Button();
            this.butmediu = new System.Windows.Forms.Button();
            this.butgreu = new System.Windows.Forms.Button();
            this.butinapoi7 = new System.Windows.Forms.Button();
            this.timerDataSiOra = new System.Windows.Forms.Timer(this.components);
            this.Timp = new System.Windows.Forms.Label();
            this.OraText = new System.Windows.Forms.Label();
            this.Data = new System.Windows.Forms.Label();
            this.lblDificultate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butinchid1
            // 
            this.butinchid1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butinchid1.BackgroundImage")));
            this.butinchid1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.butinchid1.Location = new System.Drawing.Point(697, 402);
            this.butinchid1.Name = "butinchid1";
            this.butinchid1.Size = new System.Drawing.Size(75, 23);
            this.butinchid1.TabIndex = 1;
            this.butinchid1.Text = "Inchide";
            this.butinchid1.UseVisualStyleBackColor = true;
            this.butinchid1.Click += new System.EventHandler(this.Butinchid1_Click);
            // 
            // butusor
            // 
            this.butusor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butusor.BackgroundImage")));
            this.butusor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.butusor.Location = new System.Drawing.Point(316, 142);
            this.butusor.Name = "butusor";
            this.butusor.Size = new System.Drawing.Size(75, 26);
            this.butusor.TabIndex = 2;
            this.butusor.Text = "Ușor";
            this.butusor.UseVisualStyleBackColor = true;
            this.butusor.Click += new System.EventHandler(this.Butusor_Click);
            // 
            // butmediu
            // 
            this.butmediu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butmediu.BackgroundImage")));
            this.butmediu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.butmediu.Location = new System.Drawing.Point(316, 198);
            this.butmediu.Name = "butmediu";
            this.butmediu.Size = new System.Drawing.Size(75, 23);
            this.butmediu.TabIndex = 3;
            this.butmediu.Text = "Mediu";
            this.butmediu.UseVisualStyleBackColor = true;
            this.butmediu.Click += new System.EventHandler(this.Butmediu_Click);
            // 
            // butgreu
            // 
            this.butgreu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butgreu.BackgroundImage")));
            this.butgreu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.butgreu.Location = new System.Drawing.Point(316, 251);
            this.butgreu.Name = "butgreu";
            this.butgreu.Size = new System.Drawing.Size(75, 23);
            this.butgreu.TabIndex = 4;
            this.butgreu.Text = "Greu";
            this.butgreu.UseVisualStyleBackColor = true;
            this.butgreu.Click += new System.EventHandler(this.Butgreu_Click);
            // 
            // butinapoi7
            // 
            this.butinapoi7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butinapoi7.BackgroundImage")));
            this.butinapoi7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.butinapoi7.Location = new System.Drawing.Point(24, 402);
            this.butinapoi7.Name = "butinapoi7";
            this.butinapoi7.Size = new System.Drawing.Size(75, 23);
            this.butinapoi7.TabIndex = 5;
            this.butinapoi7.Text = "Înapoi";
            this.butinapoi7.UseVisualStyleBackColor = true;
            this.butinapoi7.Click += new System.EventHandler(this.Butinapoi7_Click);
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
            this.Timp.Location = new System.Drawing.Point(274, 422);
            this.Timp.Name = "Timp";
            this.Timp.Size = new System.Drawing.Size(0, 17);
            this.Timp.TabIndex = 13;
            // 
            // OraText
            // 
            this.OraText.AutoSize = true;
            this.OraText.BackColor = System.Drawing.Color.Transparent;
            this.OraText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.OraText.Location = new System.Drawing.Point(242, 422);
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
            this.Data.Location = new System.Drawing.Point(242, 405);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(46, 17);
            this.Data.TabIndex = 11;
            this.Data.Text = "Data: ";
            // 
            // lblDificultate
            // 
            this.lblDificultate.AutoSize = true;
            this.lblDificultate.BackColor = System.Drawing.Color.Transparent;
            this.lblDificultate.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDificultate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDificultate.Location = new System.Drawing.Point(259, 34);
            this.lblDificultate.Name = "lblDificultate";
            this.lblDificultate.Size = new System.Drawing.Size(196, 46);
            this.lblDificultate.TabIndex = 14;
            this.lblDificultate.Text = "Dificultate";
            // 
            // JoacaCuMouseDrag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.lblDificultate);
            this.Controls.Add(this.Timp);
            this.Controls.Add(this.OraText);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.butinapoi7);
            this.Controls.Add(this.butgreu);
            this.Controls.Add(this.butmediu);
            this.Controls.Add(this.butusor);
            this.Controls.Add(this.butinchid1);
            this.Name = "JoacaCuMouseDrag";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JoacaCuMouseDrag";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button butinchid1;
        private System.Windows.Forms.Button butusor;
        private System.Windows.Forms.Button butmediu;
        private System.Windows.Forms.Button butgreu;
        private System.Windows.Forms.Button butinapoi7;
        private System.Windows.Forms.Timer timerDataSiOra;
        private System.Windows.Forms.Label Timp;
        private System.Windows.Forms.Label OraText;
        private System.Windows.Forms.Label Data;
        private System.Windows.Forms.Label lblDificultate;
    }
}