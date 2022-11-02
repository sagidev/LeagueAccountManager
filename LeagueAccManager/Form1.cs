using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeagueAccManager
{
    public partial class Form1 : MetroSetForm
    {
        public List<Account> accounts { get; set; }

        public Form1()
        {
            accounts = GetAccounts();
            InitializeComponent();
        }

        public List<Account> GetAccounts()
        {
            var list = new List<Account>();
            list.Add(new Account()
            {
                Login = "login",
                Rank = "plat",
                Nickname = "nick",
                Password = "pass",
                Server = "eune"
            });
            list.Add(new Account()
            {
                Login = "login1",
                Rank = "gold",
                Nickname = "nick1",
                Password = "pass1",
                Server = "eune"
            });
            list.Add(new Account()
            {
                Login = "login2",
                Nickname = "nick2",
                Password = "pass2",
                Server = "euw"
            });
            return list;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var acc = this.accounts;
            dataGridView1.DataSource = acc;
          
        }

        public void RefreshGrid()
        {
            var acc = this.accounts;
            dataGridView1.DataSource = acc;
        }

        private void metroSetTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroSetButton1_Click(object sender, EventArgs e)
        {
            accounts.Add(new Account()
            {
                Server = ServerBox.Text,
                Rank = RankBox.Text,
                Login = LoginTxt.Text,
                Password = PasswordTxt.Text,
                Nickname = NicknameTxt.Text,
                Smurfq = SmurfqBox.Checked
                
            });
            RefreshGrid();
        }

        private void metroSetButton3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
