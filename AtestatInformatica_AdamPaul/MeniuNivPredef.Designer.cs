namespace AtestatInformatica_AdamPaul
{
    partial class MeniuNivPredef
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MeniuNivPredef));
            this.butNiv1Predef = new System.Windows.Forms.Button();
            this.butNiv2Predef = new System.Windows.Forms.Button();
            this.butNiv3Predef = new System.Windows.Forms.Button();
            this.butInapoiPredef = new System.Windows.Forms.Button();
            this.butInchidePredef = new System.Windows.Forms.Button();
            this.timerDataSiOra = new System.Windows.Forms.Timer(this.components);
            this.Timp = new System.Windows.Forms.Label();
            this.OraText = new System.Windows.Forms.Label();
            this.Data = new System.Windows.Forms.Label();
            this.lblDificultate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butNiv1Predef
            // 
            this.butNiv1Predef.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.butNiv1Predef.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butNiv1Predef.BackgroundImage")));
            this.butNiv1Predef.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.butNiv1Predef.Location = new System.Drawing.Point(346, 168);
            this.butNiv1Predef.Name = "butNiv1Predef";
            this.butNiv1Predef.Size = new System.Drawing.Size(75, 30);
            this.butNiv1Predef.TabIndex = 0;
            this.butNiv1Predef.Text = "Ușor";
            this.butNiv1Predef.UseMnemonic = false;
            this.butNiv1Predef.UseVisualStyleBackColor = false;
            this.butNiv1Predef.Click += new System.EventHandler(this.ButNiv1Predef_Click);
            // 
            // butNiv2Predef
            // 
            this.butNiv2Predef.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.butNiv2Predef.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butNiv2Predef.BackgroundImage")));
            this.butNiv2Predef.Location = new System.Drawing.Point(346, 221);
            this.butNiv2Predef.Name = "butNiv2Predef";
            this.butNiv2Predef.Size = new System.Drawing.Size(75, 23);
            this.butNiv2Predef.TabIndex = 1;
            this.butNiv2Predef.Text = "Mediu";
            this.butNiv2Predef.UseVisualStyleBackColor = false;
            this.butNiv2Predef.Click += new System.EventHandler(this.ButNiv2Predef_Click);
            // 
            // butNiv3Predef
            // 
            this.butNiv3Predef.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.butNiv3Predef.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butNiv3Predef.BackgroundImage")));
            this.butNiv3Predef.Location = new System.Drawing.Point(346, 266);
            this.butNiv3Predef.Name = "butNiv3Predef";
            this.butNiv3Predef.Size = new System.Drawing.Size(75, 23);
            this.butNiv3Predef.TabIndex = 2;
            this.butNiv3Predef.Text = "Greu";
            this.butNiv3Predef.UseVisualStyleBackColor = false;
            this.butNiv3Predef.Click += new System.EventHandler(this.ButNiv3Predef_Click);
            // 
            // butInapoiPredef
            // 
            this.butInapoiPredef.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.butInapoiPredef.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butInapoiPredef.BackgroundImage")));
            this.butInapoiPredef.Location = new System.Drawing.Point(25, 399);
            this.butInapoiPredef.Name = "butInapoiPredef";
            this.butInapoiPredef.Size = new System.Drawing.Size(75, 23);
            this.butInapoiPredef.TabIndex = 3;
            this.butInapoiPredef.Text = "Înapoi";
            this.butInapoiPredef.UseVisualStyleBackColor = false;
            this.butInapoiPredef.Click += new System.EventHandler(this.ButInapoiPredef_Click);
            // 
            // butInchidePredef
            // 
            this.butInchidePredef.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.butInchidePredef.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butInchidePredef.BackgroundImage")));
            this.butInchidePredef.Location = new System.Drawing.Point(697, 399);
            this.butInchidePredef.Name = "butInchidePredef";
            this.butInchidePredef.Size = new System.Drawing.Size(75, 23);
            this.butInchidePredef.TabIndex = 4;
            this.butInchidePredef.Text = "Închide";
            this.butInchidePredef.UseVisualStyleBackColor = false;
            this.butInchidePredef.Click += new System.EventHandler(this.ButInchidePredef_Click);
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
            this.Timp.Location = new System.Drawing.Point(275, 422);
            this.Timp.Name = "Timp";
            this.Timp.Size = new System.Drawing.Size(0, 17);
            this.Timp.TabIndex = 13;
            // 
            // OraText
            // 
            this.OraText.AutoSize = true;
            this.OraText.BackColor = System.Drawing.Color.Transparent;
            this.OraText.Location = new System.Drawing.Point(243, 422);
            this.OraText.Name = "OraText";
            this.OraText.Size = new System.Drawing.Size(40, 17);
            this.OraText.TabIndex = 12;
            this.OraText.Text = "Ora: ";
            // 
            // Data
            // 
            this.Data.AutoSize = true;
            this.Data.BackColor = System.Drawing.Color.Transparent;
            this.Data.Location = new System.Drawing.Point(243, 405);
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
            this.lblDificultate.Location = new System.Drawing.Point(285, 64);
            this.lblDificultate.Name = "lblDificultate";
            this.lblDificultate.Size = new System.Drawing.Size(196, 46);
            this.lblDificultate.TabIndex = 14;
            this.lblDificultate.Text = "Dificultate";
            // 
            // MeniuNivPredef
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
            this.Controls.Add(this.butInchidePredef);
            this.Controls.Add(this.butInapoiPredef);
            this.Controls.Add(this.butNiv3Predef);
            this.Controls.Add(this.butNiv2Predef);
            this.Controls.Add(this.butNiv1Predef);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "MeniuNivPredef";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MeniuNivPredef";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butNiv1Predef;
        private System.Windows.Forms.Button butNiv2Predef;
        private System.Windows.Forms.Button butNiv3Predef;
        private System.Windows.Forms.Button butInapoiPredef;
        private System.Windows.Forms.Button butInchidePredef;
        private System.Windows.Forms.Timer timerDataSiOra;
        private System.Windows.Forms.Label Timp;
        private System.Windows.Forms.Label OraText;
        private System.Windows.Forms.Label Data;
        private System.Windows.Forms.Label lblDificultate;
    }
}