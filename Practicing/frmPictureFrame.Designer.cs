namespace Practicing
{
    partial class frmPictureFrame
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
            this.components = new System.ComponentModel.Container();
            this.picBoxFrame = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtChar = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCreateFrame = new System.Windows.Forms.Button();
            this.tboxFrame = new System.Windows.Forms.TextBox();
            this.btnCodeFrame = new System.Windows.Forms.Button();
            this.frmPictureFrameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFrame)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frmPictureFrameBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxFrame
            // 
            this.picBoxFrame.Image = global::Practicing.Properties.Resources.pictureFrame;
            this.picBoxFrame.Location = new System.Drawing.Point(12, 12);
            this.picBoxFrame.Name = "picBoxFrame";
            this.picBoxFrame.Size = new System.Drawing.Size(685, 713);
            this.picBoxFrame.TabIndex = 0;
            this.picBoxFrame.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(709, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 80);
            this.label1.TabIndex = 1;
            this.label1.Text = "I was uncertain how to do this directly into a\r\none-dimensional array, so I put t" +
    "he characters\r\ninto a two-dimensional array, which I then converted\r\nto a one-di" +
    "mensional.  I enjoyed this one!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Input width:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Input height:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Input character:";
            // 
            // txtWidth
            // 
            this.txtWidth.AcceptsReturn = true;
            this.txtWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWidth.Location = new System.Drawing.Point(165, 30);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(100, 26);
            this.txtWidth.TabIndex = 5;
            this.txtWidth.Text = "10";
            // 
            // txtHeight
            // 
            this.txtHeight.AcceptsReturn = true;
            this.txtHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeight.Location = new System.Drawing.Point(165, 68);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 26);
            this.txtHeight.TabIndex = 6;
            this.txtHeight.Text = "15";
            // 
            // txtChar
            // 
            this.txtChar.AcceptsReturn = true;
            this.txtChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChar.Location = new System.Drawing.Point(165, 107);
            this.txtChar.Name = "txtChar";
            this.txtChar.Size = new System.Drawing.Size(100, 26);
            this.txtChar.TabIndex = 7;
            this.txtChar.Text = "=";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCreateFrame);
            this.groupBox1.Controls.Add(this.txtWidth);
            this.groupBox1.Controls.Add(this.txtChar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtHeight);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(743, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 219);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // btnCreateFrame
            // 
            this.btnCreateFrame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateFrame.Location = new System.Drawing.Point(100, 159);
            this.btnCreateFrame.Name = "btnCreateFrame";
            this.btnCreateFrame.Size = new System.Drawing.Size(129, 30);
            this.btnCreateFrame.TabIndex = 9;
            this.btnCreateFrame.Text = "Create Frame";
            this.btnCreateFrame.UseVisualStyleBackColor = true;
            this.btnCreateFrame.Click += new System.EventHandler(this.btnCreateFrame_Click);
            // 
            // tboxFrame
            // 
            this.tboxFrame.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxFrame.Location = new System.Drawing.Point(743, 332);
            this.tboxFrame.Multiline = true;
            this.tboxFrame.Name = "tboxFrame";
            this.tboxFrame.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tboxFrame.Size = new System.Drawing.Size(312, 329);
            this.tboxFrame.TabIndex = 9;
            this.tboxFrame.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tboxFrame.WordWrap = false;
            // 
            // btnCodeFrame
            // 
            this.btnCodeFrame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCodeFrame.Location = new System.Drawing.Point(843, 695);
            this.btnCodeFrame.Name = "btnCodeFrame";
            this.btnCodeFrame.Size = new System.Drawing.Size(129, 30);
            this.btnCodeFrame.TabIndex = 10;
            this.btnCodeFrame.Text = "Look at Code";
            this.btnCodeFrame.UseVisualStyleBackColor = true;
            this.btnCodeFrame.Click += new System.EventHandler(this.btnCodeFrame_Click);
            // 
            // frmPictureFrameBindingSource
            // 
            this.frmPictureFrameBindingSource.DataSource = typeof(Practicing.frmPictureFrame);
            // 
            // frmPictureFrame
            // 
            this.AcceptButton = this.btnCreateFrame;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 747);
            this.Controls.Add(this.btnCodeFrame);
            this.Controls.Add(this.tboxFrame);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBoxFrame);
            this.Name = "frmPictureFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPictureFrame";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFrame)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frmPictureFrameBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxFrame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtChar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCreateFrame;
        private System.Windows.Forms.BindingSource frmPictureFrameBindingSource;
        private System.Windows.Forms.TextBox tboxFrame;
        private System.Windows.Forms.Button btnCodeFrame;
    }
}