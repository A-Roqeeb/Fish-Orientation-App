
namespace View
{
    partial class CollectionView
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
            this.SelectImage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SelectImage
            // 
            this.SelectImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.SelectImage.Location = new System.Drawing.Point(12, 12);
            this.SelectImage.Name = "SelectImage";
            this.SelectImage.Size = new System.Drawing.Size(201, 92);
            this.SelectImage.TabIndex = 7;
            this.SelectImage.Text = "Select Image";
            this.SelectImage.UseVisualStyleBackColor = false;
            this.SelectImage.Click += new System.EventHandler(this.SelectImage_Click);
            // 
            // CollectionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(225, 114);
            this.Controls.Add(this.SelectImage);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CollectionView";
            this.Text = "CollectionView";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button SelectImage;
    }
}

