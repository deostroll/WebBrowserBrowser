using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrowserShell
{
    public partial class MockBrowserForm : Form
    {
        string _title = string.Empty;

        public MockBrowserForm()
        {
            InitializeComponent();
        }



        private void tbxUrl_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tbxUrl.Text.Trim().Length > 0)
                {
                    wbSurface.Navigate(tbxUrl.Text);
                }
            }
        }        

        private void wbSurface_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            tbxUrl.Text = wbSurface.Url.AbsoluteUri;
            Debug.Print("DocCompleted: {0}", wbSurface.Url);
            this.Text = string.Format("{0} - {1}", _title, wbSurface.Url.AbsoluteUri);
        }

        private void MockBrowserForm_Load(object sender, EventArgs e)
        {
            _title = this.Text;
        }
    }
}
