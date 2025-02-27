using MyLib;
using MyLib.Models;
using MyLib.Presenter;
using MyLib.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MyLib.Presenter.userpresenter;

namespace MyMVP
{
    public partial class DataTable : Form, Iusersview
    {
        userpresenter presenter_;
        public DataTable()
        {
            InitializeComponent();
            presenter_ = new userpresenter(new MemoryUsersModel(), this, UserCard);

        }

        public int GetIndexSelected()
        {
            return UserTable.CurrentCell.RowIndex;
        }

        public void ShowUsers(List<User> users)
        {
            MessageBox.Show($"{users.Count}");
            UserTable.DataSource = null;
            UserTable.DataSource = users;
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            string filterText = TextBoxFilter.Text.Trim().ToLower();
            MessageBox.Show(filterText);


            presenter_.FiltrName(filterText);
        }

        private void DataTable_Load(object sender, EventArgs e)
        {

        }

        private void UserTable_SelectionChanged(object sender, EventArgs e)
        {
            presenter_.SelectUser(GetIndexSelected());
        }

        private void UserCard_Load(object sender, EventArgs e)
        {

        }
    }
}
