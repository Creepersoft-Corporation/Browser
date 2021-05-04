using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Browser_Test_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            wB1.Url = new Uri("http://www.google.co.jp");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        
        //ホーム
        private void btnHome_Click(object sender, EventArgs e)
        {
            wB1.Url = new Uri("http://www.google.co.jp");
        }

        //戻る
        private void btnBack_Click(object sender, EventArgs e)
        {
            wB1.GoBack();
        }

        //進む
        private void btnNext_Click(object sender, EventArgs e)
        {
            wB1.GoForward();
        }

        private void wB1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        //ページが移動した後のイベント
        private void wB1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            texturl.Text = wB1.Url.ToString();

            btnBack.Enabled = wB1.CanGoBack;
            btnNext.Enabled = wB1.CanGoForward;

        }

        private void texturl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter)) {
                wB1.Url = new Uri(texturl.Text);
            }
        }
    }
}
