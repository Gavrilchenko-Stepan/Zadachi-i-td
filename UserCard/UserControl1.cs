using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLib.Views;
using MyLib;

namespace UserCard
{
    public partial class UserControl1: UserControl, iUserCard
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        public void Show(User u)
        {
            textName.Text = u.login;
            textEmail.Text = u.email;

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void textName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
