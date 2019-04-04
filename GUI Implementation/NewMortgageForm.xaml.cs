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
using System.Diagnostics;

namespace GUI_Implementation
{
    /// <summary>
    /// Interaction logic for NewMortgageForm.xaml
    /// </summary>
    public partial class NewMortgageForm : Page
    {
        public NewMortgageForm()
        {
            InitializeComponent();
            this.KeepAlive = true;
        }
        
        private void frequencyBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void rb1_Checked(object sender, RoutedEventArgs e)
        {
        }

        private void rb2_Checked(object sender, RoutedEventArgs e)
        {

        }


        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            var picker = sender as DatePicker;
            DateTime? date = picker.SelectedDate;

            if (date == null)
                this.Title = "No date";
            else
                this.Title = date.Value.ToShortDateString();
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


        private void Save_Click(object sender, RoutedEventArgs e)
        {

        }

        private void extra_Click(object sender, RoutedEventArgs e)
        {
            if (this.dueDateBox.SelectedDate == null || this.amountBox.Text == "" || this.interestBox.Text == "" || this.frequencyBox.SelectedIndex == -1 || this.rb1Box.Text == "" && this.rb2Box.Text == "")
            {
                string msgtext = "Cannot apply extra principle.\n\nEnter mortgage information for all required fields.";
                string txt = "Error";

                MessageBoxButton button = MessageBoxButton.OKCancel;
                MessageBoxResult result = MessageBox.Show(msgtext, txt, button);

                switch (result)
                {
                    case MessageBoxResult.OK:
                        break;

                    case MessageBoxResult.Cancel:
                        break;
                }

            }

            else
            {
                ExtraPrinciple extraForm = new ExtraPrinciple(this.amountBox.Text, this.interestBox.Text, this.frequencyBox.SelectionBoxItem, this.rb1Box.Text, this.rb2Box.Text, this.dueDateBox.SelectedDate);
                this.NavigationService.Navigate(extraForm);
            }
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            string msgtext = "Want to save your changes?";
            string txt = "Reset Application";
            
            MessageBoxButton button = MessageBoxButton.YesNoCancel;
            MessageBoxResult result = MessageBox.Show(msgtext, txt, button);

            switch (result)
            {
                case MessageBoxResult.Yes:Save_Click(sender, e);
                    break;
                case MessageBoxResult.No:Reset(sender, e);
                    break;
                case MessageBoxResult.Cancel:
                    break;
            }
        }

        private void Reset(object sender, RoutedEventArgs e)
        {
            this.amountBox.Clear();
            this.interestBox.Clear();
            this.rb1Box.Clear();
            this.rb2Box.Clear();
            this.frequencyBox.SelectedIndex = -1;
            this.rb1.IsChecked = this.rb2.IsChecked = false;
            this.dueDateBox.SelectedDate = null;

        }

        private void Print_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Help_Click(object sender, RoutedEventArgs e)
        {

        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            About newAbout = new About();
            this.NavigationService.Navigate(newAbout);
        }

        private void ContactUs_Click(object sender, RoutedEventArgs e)
        {
            About newAbout = new About();
            this.NavigationService.Navigate(newAbout);
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

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            if (this.dueDateBox.SelectedDate == null || this.amountBox.Text == "" || this.interestBox.Text == "" ||this.frequencyBox.SelectedIndex == -1 || this.rb1Box.Text=="" && this.rb2Box.Text=="")
            {
                string msgtext = "Cannot calculate mortgage.\n\nEnter mortgage information for all required fields.";
                string txt = "Error";

                MessageBoxButton button = MessageBoxButton.OKCancel;
                MessageBoxResult result = MessageBox.Show(msgtext, txt, button);

                switch (result)
                {
                    case MessageBoxResult.OK:
                        break;

                    case MessageBoxResult.Cancel:
                        break;
                }

            }
            else
            {
                ResultForm newResult = new ResultForm(this.amountBox.Text, this.interestBox.Text, this.frequencyBox.SelectionBoxItem, this.rb1Box.Text, this.rb2Box.Text, this.dueDateBox.SelectedDate);
                this.NavigationService.Navigate(newResult);
            }
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            //HomePage home1 = new HomePage();
            //this.NavigationService.Navigate(home1);
            this.NavigationService.GoBack();
        }
    }
}
