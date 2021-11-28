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
    public partial class frmCommonEnding : Form
    {
        public frmCommonEnding()
        {
            InitializeComponent();
        }

        // Write a function that returns the longest common ending between two strings.
        // Return an empty string if there exists no common ending.

        private void btnCodeGauss_Click(object sender, EventArgs e)
        {
            frmCodeCommon frm = new frmCodeCommon();
            frm.ShowDialog();
        }

        private void btnCommonEnding_Click(object sender, EventArgs e)
        {
            string strA, strB, strCommon = "";
            try
            {
                strA = txtStr1.ToString();
                strB = txtStr2.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Please check your entries.", "Error");
                return;
            }

            strCommon = LongestCommonEnding(strA, strB, strCommon);

            txtCommonEnding.Text = strCommon;
        }

        private static string LongestCommonEnding(string strA, string strB, string strCommon)
        {
            int count = 1;

            while ((count <= strA.Length && count <= strB.Length) &&
            (strA[strA.Length - count]) == (strB[strB.Length - count]))
            {
                strCommon += strA[strA.Length - count];
                count++;
            }

            char[] ch = strCommon.ToCharArray();
            Array.Reverse(ch);
            strCommon = new string(ch);

            return strCommon;
        }
    }
}
