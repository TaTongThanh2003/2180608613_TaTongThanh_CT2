namespace _2180608613_TaTongThanh_CT2
{
    partial class ChillForm
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
            this.ptbHinhanh = new System.Windows.Forms.PictureBox();
            this.ptbHA = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHinhanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHA)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbHinhanh
            // 
            this.ptbHinhanh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbHinhanh.Location = new System.Drawing.Point(0, 0);
            this.ptbHinhanh.Name = "ptbHinhanh";
            this.ptbHinhanh.Size = new System.Drawing.Size(800, 450);
            this.ptbHinhanh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptbHinhanh.TabIndex = 0;
            this.ptbHinhanh.TabStop = false;
            // 
            // ptbHA
            // 
            this.ptbHA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbHA.Location = new System.Drawing.Point(0, 0);
            this.ptbHA.Name = "ptbHA";
            this.ptbHA.Size = new System.Drawing.Size(800, 450);
            this.ptbHA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptbHA.TabIndex = 1;
            this.ptbHA.TabStop = false;
            // 
            // ChillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ptbHA);
            this.Controls.Add(this.ptbHinhanh);
            this.Name = "ChillForm";
            this.Text = "ChillForm";
            ((System.ComponentModel.ISupportInitialize)(this.ptbHinhanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbHinhanh;
        private System.Windows.Forms.PictureBox ptbHA;
    }
}