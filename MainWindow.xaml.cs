using System;
using System.Windows;
using System.Windows.Input;
using System.Threading.Tasks;
using KeyAuth;
using System.Threading;


namespace WpfApp1
{



    public partial class MainWindow : Window
    {



        private bool mouseDown;
        private Point startPoint;

        public static api KeyAuthApp = new api(
            name: "Temp Spoofer",
            ownerid: "",
            secret: "",
            version: "1.1"
        );

        private Spoofer spooferWindow;
        private Register Register;

        public MainWindow()
        {
            Loaded += MainWindow_Loaded;

            KeyAuthApp.init();
            if (!KeyAuthApp.response.success)
            {
                Console.WriteLine("\n Status: " + KeyAuthApp.response.message);
                Thread.Sleep(2500);
                Environment.Exit(0);
            }

            InitializeComponent();

            spooferWindow = new Spoofer();
            Register = new Register();



        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            CenterWindowOnScreen();
        }



        private void CenterWindowOnScreen()
        {
            double screenWidth = SystemParameters.PrimaryScreenWidth;
            double screenHeight = SystemParameters.PrimaryScreenHeight;
            double windowWidth = Width;
            double windowHeight = Height;

            Left = (screenWidth - windowWidth) / 2;
            Top = (screenHeight - windowHeight) / 2;
        }


        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            KeyAuthApp.login(username.Text, password.Text);
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

        private void Rectangle_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Hide();
            Environment.Exit(0);
        }


        private void TopBar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void username_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }

        private void title_Copy1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void title_Copy1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            double originalLeft = Left;
            double originalTop = Top;
            Register.Left = originalLeft;
            Register.Top = originalTop;
            Register.Show();
            Hide();
        }
    }
}
