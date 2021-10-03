namespace AtestatInformatica_AdamPaul
{
    partial class MeniuLabirint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MeniuLabirint));
            this.lblMeniuLabirint = new System.Windows.Forms.Label();
            this.cuMouse = new System.Windows.Forms.Button();
            this.cuTastatura = new System.Windows.Forms.Button();
            this.butinchid3 = new System.Windows.Forms.Button();
            this.butinapoi3 = new System.Windows.Forms.Button();
            this.timerDataSiOra = new System.Windows.Forms.Timer(this.components);
            this.Timp = new System.Windows.Forms.Label();
            this.OraText = new System.Windows.Forms.Label();
            this.Data = new System.Windows.Forms.Label();
            this.textBoxDescPredef = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblMeniuLabirint
            // 
            this.lblMeniuLabirint.AutoSize = true;
            this.lblMeniuLabirint.BackColor = System.Drawing.Color.Transparent;
            this.lblMeniuLabirint.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeniuLabirint.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMeniuLabirint.Location = new System.Drawing.Point(270, 43);
            this.lblMeniuLabirint.Name = "lblMeniuLabirint";
            this.lblMeniuLabirint.Size = new System.Drawing.Size(256, 46);
            this.lblMeniuLabirint.TabIndex = 0;
            this.lblMeniuLabirint.Text = "Meniu labirint";
            this.lblMeniuLabirint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cuMouse
            // 
            this.cuMouse.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cuMouse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cuMouse.BackgroundImage")));
            this.cuMouse.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cuMouse.Location = new System.Drawing.Point(136, 187);
            this.cuMouse.Name = "cuMouse";
            this.cuMouse.Size = new System.Drawing.Size(153, 45);
            this.cuMouse.TabIndex = 1;
            this.cuMouse.Text = "Joacă cu mouse-ul_Click";
            this.cuMouse.UseVisualStyleBackColor = false;
            this.cuMouse.Click += new System.EventHandler(this.CuMouse_Click);
            // 
            // cuTastatura
            // 
            this.cuTastatura.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cuTastatura.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cuTastatura.BackgroundImage")));
            this.cuTastatura.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cuTastatura.Location = new System.Drawing.Point(466, 187);
            this.cuTastatura.Name = "cuTastatura";
            this.cuTastatura.Size = new System.Drawing.Size(191, 45);
            this.cuTastatura.TabIndex = 2;
            this.cuTastatura.Text = "Joacă cu mouse-ul_Drag";
            this.cuTastatura.UseVisualStyleBackColor = false;
            this.cuTastatura.Click += new System.EventHandler(this.CuTastatura_Click);
            // 
            // butinchid3
            // 
            this.butinchid3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.butinchid3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butinchid3.BackgroundImage")));
            this.butinchid3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.butinchid3.Location = new System.Drawing.Point(688, 403);
            this.butinchid3.Name = "butinchid3";
            this.butinchid3.Size = new System.Drawing.Size(83, 23);
            this.butinchid3.TabIndex = 8;
            this.butinchid3.Text = "Închide";
            this.butinchid3.UseVisualStyleBackColor = false;
            this.butinchid3.Click += new System.EventHandler(this.Butinchid3_Click);
            // 
            // butinapoi3
            // 
            this.butinapoi3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.butinapoi3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butinapoi3.BackgroundImage")));
            this.butinapoi3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.butinapoi3.Location = new System.Drawing.Point(27, 403);
            this.butinapoi3.Name = "butinapoi3";
            this.butinapoi3.Size = new System.Drawing.Size(75, 23);
            this.butinapoi3.TabIndex = 9;
            this.butinapoi3.Text = "Înapoi";
            this.butinapoi3.UseVisualStyleBackColor = false;
            this.butinapoi3.Click += new System.EventHandler(this.Butinapoi3_Click);
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
            this.Timp.Location = new System.Drawing.Point(275, 423);
            this.Timp.Name = "Timp";
            this.Timp.Size = new System.Drawing.Size(0, 17);
            this.Timp.TabIndex = 13;
            // 
            // OraText
            // 
            this.OraText.AutoSize = true;
            this.OraText.BackColor = System.Drawing.Color.Transparent;
            this.OraText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.OraText.Location = new System.Drawing.Point(243, 423);
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
            this.Data.Location = new System.Drawing.Point(243, 406);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(46, 17);
            this.Data.TabIndex = 11;
            this.Data.Text = "Data: ";
            // 
            // textBoxDescPredef
            // 
            this.textBoxDescPredef.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxDescPredef.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxDescPredef.Location = new System.Drawing.Point(85, 238);
            this.textBoxDescPredef.Multiline = true;
            this.textBoxDescPredef.Name = "textBoxDescPredef";
            this.textBoxDescPredef.ReadOnly = true;
            this.textBoxDescPredef.Size = new System.Drawing.Size(260, 90);
            this.textBoxDescPredef.TabIndex = 16;
            this.textBoxDescPredef.Text = "Acest mod de joc constă în parcurgerea unui labirint de tip matrice cu ajutorul m" +
    "ouse-ului.\r\nPoți trece doar prin căsuțele care conțin 0-uri.";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox1.Location = new System.Drawing.Point(434, 238);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(260, 135);
            this.textBox1.TabIndex = 17;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // MeniuLabirint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxDescPredef);
            this.Controls.Add(this.Timp);
            this.Controls.Add(this.OraText);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.butinapoi3);
            this.Controls.Add(this.butinchid3);
            this.Controls.Add(this.cuTastatura);
            this.Controls.Add(this.cuMouse);
            this.Controls.Add(this.lblMeniuLabirint);
            this.Name = "MeniuLabirint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MeniuLabirint";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMeniuLabirint;
        private System.Windows.Forms.Button cuMouse;
        private System.Windows.Forms.Button cuTastatura;
        private System.Windows.Forms.Button butinchid3;
        private System.Windows.Forms.Button butinapoi3;
        private System.Windows.Forms.Timer timerDataSiOra;
        private System.Windows.Forms.Label Timp;
        private System.Windows.Forms.Label OraText;
        private System.Windows.Forms.Label Data;
        private System.Windows.Forms.TextBox textBoxDescPredef;
        private System.Windows.Forms.TextBox textBox1;
    }
}