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


        public userpresenter(Iusersmodel m, Iusersview v) 
        { 
            model_ = m;
            view_ = v;
            model_.DataChanged += Model__DataChanged;
            model_.LoadInForUsers();
        }

        private void Model__DataChanged()
        {
            view_.ShowUsers(model_.GetUsers());

        }
        public void FiltrName(string name)
        {
            model_.FiltrByName(name);
        }
    }
}
