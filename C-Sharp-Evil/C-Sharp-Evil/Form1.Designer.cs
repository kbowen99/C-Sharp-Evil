namespace C_Sharp_Evil
{
    partial class Evil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Evil));
            this.picPong = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPong)).BeginInit();
            this.SuspendLayout();
            // 
            // picPong
            // 
            this.picPong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picPong.Image = global::C_Sharp_Evil.Properties.Resources.pong;
            this.picPong.Location = new System.Drawing.Point(0, 0);
            this.picPong.Name = "picPong";
            this.picPong.Size = new System.Drawing.Size(984, 461);
            this.picPong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPong.TabIndex = 0;
            this.picPong.TabStop = false;
            this.picPong.Click += new System.EventHandler(this.picPong_Click);
            // 
            // Evil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.picPong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Evil";
            this.Text = "Pong";
            ((System.ComponentModel.ISupportInitialize)(this.picPong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picPong;
    }
}

