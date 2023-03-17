using Behavior;
using Infrastructure.clases;
using System;
using System.Text;
using System.Windows;


namespace EgaisMaster
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click_Close(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click_Minimals(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var user= UserBehavior.GetUser(login.Text);
            if(user != null) 
            {
                
                if(Encoding.UTF8.GetString(user.Password) ==Password.Password)
                {
                    Singleton.User = user;
                    CentralWindow centralWindow = new CentralWindow();
                    centralWindow.Show();
                    this.Close();
                    return;
                }
                
            }
            popup1.IsOpen = true;
        }      

        private void Window_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            DragMove();
        }
    }
}
