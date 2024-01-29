using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkyGame.Model
{
    public class User : INotifyPropertyChanged
    {
        private string username;
        private string password;
        private string first_name;
        private string last_name;
        private string email;
        private string age;

        public string UserName
        {
            get { return username; }
            set 
            { 
                username = value;
                OnPropertyChanged("UserName");
            }
        }

        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                OnPropertyChanged("Password");
            }
        }

        public string FirstName
        {
            get { return first_name; }
            set
            {
                first_name = value;
                OnPropertyChanged("FirstName");
            }
        }

        public string LastName
        {
            get { return last_name; }
            set
            {
                last_name = value;
                OnPropertyChanged("LastName");
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                OnPropertyChanged("Email");
            }
        }

        public string Age
        {
            get { return age; }
            set
            {
                age = value;
                OnPropertyChanged("Age");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
