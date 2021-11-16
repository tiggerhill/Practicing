namespace Practicing
{
    partial class frmAvgWordLength
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAvgWordLength));
            this.picBrokenBridge = new System.Windows.Forms.PictureBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCalculateAverage = new System.Windows.Forms.Button();
            this.txtSentence = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBrokenBridge)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBrokenBridge
            // 
            this.picBrokenBridge.Image = global::Practicing.Properties.Resources.avgWordLength;
            this.picBrokenBridge.InitialImage = ((System.Drawing.Image)(resources.GetObject("picBrokenBridge.InitialImage")));
            this.picBrokenBridge.Location = new System.Drawing.Point(12, 12);
            this.picBrokenBridge.Name = "picBrokenBridge";
            this.picBrokenBridge.Size = new System.Drawing.Size(685, 437);
            this.picBrokenBridge.TabIndex = 5;
            this.picBrokenBridge.TabStop = false;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox3.Location = new System.Drawing.Point(12, 470);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox3.Size = new System.Drawing.Size(685, 152);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = resources.GetString("textBox3.Text");
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtResult);
            this.groupBox1.Controls.Add(this.btnCalculateAverage);
            this.groupBox1.Controls.Add(this.txtSentence);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(26, 628);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(648, 229);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // btnCalculateAverage
            // 
            this.btnCalculateAverage.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnCalculateAverage.FlatAppearance.BorderSize = 3;
            this.btnCalculateAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateAverage.Location = new System.Drawing.Point(200, 88);
            this.btnCalculateAverage.Name = "btnCalculateAverage";
            this.btnCalculateAverage.Size = new System.Drawing.Size(334, 30);
            this.btnCalculateAverage.TabIndex = 18;
            this.btnCalculateAverage.Text = "Calculate Average Word Length";
            this.btnCalculateAverage.UseVisualStyleBackColor = false;
            this.btnCalculateAverage.Click += new System.EventHandler(this.btnCalculateAverage_Click);
            // 
            // txtSentence
            // 
            this.txtSentence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSentence.Location = new System.Drawing.Point(200, 19);
            this.txtSentence.Name = "txtSentence";
            this.txtSentence.Size = new System.Drawing.Size(334, 26);
            this.txtSentence.TabIndex = 17;
            this.txtSentence.Text = "Having a blast partying in Las Vegas.";
            this.txtSentence.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Input Sentence:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(200, 144);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(334, 55);
            this.txtResult.TabIndex = 19;
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmAvgWordLength
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 894);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.picBrokenBridge);
            this.Name = "frmAvgWordLength";
            this.Text = "frmAvgWordLength";
            ((System.ComponentModel.ISupportInitialize)(this.picBrokenBridge)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBrokenBridge;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnCalculateAverage;
        private System.Windows.Forms.TextBox txtSentence;
        private System.Windows.Forms.Label label2;
    }
}