namespace QLPMT
{
    partial class UC_Home
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.picboxbackground = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picboxbackground)).BeginInit();
            this.SuspendLayout();
            // 
            // picboxbackground
            // 
            this.picboxbackground.BackColor = System.Drawing.Color.Aqua;
            this.picboxbackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picboxbackground.Image = global::QLPMT.Properties.Resources.bg_home;
            this.picboxbackground.Location = new System.Drawing.Point(0, 0);
            this.picboxbackground.Name = "picboxbackground";
            this.picboxbackground.Size = new System.Drawing.Size(981, 560);
            this.picboxbackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxbackground.TabIndex = 0;
            this.picboxbackground.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UC_Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.picboxbackground);
            this.Name = "UC_Home";
            this.Size = new System.Drawing.Size(981, 560);
            ((System.ComponentModel.ISupportInitialize)(this.picboxbackground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picboxbackground;
        private System.Windows.Forms.Timer timer1;
    }
}
