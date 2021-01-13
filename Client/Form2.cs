using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class connectForm : Form
    {
        public connectForm()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_userName.Text))
            {
                MessageBox.Show("你還沒輸入用戶名稱", "警告");
                return;
            }
            Form1.Instance.serverIP = tbIP.Text;
            Form1.Instance.serverPort = tbPort.Text;
            Form1.Instance.userName = tb_userName.Text;
            Form1.Instance.showUserName();
            Form1.Instance.connect = true;
            Form1.Instance.isConnect();
            this.Close();
        }
    }
}
