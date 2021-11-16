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
    public partial class frmAvgWordLength : Form
    {
        public frmAvgWordLength()
        {
            InitializeComponent();
        }

        private void btnCalculateAverage_Click(object sender, EventArgs e)
        {
            String str = txtSentence.Text;
            double answer = AverageWordLength(str);
            txtResult.Text = ("The avg. length of words in your sentence \n " + "is " + answer);
        }

        private static double AverageWordLength(string str)
        {
            string[] words = str.Split(new char[] { ' ' });
            int[] wordLength = new int[words.Length];
            int sum = 0;

            for (int i = 0; i < words.Length; i++)
            {
                foreach (char c in words[i])
                {
                    if (Char.IsPunctuation(c))
                    {
                        wordLength[i] += 0; // just to put something here
                    }
                    else
                    {
                        wordLength[i] += 1;
                    }
                }
            }

            for (int i = 0; i < words.Length; i++)
            {
                sum += wordLength[i];
            }

            double average = Math.Round((double)sum / words.Length, 2);
            return average;
        }
    }
}
