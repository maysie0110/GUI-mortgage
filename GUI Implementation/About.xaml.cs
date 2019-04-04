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

namespace GUI_Implementation
{
    /// <summary>
    /// Interaction logic for About.xaml
    /// </summary>
    public partial class About : Page
    {
        public About()
        {
            InitializeComponent();
        }


        private void Home_Click(object sender, RoutedEventArgs e)
        {
            HomePage home = new HomePage();
            this.NavigationService.Navigate(home);
        }

        private void CreateNew_Click(object sender, RoutedEventArgs e)
        {
            NewMortgageForm newForm = new NewMortgageForm();
            this.NavigationService.Navigate(newForm);

        }

        private void Open_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Help_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            string msgtext = "\t\tExit program?";
            string txt = "Close Application";

            MessageBoxButton button = MessageBoxButton.YesNoCancel;
            MessageBoxResult result = MessageBox.Show(msgtext, txt, button);

            switch (result)
            {
                case MessageBoxResult.Yes:
                    Application.Current.Shutdown();
                    break;
                case MessageBoxResult.No:
                    break;
                case MessageBoxResult.Cancel:
                    break;
            }
        }
        private void ContactUs_Click(object sender, RoutedEventArgs e)
        {
            About newAbout = new About();
            this.NavigationService.Navigate(newAbout);
        }
        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            HomePage home1 = new HomePage();
            this.NavigationService.Navigate(home1);
        }
    }
}
