using MonkyGame.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MonkyGame.ViewModel
{
    public class UserViewModel
    {
        public List<User> _UsersList;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void RefreshUsers()
        {
            // Don't need to reload data, just notify UI
            OnPropertyChanged(nameof(Users));
        }

        public UserViewModel()
        {
            _UsersList = new List<User>
            {
                new User {UserName = "babyman", Age = "1", Email = "bobo@gmail", FirstName = "boss", LastName = "baby", Password = "111" },
                new User { UserName = "test", Age = "1", Email = "bobo@gmail", FirstName = "subject", LastName = "baby", Password = "222" }
            };
        }

        public List<User> Users
        {
            get { return _UsersList; }
            set { _UsersList = value; }
        }
    }
}
