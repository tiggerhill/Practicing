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
    public partial class frmPerfectOrAmicable : Form
    {
        public frmPerfectOrAmicable()
        {
            InitializeComponent();
        }

        private void btnPerfectAmicable_Click(object sender, EventArgs e)
        {
            int num, sum;
            //string result;
            try
            {
                num = Convert.ToInt32(txtNumber.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Please check your entry.", "Error");
                return;
            }

            // Check if Perfect
            sum = CalcNum(num);
            if (sum == num)
            {
                txtResult.Text = (num.ToString() + " is perfect"); 
                return;
                //result = "Perfect";
            }

            // Check if Amicable
            int sum2 = CalcNum(sum);
            if (sum2 == num)
            {
                txtResult.Text = (num.ToString() + " is amicable with " + sum.ToString());
                return;
                //result = "Amicable";
            }

            txtResult.Text = (num.ToString() + " is neither");
            //result = "Neither";
        }
        private static int CalcNum(int num)
        {
            int sum = 0;
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }
    }
}
