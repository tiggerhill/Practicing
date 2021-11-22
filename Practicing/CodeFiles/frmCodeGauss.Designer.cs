namespace Practicing
{
    partial class frmCodeGauss
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCodeGauss));
            this.tboxCodeGauss = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // tboxCodeGauss
            // 
            this.tboxCodeGauss.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tboxCodeGauss.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxCodeGauss.Location = new System.Drawing.Point(0, 0);
            this.tboxCodeGauss.Name = "tboxCodeGauss";
            this.tboxCodeGauss.ReadOnly = true;
            this.tboxCodeGauss.Size = new System.Drawing.Size(1025, 1109);
            this.tboxCodeGauss.TabIndex = 1;
            this.tboxCodeGauss.Text = resources.GetString("tboxCodeGauss.Text");
            // 
            // frmCodeGauss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 1109);
            this.Controls.Add(this.tboxCodeGauss);
            this.Name = "frmCodeGauss";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCodeGauss";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox tboxCodeGauss;
    }
}