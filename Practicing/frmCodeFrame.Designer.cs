namespace Practicing
{
    partial class frmCodeFrame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCodeFrame));
            this.tboxCodeFrame = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // tboxCodeFrame
            // 
            this.tboxCodeFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tboxCodeFrame.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxCodeFrame.Location = new System.Drawing.Point(0, 0);
            this.tboxCodeFrame.Name = "tboxCodeFrame";
            this.tboxCodeFrame.ReadOnly = true;
            this.tboxCodeFrame.Size = new System.Drawing.Size(800, 450);
            this.tboxCodeFrame.TabIndex = 0;
            this.tboxCodeFrame.Text = resources.GetString("tboxCodeFrame.Text");
            // 
            // frmCodeFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tboxCodeFrame);
            this.Name = "frmCodeFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCodeFrame";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox tboxCodeFrame;
    }
}