namespace AtestatInformatica_AdamPaul
{
    partial class Cap2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cap2));
            this.richTextBoxCap2 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.butquizcap2 = new System.Windows.Forms.Button();
            this.butinapoicap2 = new System.Windows.Forms.Button();
            this.butinchidecap2 = new System.Windows.Forms.Button();
            this.timerDataSiOra = new System.Windows.Forms.Timer(this.components);
            this.Timp = new System.Windows.Forms.Label();
            this.OraText = new System.Windows.Forms.Label();
            this.Data = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBoxCap2
            // 
            this.richTextBoxCap2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.richTextBoxCap2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxCap2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.richTextBoxCap2.Location = new System.Drawing.Point(-2, -3);
            this.richTextBoxCap2.Name = "richTextBoxCap2";
            this.richTextBoxCap2.ReadOnly = true;
            this.richTextBoxCap2.Size = new System.Drawing.Size(805, 465);
            this.richTextBoxCap2.TabIndex = 1;
            this.richTextBoxCap2.Text = resources.GetString("richTextBoxCap2.Text");
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(439, 201);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(306, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // butquizcap2
            // 
            this.butquizcap2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butquizcap2.BackgroundImage")));
            this.butquizcap2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.butquizcap2.Location = new System.Drawing.Point(359, 412);
            this.butquizcap2.Name = "butquizcap2";
            this.butquizcap2.Size = new System.Drawing.Size(75, 23);
            this.butquizcap2.TabIndex = 5;
            this.butquizcap2.Text = "Quiz";
            this.butquizcap2.UseVisualStyleBackColor = true;
            this.butquizcap2.Click += new System.EventHandler(this.Butquizcap2_Click);
            // 
            // butinapoicap2
            // 
            this.butinapoicap2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butinapoicap2.BackgroundImage")));
            this.butinapoicap2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.butinapoicap2.Location = new System.Drawing.Point(12, 412);
            this.butinapoicap2.Name = "butinapoicap2";
            this.butinapoicap2.Size = new System.Drawing.Size(75, 23);
            this.butinapoicap2.TabIndex = 6;
            this.butinapoicap2.Text = "Înapoi";
            this.butinapoicap2.UseVisualStyleBackColor = true;
            this.butinapoicap2.Click += new System.EventHandler(this.Butinapoicap2_Click);
            // 
            // butinchidecap2
            // 
            this.butinchidecap2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butinchidecap2.BackgroundImage")));
            this.butinchidecap2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.butinchidecap2.Location = new System.Drawing.Point(713, 412);
            this.butinchidecap2.Name = "butinchidecap2";
            this.butinchidecap2.Size = new System.Drawing.Size(75, 23);
            this.butinchidecap2.TabIndex = 7;
            this.butinchidecap2.Text = "Închide";
            this.butinchidecap2.UseVisualStyleBackColor = true;
            this.butinchidecap2.Click += new System.EventHandler(this.Butinchidecap2_Click);
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
            // Cap2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.Timp);
            this.Controls.Add(this.OraText);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.butinchidecap2);
            this.Controls.Add(this.butinapoicap2);
            this.Controls.Add(this.butquizcap2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.richTextBoxCap2);
            this.Name = "Cap2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistemul solar";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxCap2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button butquizcap2;
        private System.Windows.Forms.Button butinapoicap2;
        private System.Windows.Forms.Button butinchidecap2;
        private System.Windows.Forms.Timer timerDataSiOra;
        private System.Windows.Forms.Label Timp;
        private System.Windows.Forms.Label OraText;
        private System.Windows.Forms.Label Data;
    }
}