using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicing
{
    public partial class frmGaussAddition : Form
    {
        public frmGaussAddition()
        {
            InitializeComponent();
        }

        private void lnkGauss_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=arf8wDP_MJE");
        }

        private void btnGaussCalc_Click(object sender, EventArgs e)
        {
            long a, b;

            if (txtGaussBeginning.Text.Trim() == string.Empty)
            {
                a = 1;
                try
                {
                    {
                        b = Convert.ToInt64(txtGaussEnding.Text);
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Please check your entries.", "Error");
                    return;
                }
            }
            else
            {
                try
                {
                    {
                        a = Convert.ToInt64(txtGaussBeginning.Text);
                        b = Convert.ToInt64(txtGaussEnding.Text);
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Please check your entries.", "Error");
                    return;
                }
            }
            long answer = Gauss(new long[] { a, b });
            
            string str = "";
            if (a < b) { str += "For the numbers " + a + " and " + b + "\r\n"; }
            else { str += "For the numbers " + b + " and " + a + "\r\n"; }            
            str += "The answer is " + answer;
            tboxGauss.Text = str;
        }
        public static long Gauss(long[] arr)
        {
            long start, end, result;
            
            Array.Sort(arr);
            start = arr[0];
            end = arr[1];
            
            result = ((long)((start + end) * ((end - start + 1) * .5)));
            return result;
        }

        private void btnCodeGauss_Click(object sender, EventArgs e)
        {
            frmCodeGauss frmCodeGauss = new frmCodeGauss();
            frmCodeGauss.ShowDialog();
        }
    }
}
