using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using MyLib.Views;
using MyLib;
using System.Diagnostics.Eventing.Reader;

namespace UserCard
{
    public partial class UserControl1: UserControl, iUserCard
    {
        private string login_;
        public UserControl1()
        {
            InitializeComponent();
        }

        public event Action<User> DataUpdate;

        public void Show(User u)
        {
            textName.Text = u.username;
            textEmail.Text = u.email;
            login_ = u.login;

            pictureBox1.Image = Image.FromFile(u.avatarPath);
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void textName_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            User u = new User();
            u.username = textName.Text;
            u.email = textEmail.Text;
            u.login = login_;
            DataUpdate.Invoke(u);
        }
    }
}
