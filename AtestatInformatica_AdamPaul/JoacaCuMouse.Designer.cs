namespace AtestatInformatica_AdamPaul
{
    partial class JoacaCuMouse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JoacaCuMouse));
            this.lblModJocMouse = new System.Windows.Forms.Label();
            this.butRandomMouse = new System.Windows.Forms.Button();
            this.butCuNivelMouse = new System.Windows.Forms.Button();
            this.butinchid2 = new System.Windows.Forms.Button();
            this.butinapoi2 = new System.Windows.Forms.Button();
            this.timerDataSiOra = new System.Windows.Forms.Timer(this.components);
            this.Timp = new System.Windows.Forms.Label();
            this.OraText = new System.Windows.Forms.Label();
            this.Data = new System.Windows.Forms.Label();
            this.textBoxDescRandom = new System.Windows.Forms.TextBox();
            this.textBoxDescPredef = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblModJocMouse
            // 
            this.lblModJocMouse.AutoSize = true;
            this.lblModJocMouse.BackColor = System.Drawing.Color.Transparent;
            this.lblModJocMouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModJocMouse.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblModJocMouse.Location = new System.Drawing.Point(268, 39);
            this.lblModJocMouse.Name = "lblModJocMouse";
            this.lblModJocMouse.Size = new System.Drawing.Size(249, 46);
            this.lblModJocMouse.TabIndex = 0;
            this.lblModJocMouse.Text = "Modul de joc";
            // 
            // butRandomMouse
            // 
            this.butRandomMouse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butRandomMouse.BackgroundImage")));
            this.butRandomMouse.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.butRandomMouse.Location = new System.Drawing.Point(172, 114);
            this.butRandomMouse.Name = "butRandomMouse";
            this.butRandomMouse.Size = new System.Drawing.Size(75, 23);
            this.butRandomMouse.TabIndex = 1;
            this.butRandomMouse.Text = "Random";
            this.butRandomMouse.UseVisualStyleBackColor = true;
            this.butRandomMouse.Click += new System.EventHandler(this.ButRandomMouse_Click);
            // 
            // butCuNivelMouse
            // 
            this.butCuNivelMouse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butCuNivelMouse.BackgroundImage")));
            this.butCuNivelMouse.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.butCuNivelMouse.Location = new System.Drawing.Point(492, 114);
            this.butCuNivelMouse.Name = "butCuNivelMouse";
            this.butCuNivelMouse.Size = new System.Drawing.Size(154, 23);
            this.butCuNivelMouse.TabIndex = 2;
            this.butCuNivelMouse.Text = "Niveluri predefinite";
            this.butCuNivelMouse.UseVisualStyleBackColor = true;
            this.butCuNivelMouse.Click += new System.EventHandler(this.ButCuNivelMouse_Click);
            // 
            // butinchid2
            // 
            this.butinchid2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butinchid2.BackgroundImage")));
            this.butinchid2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.butinchid2.Location = new System.Drawing.Point(690, 403);
            this.butinchid2.Name = "butinchid2";
            this.butinchid2.Size = new System.Drawing.Size(83, 23);
            this.butinchid2.TabIndex = 7;
            this.butinchid2.Text = "Închide";
            this.butinchid2.UseVisualStyleBackColor = true;
            this.butinchid2.Click += new System.EventHandler(this.Butinchid2_Click);
            // 
            // butinapoi2
            // 
            this.butinapoi2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butinapoi2.BackgroundImage")));
            this.butinapoi2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.butinapoi2.Location = new System.Drawing.Point(22, 403);
            this.butinapoi2.Name = "butinapoi2";
            this.butinapoi2.Size = new System.Drawing.Size(75, 23);
            this.butinapoi2.TabIndex = 8;
            this.butinapoi2.Text = "Înapoi";
            this.butinapoi2.UseVisualStyleBackColor = true;
            this.butinapoi2.Click += new System.EventHandler(this.Butinapoi2_Click);
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
            this.Timp.Location = new System.Drawing.Point(273, 420);
            this.Timp.Name = "Timp";
            this.Timp.Size = new System.Drawing.Size(0, 17);
            this.Timp.TabIndex = 13;
            // 
            // OraText
            // 
            this.OraText.AutoSize = true;
            this.OraText.BackColor = System.Drawing.Color.Transparent;
            this.OraText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.OraText.Location = new System.Drawing.Point(241, 420);
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
            this.Data.Location = new System.Drawing.Point(241, 403);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(46, 17);
            this.Data.TabIndex = 11;
            this.Data.Text = "Data: ";
            // 
            // textBoxDescRandom
            // 
            this.textBoxDescRandom.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxDescRandom.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxDescRandom.Location = new System.Drawing.Point(12, 153);
            this.textBoxDescRandom.Multiline = true;
            this.textBoxDescRandom.Name = "textBoxDescRandom";
            this.textBoxDescRandom.Size = new System.Drawing.Size(381, 233);
            this.textBoxDescRandom.TabIndex = 14;
            this.textBoxDescRandom.Text = resources.GetString("textBoxDescRandom.Text");
            // 
            // textBoxDescPredef
            // 
            this.textBoxDescPredef.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxDescPredef.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxDescPredef.Location = new System.Drawing.Point(425, 172);
            this.textBoxDescPredef.Multiline = true;
            this.textBoxDescPredef.Name = "textBoxDescPredef";
            this.textBoxDescPredef.ReadOnly = true;
            this.textBoxDescPredef.Size = new System.Drawing.Size(312, 204);
            this.textBoxDescPredef.TabIndex = 15;
            this.textBoxDescPredef.Text = resources.GetString("textBoxDescPredef.Text");
            // 
            // JoacaCuMouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.textBoxDescPredef);
            this.Controls.Add(this.textBoxDescRandom);
            this.Controls.Add(this.Timp);
            this.Controls.Add(this.OraText);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.butinapoi2);
            this.Controls.Add(this.butinchid2);
            this.Controls.Add(this.butCuNivelMouse);
            this.Controls.Add(this.butRandomMouse);
            this.Controls.Add(this.lblModJocMouse);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "JoacaCuMouse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JoacaCuMouseClick";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModJocMouse;
        private System.Windows.Forms.Button butRandomMouse;
        private System.Windows.Forms.Button butCuNivelMouse;
        private System.Windows.Forms.Button butinchid2;
        private System.Windows.Forms.Button butinapoi2;
        private System.Windows.Forms.Timer timerDataSiOra;
        private System.Windows.Forms.Label Timp;
        private System.Windows.Forms.Label OraText;
        private System.Windows.Forms.Label Data;
        private System.Windows.Forms.TextBox textBoxDescRandom;
        private System.Windows.Forms.TextBox textBoxDescPredef;
    }
}