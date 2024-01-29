using MonkyGame.Model;
using MonkyGame.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MonkyGame.View
{
    /// <summary>
    /// Interaction logic for SignUp.xaml
    /// </summary>
    public partial class SignUp : Window
    {
        Window window1;
        UserViewModel userModel;
        public SignUp(UserViewModel userModel, Window window1)
        {
            InitializeComponent();
            this.userModel = userModel;
            this.window1 = window1;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string Username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            string Email = EmailTextBox.Text;
            string FirstName = FirstNameTextBox.Text;
            string LastName = LastNameTextBox.Text;
            string Age = AgeTextBox.Text;
            if(Username != "" && Username != "")
            {
                User user = new User { UserName = Username, Age = Age, Email = Email, FirstName = FirstName, LastName = LastName, Password = password };
                userModel._UsersList.Add(user);
                usernameTextBox.BorderThickness = new Thickness(1);
                passwordTextBox.BorderThickness = new Thickness(1);
                usernameTextBox.BorderBrush = new SolidColorBrush(Colors.Black);
                passwordTextBox.BorderBrush = new SolidColorBrush(Colors.Black);
            }
            else
            {
                usernameTextBox.BorderThickness = new Thickness(2);
                passwordTextBox.BorderThickness = new Thickness(2);
                usernameTextBox.BorderBrush = new SolidColorBrush(Colors.Red);
                passwordTextBox.BorderBrush = new SolidColorBrush(Colors.Red);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            window1.Visibility = Visibility.Visible;
            this.Close();
        }
    }
}
