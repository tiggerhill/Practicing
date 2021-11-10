namespace Practicing
{
    partial class frmSmoothSentences
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSmoothOrNot = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSmoothOrNotSentence = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCodeSmooth = new System.Windows.Forms.Button();
            this.picBoxGauss = new System.Windows.Forms.PictureBox();
            this.txtSmoothOrNot = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGauss)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSmoothOrNot);
            this.groupBox1.Controls.Add(this.btnSmoothOrNot);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtSmoothOrNotSentence);
            this.groupBox1.Location = new System.Drawing.Point(717, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 287);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // btnSmoothOrNot
            // 
            this.btnSmoothOrNot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSmoothOrNot.Location = new System.Drawing.Point(150, 179);
            this.btnSmoothOrNot.Name = "btnSmoothOrNot";
            this.btnSmoothOrNot.Size = new System.Drawing.Size(129, 30);
            this.btnSmoothOrNot.TabIndex = 9;
            this.btnSmoothOrNot.Text = "Smooth or Not?";
            this.btnSmoothOrNot.UseVisualStyleBackColor = true;
            this.btnSmoothOrNot.Click += new System.EventHandler(this.btnSmoothOrNot_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(81, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(267, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Input sentence, without punctuation:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSmoothOrNotSentence
            // 
            this.txtSmoothOrNotSentence.AcceptsReturn = true;
            this.txtSmoothOrNotSentence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSmoothOrNotSentence.Location = new System.Drawing.Point(99, 69);
            this.txtSmoothOrNotSentence.Multiline = true;
            this.txtSmoothOrNotSentence.Name = "txtSmoothOrNotSentence";
            this.txtSmoothOrNotSentence.Size = new System.Drawing.Size(233, 85);
            this.txtSmoothOrNotSentence.TabIndex = 11;
            this.txtSmoothOrNotSentence.Text = "Marta appreciated deep perpendicular right trapezoids";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(747, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(353, 40);
            this.label2.TabIndex = 11;
            this.label2.Text = "I didn\'t use Regex or Linq on this, just the logic of\r\nif / else statements.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCodeSmooth
            // 
            this.btnCodeSmooth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCodeSmooth.Location = new System.Drawing.Point(867, 490);
            this.btnCodeSmooth.Name = "btnCodeSmooth";
            this.btnCodeSmooth.Size = new System.Drawing.Size(129, 30);
            this.btnCodeSmooth.TabIndex = 13;
            this.btnCodeSmooth.Text = "Look at Code";
            this.btnCodeSmooth.UseVisualStyleBackColor = true;
            this.btnCodeSmooth.Click += new System.EventHandler(this.btnCodeSmooth_Click);
            // 
            // picBoxGauss
            // 
            this.picBoxGauss.Image = global::Practicing.Properties.Resources.smoothSentences;
            this.picBoxGauss.Location = new System.Drawing.Point(12, 12);
            this.picBoxGauss.Name = "picBoxGauss";
            this.picBoxGauss.Size = new System.Drawing.Size(685, 724);
            this.picBoxGauss.TabIndex = 3;
            this.picBoxGauss.TabStop = false;
            // 
            // txtSmoothOrNot
            // 
            this.txtSmoothOrNot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSmoothOrNot.Location = new System.Drawing.Point(166, 233);
            this.txtSmoothOrNot.Name = "txtSmoothOrNot";
            this.txtSmoothOrNot.Size = new System.Drawing.Size(100, 26);
            this.txtSmoothOrNot.TabIndex = 13;
            this.txtSmoothOrNot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmSmoothSentences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 780);
            this.Controls.Add(this.btnCodeSmooth);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picBoxGauss);
            this.Name = "frmSmoothSentences";
            this.Text = "frmSmoothSentences";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGauss)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxGauss;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSmoothOrNot;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSmoothOrNotSentence;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCodeSmooth;
        private System.Windows.Forms.TextBox txtSmoothOrNot;
    }
}