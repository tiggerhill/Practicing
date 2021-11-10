namespace Practicing
{
    partial class frmGaussAddition
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
            this.lnkGauss = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGaussCalc = new System.Windows.Forms.Button();
            this.txtGaussEnding = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGaussBeginning = new System.Windows.Forms.TextBox();
            this.tboxGauss = new System.Windows.Forms.TextBox();
            this.btnCodeGauss = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGauss)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBoxGauss
            // 
            this.picBoxGauss.Image = global::Practicing.Properties.Resources.Gauss;
            this.picBoxGauss.Location = new System.Drawing.Point(12, 12);
            this.picBoxGauss.Name = "picBoxGauss";
            this.picBoxGauss.Size = new System.Drawing.Size(685, 964);
            this.picBoxGauss.TabIndex = 1;
            this.picBoxGauss.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(718, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 100);
            this.label1.TabIndex = 2;
            this.label1.Text = "Another one I really enjoyed doing.  Actually, the\r\ncoding was pretty easy, once " +
    "I learned (I did watch\r\nthe video) how the formula works.\r\n\r\nFun!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lnkGauss
            // 
            this.lnkGauss.AutoSize = true;
            this.lnkGauss.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkGauss.Location = new System.Drawing.Point(819, 132);
            this.lnkGauss.Name = "lnkGauss";
            this.lnkGauss.Size = new System.Drawing.Size(174, 20);
            this.lnkGauss.TabIndex = 3;
            this.lnkGauss.TabStop = true;
            this.lnkGauss.Text = "Gauss\'s Addition Video";
            this.lnkGauss.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkGauss_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnGaussCalc);
            this.groupBox1.Controls.Add(this.txtGaussEnding);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtGaussBeginning);
            this.groupBox1.Location = new System.Drawing.Point(728, 180);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 210);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(91, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Ending:";
            // 
            // btnGaussCalc
            // 
            this.btnGaussCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGaussCalc.Location = new System.Drawing.Point(123, 159);
            this.btnGaussCalc.Name = "btnGaussCalc";
            this.btnGaussCalc.Size = new System.Drawing.Size(129, 30);
            this.btnGaussCalc.TabIndex = 9;
            this.btnGaussCalc.Text = "Calculate";
            this.btnGaussCalc.UseVisualStyleBackColor = true;
            this.btnGaussCalc.Click += new System.EventHandler(this.btnGaussCalc_Click);
            // 
            // txtGaussEnding
            // 
            this.txtGaussEnding.AcceptsReturn = true;
            this.txtGaussEnding.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGaussEnding.Location = new System.Drawing.Point(173, 111);
            this.txtGaussEnding.Name = "txtGaussEnding";
            this.txtGaussEnding.Size = new System.Drawing.Size(100, 26);
            this.txtGaussEnding.TabIndex = 13;
            this.txtGaussEnding.Text = "10";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(317, 40);
            this.label5.TabIndex = 10;
            this.label5.Text = "Input two numbers\r\n(or just the ending number if starting from 1)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(70, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Beginning:";
            // 
            // txtGaussBeginning
            // 
            this.txtGaussBeginning.AcceptsReturn = true;
            this.txtGaussBeginning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGaussBeginning.Location = new System.Drawing.Point(173, 70);
            this.txtGaussBeginning.Name = "txtGaussBeginning";
            this.txtGaussBeginning.Size = new System.Drawing.Size(100, 26);
            this.txtGaussBeginning.TabIndex = 11;
            // 
            // tboxGauss
            // 
            this.tboxGauss.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxGauss.Location = new System.Drawing.Point(750, 417);
            this.tboxGauss.Multiline = true;
            this.tboxGauss.Name = "tboxGauss";
            this.tboxGauss.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tboxGauss.Size = new System.Drawing.Size(312, 114);
            this.tboxGauss.TabIndex = 10;
            this.tboxGauss.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tboxGauss.WordWrap = false;
            // 
            // btnCodeGauss
            // 
            this.btnCodeGauss.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCodeGauss.Location = new System.Drawing.Point(851, 558);
            this.btnCodeGauss.Name = "btnCodeGauss";
            this.btnCodeGauss.Size = new System.Drawing.Size(129, 30);
            this.btnCodeGauss.TabIndex = 11;
            this.btnCodeGauss.Text = "Look at Code";
            this.btnCodeGauss.UseVisualStyleBackColor = true;
            this.btnCodeGauss.Click += new System.EventHandler(this.btnCodeGauss_Click);
            // 
            // frmGaussAddition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 978);
            this.Controls.Add(this.btnCodeGauss);
            this.Controls.Add(this.tboxGauss);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lnkGauss);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBoxGauss);
            this.Name = "frmGaussAddition";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGaussAddition";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGauss)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picBoxGauss;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lnkGauss;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGaussCalc;
        private System.Windows.Forms.TextBox txtGaussEnding;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGaussBeginning;
        private System.Windows.Forms.TextBox tboxGauss;
        private System.Windows.Forms.Button btnCodeGauss;
    }
}