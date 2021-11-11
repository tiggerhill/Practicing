namespace Practicing
{
    partial class frmBrokenBridge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBrokenBridge));
            this.picBrokenBridge = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxCodeBrokenBridge = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBrokenBridge)).BeginInit();
            this.SuspendLayout();
            // 
            // picBrokenBridge
            // 
            this.picBrokenBridge.Image = global::Practicing.Properties.Resources.brokenBridge;
            this.picBrokenBridge.InitialImage = ((System.Drawing.Image)(resources.GetObject("picBrokenBridge.InitialImage")));
            this.picBrokenBridge.Location = new System.Drawing.Point(12, 12);
            this.picBrokenBridge.Name = "picBrokenBridge";
            this.picBrokenBridge.Size = new System.Drawing.Size(685, 736);
            this.picBrokenBridge.TabIndex = 4;
            this.picBrokenBridge.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(817, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(389, 40);
            this.label2.TabIndex = 12;
            this.label2.Text = "This one I found challenging, until I started thinking\r\nin the terms of DOES NOT " +
    "contain, DOES NOT equal.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tboxCodeBrokenBridge
            // 
            this.tboxCodeBrokenBridge.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxCodeBrokenBridge.Location = new System.Drawing.Point(703, 127);
            this.tboxCodeBrokenBridge.Name = "tboxCodeBrokenBridge";
            this.tboxCodeBrokenBridge.ReadOnly = true;
            this.tboxCodeBrokenBridge.Size = new System.Drawing.Size(630, 621);
            this.tboxCodeBrokenBridge.TabIndex = 13;
            this.tboxCodeBrokenBridge.Text = resources.GetString("tboxCodeBrokenBridge.Text");
            // 
            // frmBrokenBridge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 778);
            this.Controls.Add(this.tboxCodeBrokenBridge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picBrokenBridge);
            this.Name = "frmBrokenBridge";
            this.Text = "frmBrokenBridge";
            ((System.ComponentModel.ISupportInitialize)(this.picBrokenBridge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBrokenBridge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox tboxCodeBrokenBridge;
    }
}