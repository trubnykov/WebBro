using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoBack)
            {
                webBrowser1.GoBack();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoForward)
            {
                webBrowser1.GoForward();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(URLtxt.Text);
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void URLtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == 13)
            {
                // webBrowser1.Navigate(URLtxt.Text);
                toolStripButton6.PerformClick();
            }
        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            try
            {
                BrowserProgressBar.Value = (Int32)e.CurrentProgress;
                BrowserProgressBar.Value = (Int32)e.MaximumProgress;
            }
            catch
            {

            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
