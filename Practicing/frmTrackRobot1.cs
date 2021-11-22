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
    public partial class frmTrackRobot1 : Form
    {
        public frmTrackRobot1()
        {
            InitializeComponent();
        }

        private void btnGaussCalc_Click(object sender, EventArgs e)
        {
            string[] instructions = new string[4];
            int r, u, l, d;
            try
            {
                r = Convert.ToInt16(txtRight.Text);
                u = Convert.ToInt16(txtUp.Text);
                l = Convert.ToInt16(txtLeft.Text);
                d = Convert.ToInt16(txtDown.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Please check your entries.", "Error");
                return;
            }

            instructions[0] = "right " + r;
            instructions[1] = "up " + u;
            instructions[2] = "left " + l;
            instructions[3] = "down " + d;

            /* I realize that is redundent, adding the "right, up, left, down" 
             * qualifiers, but originally this was a Console app, and the instructions 
             * asked that we determine movement directions based on those keywords
             * as part of the text array
             */

            int[] RobotPosition = TrackRobot(instructions);
            txtResults.Text = "[" + RobotPosition[0] + ", " + RobotPosition[1] + "]";
        }

        private static int[] TrackRobot(string[] instructions)
        {
            int[] result = new int[2];

            for (int i = 0; i < instructions.Length; i++)
            {
                string[] split = instructions[i].Split(' ');
                if (split[0] == "left") { result[0] -= int.Parse(split[1]); }
                else if (split[0] == "right") { result[0] += int.Parse(split[1]); }
                else if (split[0] == "up") { result[1] += int.Parse(split[1]); }
                else if (split[0] == "down") { result[1] -= int.Parse(split[1]); }
            }
            return result;
        }
    }
}
