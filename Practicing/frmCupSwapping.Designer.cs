namespace Practicing
{
    partial class frmCupSwapping
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
            this.picBoxGauss = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCodeCups = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGauss)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxGauss
            // 
            this.picBoxGauss.Image = global::Practicing.Properties.Resources.cupSwapping;
            this.picBoxGauss.Location = new System.Drawing.Point(12, 12);
            this.picBoxGauss.Name = "picBoxGauss";
            this.picBoxGauss.Size = new System.Drawing.Size(681, 1179);
            this.picBoxGauss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBoxGauss.TabIndex = 2;
            this.picBoxGauss.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(730, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "This exercise was rated as \'hard\', but really, I thought\r\nit was fairly easy. ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCodeCups
            // 
            this.btnCodeCups.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCodeCups.Location = new System.Drawing.Point(857, 130);
            this.btnCodeCups.Name = "btnCodeCups";
            this.btnCodeCups.Size = new System.Drawing.Size(129, 30);
            this.btnCodeCups.TabIndex = 12;
            this.btnCodeCups.Text = "Look at Code";
            this.btnCodeCups.UseVisualStyleBackColor = true;
            this.btnCodeCups.Click += new System.EventHandler(this.btnCodeCups_Click);
            // 
            // frmCupSwapping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 1200);
            this.Controls.Add(this.btnCodeCups);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBoxGauss);
            this.Name = "frmCupSwapping";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCupSwapping";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGauss)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxGauss;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCodeCups;
    }
}