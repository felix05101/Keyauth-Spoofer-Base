using System.Windows;
using System;
using System.Windows.Input;
using System.Threading.Tasks;
using KeyAuth;
using System.Threading;
using System.IO;
using System.Reflection;


namespace WpfApp1
{
    public partial class Register : Window
    {

        public static api KeyAuthApp = new api(
    name: "Temp Spoofer",
    ownerid: "7MXJE4V6xa",
    secret: "1ce81ba6d76f5a25a15b2775210824bba7700875924b1f9602435828535a0236",
    version: "1.1"
);

        private Spoofer spooferWindow;

        public Register()
        {

            KeyAuthApp.init();
            if (!KeyAuthApp.response.success)
            {
                Console.WriteLine("\n Status: " + KeyAuthApp.response.message);
                Thread.Sleep(2500);
                Environment.Exit(0);
            }

            InitializeComponent();


        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            KeyAuthApp.register(username.Text, password.Text, key.Text);
            if (KeyAuthApp.response.success)
            {
                double originalLeft = Left;
                double originalTop = Top;


                await Task.Delay(1500);

                spooferWindow.Left = originalLeft;
                spooferWindow.Top = originalTop;
                spooferWindow.Show();
                Hide();
            }
            else
                status.Text = "Status: " + KeyAuthApp.response.message;
        }

        private void TopBar_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void Exit_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Hide();
            Environment.Exit(0);
        }
    }
}
