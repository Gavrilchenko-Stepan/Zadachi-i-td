using MyLib.Models;
using MyLib.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib.Presenter
{
    public class userpresenter
    {
        Iusersmodel model_;
        Iusersview view_;
        iUserCard card_;


        public userpresenter(Iusersmodel m, Iusersview v, iUserCard c) 
        { 
            model_ = m;
            view_ = v;
            card_ = c;
            model_.DataChanged += Model__DataChanged;
            model_.LoadInForUsers();

            card_.DataUpdate += Card__DataUpdate;
        }

        private void Card__DataUpdate(User obj)
        {
            model_.ChangeUser(obj);
        }

        private void Model__DataChanged()
        {
            view_.ShowUsers(model_.GetUsers());

        }
        public void FiltrName(string name)
        {
            model_.FiltrByName(name);
        }

        public void SelectUser(int row)
        {
            User u = model_.GetUsers()[row];
            card_.Show(u);
        }
    }
}
