using MonkyGame.Model;
using MonkyGame.ViewModel;
using System;
using System.Collections.Generic;
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
    /// Interaction logic for LogIn.xaml
    /// </summary>
    public partial class LogIn : Window
    {
        private UserViewModel _userViewModel;

        public LogIn()
        {
            InitializeComponent();
            _userViewModel = new UserViewModel();
            DataContext = _userViewModel;
        }

        public void Check()
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //way to accses information in binding

            if (_userViewModel.Users[0].FirstName == "boss")
            {
                MessageBox.Show("yup");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            foreach (var user in _userViewModel.Users)
            {
                if(user.UserName == NameBox.Text && user.Password == PassBox.Text)
                {
                    Window mainwindow = new MainWindow(user.UserName);
                    mainwindow.Show();
                    this.Close();
                }
            }
            NameBox.BorderBrush = new SolidColorBrush(Colors.Red);
            NameBox.BorderThickness = new Thickness(2);
            PassBox.BorderBrush = new SolidColorBrush(Colors.Red);
            PassBox.BorderThickness = new Thickness(2);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            SignUp sign = new SignUp(_userViewModel, this);
            sign.Visibility = Visibility.Visible;
            this.Visibility = Visibility.Collapsed;
        }
    }
}
