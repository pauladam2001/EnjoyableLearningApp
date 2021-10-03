namespace AtestatInformatica_AdamPaul
{
    partial class MeniuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MeniuPrincipal));
            this.progressBarLoadScreen = new System.Windows.Forms.ProgressBar();
            this.TimerLoadScreen = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // progressBarLoadScreen
            // 
            this.progressBarLoadScreen.Location = new System.Drawing.Point(151, 340);
            this.progressBarLoadScreen.Name = "progressBarLoadScreen";
            this.progressBarLoadScreen.Size = new System.Drawing.Size(288, 23);
            this.progressBarLoadScreen.TabIndex = 0;
            // 
            // TimerLoadScreen
            // 
            this.TimerLoadScreen.Enabled = true;
            this.TimerLoadScreen.Interval = 20;
            this.TimerLoadScreen.Tick += new System.EventHandler(this.TimerLoadScreen_Tick);
            // 
            // MeniuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(596, 388);
            this.Controls.Add(this.progressBarLoadScreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MeniuPrincipal";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MeniuPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBarLoadScreen;
        private System.Windows.Forms.Timer TimerLoadScreen;
    }
}