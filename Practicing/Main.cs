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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void lnkCreateFrame_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPictureFrame frmPictureFrame = new frmPictureFrame();
            frmPictureFrame.ShowDialog();
        }

        private void lnkGauss_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmGaussAddition frmGaussAddition = new frmGaussAddition();
            frmGaussAddition.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://edabit.com/user/9JxrMpYjPTwRisk2J");
        }

        private void lnkCupSwapping_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCupSwapping frmCup = new frmCupSwapping();
            frmCup.ShowDialog();
        }

        private void lnkEnding_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCommonEnding frmCommonEnding = new frmCommonEnding();
            frmCommonEnding.ShowDialog();
        }

        private void lnkSmooth_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSmoothSentences frm = new frmSmoothSentences();
            frm.ShowDialog();
        }

        private void lnkPerfect_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPerfectOrAmicable frm = new frmPerfectOrAmicable();
            frm.ShowDialog();
        }

        private void lnkBridge_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmBrokenBridge frm = new frmBrokenBridge();
            frm.ShowDialog();
        }
    }
}
