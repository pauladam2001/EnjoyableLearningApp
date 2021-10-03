namespace AtestatInformatica_AdamPaul
{
    partial class Cap1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cap1));
            this.richTextBoxCap1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.butinapoicap1 = new System.Windows.Forms.Button();
            this.butinchidecap1 = new System.Windows.Forms.Button();
            this.butquizcap1 = new System.Windows.Forms.Button();
            this.timerDataSiOra = new System.Windows.Forms.Timer(this.components);
            this.Timp = new System.Windows.Forms.Label();
            this.OraText = new System.Windows.Forms.Label();
            this.Data = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBoxCap1
            // 
            this.richTextBoxCap1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.richTextBoxCap1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxCap1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.richTextBoxCap1.Location = new System.Drawing.Point(0, -5);
            this.richTextBoxCap1.Name = "richTextBoxCap1";
            this.richTextBoxCap1.ReadOnly = true;
            this.richTextBoxCap1.Size = new System.Drawing.Size(805, 465);
            this.richTextBoxCap1.TabIndex = 0;
            this.richTextBoxCap1.Text = resources.GetString("richTextBoxCap1.Text");
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(482, 224);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 259);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // butinapoicap1
            // 
            this.butinapoicap1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butinapoicap1.BackgroundImage")));
            this.butinapoicap1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.butinapoicap1.Location = new System.Drawing.Point(12, 412);
            this.butinapoicap1.Name = "butinapoicap1";
            this.butinapoicap1.Size = new System.Drawing.Size(75, 23);
            this.butinapoicap1.TabIndex = 2;
            this.butinapoicap1.Text = "Înapoi";
            this.butinapoicap1.UseVisualStyleBackColor = true;
            this.butinapoicap1.Click += new System.EventHandler(this.Butinapoicap1_Click);
            // 
            // butinchidecap1
            // 
            this.butinchidecap1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butinchidecap1.BackgroundImage")));
            this.butinchidecap1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.butinchidecap1.Location = new System.Drawing.Point(713, 415);
            this.butinchidecap1.Name = "butinchidecap1";
            this.butinchidecap1.Size = new System.Drawing.Size(75, 23);
            this.butinchidecap1.TabIndex = 3;
            this.butinchidecap1.Text = "Închide";
            this.butinchidecap1.UseVisualStyleBackColor = true;
            this.butinchidecap1.Click += new System.EventHandler(this.Butinchidecap1_Click);
            // 
            // butquizcap1
            // 
            this.butquizcap1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butquizcap1.BackgroundImage")));
            this.butquizcap1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.butquizcap1.Location = new System.Drawing.Point(366, 415);
            this.butquizcap1.Name = "butquizcap1";
            this.butquizcap1.Size = new System.Drawing.Size(75, 23);
            this.butquizcap1.TabIndex = 4;
            this.butquizcap1.Text = "Quiz";
            this.butquizcap1.UseVisualStyleBackColor = true;
            this.butquizcap1.Click += new System.EventHandler(this.Butquizcap1_Click);
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
            this.Timp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Timp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Timp.Location = new System.Drawing.Point(125, 432);
            this.Timp.Name = "Timp";
            this.Timp.Size = new System.Drawing.Size(0, 17);
            this.Timp.TabIndex = 13;
            // 
            // OraText
            // 
            this.OraText.AutoSize = true;
            this.OraText.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.OraText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.OraText.Location = new System.Drawing.Point(93, 432);
            this.OraText.Name = "OraText";
            this.OraText.Size = new System.Drawing.Size(40, 17);
            this.OraText.TabIndex = 12;
            this.OraText.Text = "Ora: ";
            // 
            // Data
            // 
            this.Data.AutoSize = true;
            this.Data.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Data.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Data.Location = new System.Drawing.Point(93, 415);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(46, 17);
            this.Data.TabIndex = 11;
            this.Data.Text = "Data: ";
            // 
            // Cap1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.Timp);
            this.Controls.Add(this.OraText);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.butquizcap1);
            this.Controls.Add(this.butinchidecap1);
            this.Controls.Add(this.butinapoicap1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.richTextBoxCap1);
            this.Name = "Cap1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Corpul uman";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxCap1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button butinapoicap1;
        private System.Windows.Forms.Button butinchidecap1;
        private System.Windows.Forms.Button butquizcap1;
        private System.Windows.Forms.Timer timerDataSiOra;
        private System.Windows.Forms.Label Timp;
        private System.Windows.Forms.Label OraText;
        private System.Windows.Forms.Label Data;
    }
}