using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Web_Browser
{
    public partial class Browser : Form
    {
        public Browser()
        {
            InitializeComponent();
        }

        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
        }

        private void ts_btn_Back_Click(object sender, EventArgs e)
        {
            if (webBrowser.CanGoBack) { webBrowser.GoBack(); };
        }

        private void ts_btn_Forward_Click(object sender, EventArgs e)
        {
            if (webBrowser.CanGoForward) { webBrowser.GoForward(); }
        }

        private void ts_btn_Go_Click(object sender, EventArgs e)
        {
            string WebPage = ts_addressbar.Text.Trim();
            webBrowser.Navigate(WebPage);
        }

        private void ts_btn_Stop_Click(object sender, EventArgs e)
        {
            webBrowser.Stop();
        }

        private void ts_btn_Refresh_Click(object sender, EventArgs e)
        {
            webBrowser.Refresh();
        }

        private void ts_btn_Home_Click(object sender, EventArgs e)
        {
            webBrowser.GoHome();
        }

        private void PressEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string WebPage = ts_addressbar.Text.Trim();
                webBrowser.Navigate(WebPage);
            }
        }
    }
}