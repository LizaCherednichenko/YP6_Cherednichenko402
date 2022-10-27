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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace YP6_Cherednichenko402
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string u = username.Text;
            string p = password.Text;
            if (u == "" && p == "")
                MessageBox.Show("Enter username and password!", "Information");
            else if (u == "")
                MessageBox.Show("Enter username!", "Information");
            else if (p == "")
                MessageBox.Show("Enter password!", "Information");
            else if (u == "Admin" && p == "Admin")
                f1.Navigate(new Uri("Page1.xaml", UriKind.Relative));
            else if (u != "Admin" && u != "User")
                MessageBox.Show("User is not found!", "Information");
            else if (p != "Admin" && p != "User")
                MessageBox.Show("Password incorrect!", "Information");
            else if (u == "User" && p == "User")
                f1.Navigate(new Uri("Page2.xaml", UriKind.Relative));
            

        }

        
    }
}
