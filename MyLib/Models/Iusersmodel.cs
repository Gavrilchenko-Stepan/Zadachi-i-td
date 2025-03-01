using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib.Models
{
    public interface Iusersmodel
    {
        List<User> GetUsers();

        void LoadInForUsers();
        event Action DataChanged;


        void FiltrByName(string name);

        void ChangeUser(User obj);
    }
}
