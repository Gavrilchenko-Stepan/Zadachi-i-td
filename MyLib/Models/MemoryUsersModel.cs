using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace MyLib.Models
{
    public class MemoryUsersModel : Iusersmodel
    {
        List<User> users_ = new List<User>();
        List<User> filteredUsers = new List<User>();


        public event Action DataChanged;

        public List<User> GetUsers()
        {
            return filteredUsers;
        }

        public void LoadInForUsers()
        {

            users_.Add(new User { login = "Ad123", password = "1234", username = "Иванов Иван Иванович", dateBirth = new DateTime(2002, 08, 15), email = "ivanovI@gmail.com", avatarPath = "C:\\Image\\1.jpg" });
            users_.Add(new User { login = "Dfg11", password = "5678", username = "Петросян Дмитрий Петрович", dateBirth = new DateTime(1999, 05, 10), email = "petro123@gmail.com", avatarPath = "C:\\Image\\4.jpg" });
            users_.Add(new User { login = "Gal531", password = "9102", username = "Галузин Пётр Алексеевич", dateBirth = new DateTime(2005, 01, 04), email = "galuz34@yandex.ru", avatarPath = "C:\\Image\\1.jpg" });
            filteredUsers = new List<User>(users_);
            DataChanged.Invoke();
        }
        public void FiltrByName(string name)
        {
            //filteredUsers.Clear();

            List<User> newUsers = new List<User>();
            foreach (User user in users_)
            {
                if (user.username.ToLower().Contains(name.ToLower()))
                {
                    newUsers.Add(user);
                }
            }
            filteredUsers = newUsers;
            DataChanged.Invoke();
        }

        private void ChangeUser(User obj)
        {
            for(int intex = 0; intex < users_.Count; ++intex)
            {
                User user = users_.ElementAt(intex);
                if(obj.login == user.login)
                {
                    users_[intex].username = obj.username;
                    users_[intex].email = obj.email;
                }
            }
            DataChanged.Invoke();
        }

        void Iusersmodel.ChangeUser(User obj)
        {
            ChangeUser(obj);
        }

        public void AddUser(User newUser)
        {
            users_.Add(newUser);
            filteredUsers = new List<User>(users_);
            DataChanged?.Invoke();
        }

        public void RemoveUser(string login)
        {
            var userToRemove = users_.FirstOrDefault(u => u.login == login);
            if (userToRemove != null)
            {
                users_.Remove(userToRemove);
                filteredUsers = new List<User>(users_);
                DataChanged?.Invoke();
            }
        }
    }
}
