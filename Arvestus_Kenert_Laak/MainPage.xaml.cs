using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace Arvestus_Kenert_Laak
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        int attempt = 3;
        public MainPage()
        {
            this.InitializeComponent();
        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {

            if (attempt > 1)
            {
                attempt--;
            }
            else
            {
                textblock1.Text = "Sisselogimiskatsed on otsas!";
                return;
            }

            string vastus;
            string kasutajanimi = textBox1.Text;
            string password = passwordBox1.Password;
            bool success = false;
            if (this.textBox1.Text == "user")
            {
                if (this.passwordBox1.Password == "SecretPassword")
                {
                    success = true;
                    vastus = "Sisselogimine õnnestus!";
                    this.Frame.Navigate(typeof(Content));
                }
                else
                {
                    vastus = "Vale parool,";
                }
            }
            else
            {
                vastus = "Vale kasutaja,";
            }
            if (!success && attempt > 1)
            {
                vastus += " Teil on veel " + Convert.ToString(attempt) + " katset järel!";
            }
            else if (!success && attempt == 1)
            {
                vastus += " Teil on viimane katse jäänud!";

            }


            textblock1.Text = vastus;
        }
    }
}