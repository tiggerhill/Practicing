using System;
using System.IO;
using System.Windows.Forms;

namespace Practicing
{
    public partial class frmPictureFrame : Form
    {
        public frmPictureFrame()
        {
            InitializeComponent();
        }

        private void btnCreateFrame_Click(object sender, EventArgs e)
        {
            int w, h;
            char c;

            try
            {
                w = Convert.ToInt32(txtWidth.Text);
                h = Convert.ToInt32(txtHeight.Text);
                c = Convert.ToChar(txtChar.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Please check your entries", "Error");
                return;
            }
            string[] result = GetFrame(w, h, c);

            string str = "";
            foreach (var item in result)
            {
                str = str + item + "\r\n";
            }

            tboxFrame.Text = str;
        }

        public static string[] GetFrame(int w, int h, char c)
        {
            string[] result = new string[h];
            string[,] frameRows = new string[h, w];
            if (h < 3 || w < 3)
            {
                result[0] = "invalid";
                MessageBox.Show("Width and Height must be at least 3", "Invalid");
                return result;
            }
            else
            {
                for (int height = 0; height < h; height++)
                {
                    for (int width = 0; width < w; width++)
                    {
                        if (width == 0 || width == w - 1)
                        {
                            frameRows[height, width] += c;
                        }
                        else if (height == 0 || height == h - 1)
                        {
                            frameRows[height, width] += c;
                        }
                        else
                        {
                            frameRows[height, width] += " ";
                        }
                    }
                }
            }

            // convert [,] to []
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    result[i] += frameRows[i, j];
                }
            }           
            
            return result;
        }

        private void btnCodeFrame_Click(object sender, EventArgs e)
        {
            frmCodeFrame frmCodeFrame = new frmCodeFrame();
            frmCodeFrame.ShowDialog();
        }
    }
}
