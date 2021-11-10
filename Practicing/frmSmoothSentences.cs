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
    public partial class frmSmoothSentences : Form
    {
        public frmSmoothSentences()
        {
            InitializeComponent();
        }

        private void btnCodeSmooth_Click(object sender, EventArgs e)
        {
            frmCodeSmoothSentences frm = new frmCodeSmoothSentences();
            frm.ShowDialog();
        }

        private void btnSmoothOrNot_Click(object sender, EventArgs e)
        {
            string sentence = "";
            bool result;
            try
            {
                sentence = txtSmoothOrNotSentence.Text.ToLower().ToString();
                result = IsSmooth(sentence);
            }
            catch (Exception)
            {
                MessageBox.Show("Please check your entry.", "Error");
                return;
            }

            if (result == true)
            {
                txtSmoothOrNot.Text = "SMOOTH!!!";
            }
            else
            {
                txtSmoothOrNot.Text = "NOT!!!!!";
            }
        }
        public static bool IsSmooth(string sentence)
        {
            string[] words = sentence.Split(' ');
            string letter = words[0].Substring(words[0].Length - 1);

            for (int i = 1; i < words.Length; i++)
            {
                if (letter != words[i].Substring(0, 1))
                {
                    return false;
                }
                else
                {
                    letter = words[i].Substring(words[i].Length - 1);
                }
            }

            return true;
        }
    }
}
