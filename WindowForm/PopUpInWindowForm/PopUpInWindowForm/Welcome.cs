using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace PopUpInWindowForm
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PopupNotifier popup = new PopupNotifier();
            popup.TitleText = "Alert!";
            popup.ContentText = "This is Popup In Windows Form";
            popup.Popup();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }
    }
}
