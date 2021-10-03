namespace AtestatInformatica_AdamPaul
{
    partial class Cap3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cap3));
            this.richTextBoxCap3 = new System.Windows.Forms.RichTextBox();
            this.butinchidecap3 = new System.Windows.Forms.Button();
            this.butinapoicap3 = new System.Windows.Forms.Button();
            this.butquizcap3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timerDataSiOra = new System.Windows.Forms.Timer(this.components);
            this.Timp = new System.Windows.Forms.Label();
            this.OraText = new System.Windows.Forms.Label();
            this.Data = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBoxCap3
            // 
            this.richTextBoxCap3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.richTextBoxCap3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxCap3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.richTextBoxCap3.Location = new System.Drawing.Point(-2, 0);
            this.richTextBoxCap3.Name = "richTextBoxCap3";
            this.richTextBoxCap3.ReadOnly = true;
            this.richTextBoxCap3.Size = new System.Drawing.Size(805, 465);
            this.richTextBoxCap3.TabIndex = 1;
            this.richTextBoxCap3.Text = resources.GetString("richTextBoxCap3.Text");
            // 
            // butinchidecap3
            // 
            this.butinchidecap3.BackColor = System.Drawing.SystemColors.Control;
            this.butinchidecap3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butinchidecap3.BackgroundImage")));
            this.butinchidecap3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.butinchidecap3.Location = new System.Drawing.Point(713, 412);
            this.butinchidecap3.Name = "butinchidecap3";
            this.butinchidecap3.Size = new System.Drawing.Size(75, 23);
            this.butinchidecap3.TabIndex = 4;
            this.butinchidecap3.Text = "Închide";
            this.butinchidecap3.UseVisualStyleBackColor = false;
            this.butinchidecap3.Click += new System.EventHandler(this.Butinchidecap3_Click);
            // 
            // butinapoicap3
            // 
            this.butinapoicap3.BackColor = System.Drawing.SystemColors.Control;
            this.butinapoicap3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butinapoicap3.BackgroundImage")));
            this.butinapoicap3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.butinapoicap3.Location = new System.Drawing.Point(12, 412);
            this.butinapoicap3.Name = "butinapoicap3";
            this.butinapoicap3.Size = new System.Drawing.Size(75, 23);
            this.butinapoicap3.TabIndex = 7;
            this.butinapoicap3.Text = "Înapoi";
            this.butinapoicap3.UseVisualStyleBackColor = false;
            this.butinapoicap3.Click += new System.EventHandler(this.Butinapoicap3_Click);
            // 
            // butquizcap3
            // 
            this.butquizcap3.BackColor = System.Drawing.SystemColors.Control;
            this.butquizcap3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butquizcap3.BackgroundImage")));
            this.butquizcap3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.butquizcap3.Location = new System.Drawing.Point(313, 412);
            this.butquizcap3.Name = "butquizcap3";
            this.butquizcap3.Size = new System.Drawing.Size(75, 23);
            this.butquizcap3.TabIndex = 8;
            this.butquizcap3.Text = "Quiz";
            this.butquizcap3.UseVisualStyleBackColor = false;
            this.butquizcap3.Click += new System.EventHandler(this.Butquizcap3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(408, 285);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 167);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
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
            this.Timp.Location = new System.Drawing.Point(125, 435);
            this.Timp.Name = "Timp";
            this.Timp.Size = new System.Drawing.Size(0, 17);
            this.Timp.TabIndex = 13;
            // 
            // OraText
            // 
            this.OraText.AutoSize = true;
            this.OraText.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.OraText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.OraText.Location = new System.Drawing.Point(93, 435);
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
            this.Data.Location = new System.Drawing.Point(93, 418);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(46, 17);
            this.Data.TabIndex = 11;
            this.Data.Text = "Data: ";
            // 
            // Cap3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.Timp);
            this.Controls.Add(this.OraText);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.butquizcap3);
            this.Controls.Add(this.butinapoicap3);
            this.Controls.Add(this.butinchidecap3);
            this.Controls.Add(this.richTextBoxCap3);
            this.Name = "Cap3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mamiferele";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxCap3;
        private System.Windows.Forms.Button butinchidecap3;
        private System.Windows.Forms.Button butinapoicap3;
        private System.Windows.Forms.Button butquizcap3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timerDataSiOra;
        private System.Windows.Forms.Label Timp;
        private System.Windows.Forms.Label OraText;
        private System.Windows.Forms.Label Data;
    }
}