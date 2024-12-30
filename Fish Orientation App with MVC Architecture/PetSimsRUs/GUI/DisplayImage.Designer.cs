
namespace View
{
    partial class DisplayImage
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
            this.RotateImage = new System.Windows.Forms.Button();
            this.FlipImageH = new System.Windows.Forms.Button();
            this.PngImage = new System.Windows.Forms.PictureBox();
            this.DeleteImage = new System.Windows.Forms.Button();
            this.FlipImageV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PngImage)).BeginInit();
            this.SuspendLayout();
            // 
            // RotateImage
            // 
            this.RotateImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.RotateImage.Location = new System.Drawing.Point(12, 292);
            this.RotateImage.Name = "RotateImage";
            this.RotateImage.Size = new System.Drawing.Size(64, 64);
            this.RotateImage.TabIndex = 1;
            this.RotateImage.Text = "Rotate";
            this.RotateImage.UseVisualStyleBackColor = false;
            this.RotateImage.Click += new System.EventHandler(this.RotateImage_Click);
            // 
            // FlipImageH
            // 
            this.FlipImageH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.FlipImageH.Location = new System.Drawing.Point(152, 292);
            this.FlipImageH.Name = "FlipImageH";
            this.FlipImageH.Size = new System.Drawing.Size(64, 64);
            this.FlipImageH.TabIndex = 2;
            this.FlipImageH.Text = "FlipH";
            this.FlipImageH.UseVisualStyleBackColor = false;
            this.FlipImageH.Click += new System.EventHandler(this.FlipImageH_Click);
            // 
            // PngImage
            // 
            this.PngImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PngImage.Location = new System.Drawing.Point(7, 44);
            this.PngImage.Name = "PngImage";
            this.PngImage.Size = new System.Drawing.Size(340, 242);
            this.PngImage.TabIndex = 3;
            this.PngImage.TabStop = false;
            // 
            // DeleteImage
            // 
            this.DeleteImage.BackColor = System.Drawing.Color.Red;
            this.DeleteImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteImage.Location = new System.Drawing.Point(305, 9);
            this.DeleteImage.Name = "DeleteImage";
            this.DeleteImage.Size = new System.Drawing.Size(42, 29);
            this.DeleteImage.TabIndex = 4;
            this.DeleteImage.Text = "X";
            this.DeleteImage.UseVisualStyleBackColor = false;
            this.DeleteImage.Click += new System.EventHandler(this.DeleteImage_Click);
            // 
            // FlipImageV
            // 
            this.FlipImageV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.FlipImageV.Location = new System.Drawing.Point(283, 292);
            this.FlipImageV.Name = "FlipImageV";
            this.FlipImageV.Size = new System.Drawing.Size(64, 64);
            this.FlipImageV.TabIndex = 5;
            this.FlipImageV.Text = "FlipV";
            this.FlipImageV.UseVisualStyleBackColor = false;
            this.FlipImageV.Click += new System.EventHandler(this.FlipImageV_Click);
            // 
            // DisplayImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(355, 369);
            this.ControlBox = false;
            this.Controls.Add(this.FlipImageV);
            this.Controls.Add(this.DeleteImage);
            this.Controls.Add(this.PngImage);
            this.Controls.Add(this.FlipImageH);
            this.Controls.Add(this.RotateImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DisplayImage";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DisplayImage_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DisplayImage_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DisplayImage_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.PngImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button RotateImage;
        private System.Windows.Forms.Button FlipImageH;
        private System.Windows.Forms.PictureBox PngImage;
        private System.Windows.Forms.Button DeleteImage;
        private System.Windows.Forms.Button FlipImageV;
    }
}