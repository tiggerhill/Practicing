namespace Practicing
{
    partial class frmPerfectOrAmicable
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
            this.picBoxFrame = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPerfectAmicable = new System.Windows.Forms.Button();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFrame)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBoxFrame
            // 
            this.picBoxFrame.Image = global::Practicing.Properties.Resources.perfectAmicable;
            this.picBoxFrame.Location = new System.Drawing.Point(55, 12);
            this.picBoxFrame.Name = "picBoxFrame";
            this.picBoxFrame.Size = new System.Drawing.Size(685, 584);
            this.picBoxFrame.TabIndex = 2;
            this.picBoxFrame.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtResult);
            this.groupBox1.Controls.Add(this.btnPerfectAmicable);
            this.groupBox1.Controls.Add(this.txtNumber);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(258, 612);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 219);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // btnPerfectAmicable
            // 
            this.btnPerfectAmicable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerfectAmicable.Location = new System.Drawing.Point(191, 74);
            this.btnPerfectAmicable.Name = "btnPerfectAmicable";
            this.btnPerfectAmicable.Size = new System.Drawing.Size(74, 30);
            this.btnPerfectAmicable.TabIndex = 9;
            this.btnPerfectAmicable.Text = "Process";
            this.btnPerfectAmicable.UseVisualStyleBackColor = true;
            this.btnPerfectAmicable.Click += new System.EventHandler(this.btnPerfectAmicable_Click);
            // 
            // txtNumber
            // 
            this.txtNumber.AcceptsReturn = true;
            this.txtNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber.Location = new System.Drawing.Point(191, 27);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(74, 26);
            this.txtNumber.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Input Number:";
            // 
            // txtResult
            // 
            this.txtResult.AcceptsReturn = true;
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(36, 162);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(258, 26);
            this.txtResult.TabIndex = 10;
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Result:";
            // 
            // frmPerfectOrAmicable
            // 
            this.AcceptButton = this.btnPerfectAmicable;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 870);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picBoxFrame);
            this.Name = "frmPerfectOrAmicable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPerfectOrAmicable";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFrame)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxFrame;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPerfectAmicable;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtResult;
    }
}