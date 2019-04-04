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
    /// Interaction logic for ExtraPrinciple.xaml
    /// </summary>
    public partial class ExtraPrinciple : Page
    {
        public ExtraPrinciple()
        {
            InitializeComponent();
            this.KeepAlive = true;
        }
        public ExtraPrinciple(object amount, object interest, object frequency, object length, object payment, DateTime? date) : this()
        {
            // Bind to expense report data.
            this.amountBox.Text = "$ " + amount.ToString() + ".00";
            this.interestBox.Text = interest.ToString() + "  %";
            this.frequencyBox.Text = frequency.ToString();

            this.rb1Box.Text = length.ToString() + " Yr/Yrs";
            this.rb2Box.Text = payment.ToString();
            this.dateBox.Text = date.Value.ToShortDateString();

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

        private void Default_Click(object sender, RoutedEventArgs e)
        {
            string msgtext = "Create a new default application will delete current mortgage information. Still want to proceed?";
            string txt = "Default application";

            MessageBoxButton button = MessageBoxButton.YesNoCancel;
            MessageBoxResult result = MessageBox.Show(msgtext, txt, button);

            switch (result)
            {
                case MessageBoxResult.Yes:
                    defaultForm(sender, e);
                    break;
                case MessageBoxResult.No:
                    break;
                case MessageBoxResult.Cancel:
                    break;
            }
        }

        private void defaultForm(object sender, RoutedEventArgs e)
        {

            NewMortgageForm newDefault = new NewMortgageForm();
            this.NavigationService.Navigate(newDefault);
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            string msgtext = "Want to save your changes?";
            string txt = "Reset Application";

            MessageBoxButton button = MessageBoxButton.YesNoCancel;
            MessageBoxResult result = MessageBox.Show(msgtext, txt, button);

            switch (result)
            {
                case MessageBoxResult.Yes:
                    Save_Click(sender, e);
                    break;
                case MessageBoxResult.No:
                    Reset(sender, e);
                    break;
                case MessageBoxResult.Cancel:
                    break;
            }
        }
        private void Reset(object sender, RoutedEventArgs e)
        {
            this.extraAmtBox.Clear();
            this.ExtrafrequencyBox.SelectedIndex = -1;

            OnceFreqBlock.Visibility = System.Windows.Visibility.Hidden;
            ExtraDueDateBox.Visibility = System.Windows.Visibility.Hidden;

            BeginFreqBlock.Visibility = System.Windows.Visibility.Hidden;
            DueDateBegin.Visibility = System.Windows.Visibility.Hidden;
            EndFreqBlock.Visibility = System.Windows.Visibility.Hidden;
            DueDateEnd.Visibility = System.Windows.Visibility.Hidden;
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

            if (this.extraAmtBox.Text == "" || this.ExtrafrequencyBox.SelectedIndex == -1)
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
                ResultForm newResult = new ResultForm(this.amountBox.Text, this.interestBox.Text, this.frequencyBox.Text, this.rb1Box.Text, this.rb2Box.Text, this.dateBox.Text, this.extraAmtBox.Text, this.ExtrafrequencyBox.SelectedItem);
                this.NavigationService.Navigate(newResult);
            }
        }

        private void ExtrafrequencyBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = ExtrafrequencyBox.SelectedItem as ComboBoxItem;
            if (item != null)
            {
                if (item.Content.ToString() == "Once")
                {
                    // OnceGrid.Visibility = System.Windows.Visibility.Visible;
                    OnceFreqBlock.Visibility = System.Windows.Visibility.Visible;
                    ExtraDueDateBox.Visibility = System.Windows.Visibility.Visible;

                    BeginFreqBlock.Visibility = System.Windows.Visibility.Hidden;
                    DueDateBegin.Visibility = System.Windows.Visibility.Hidden;
                    EndFreqBlock.Visibility = System.Windows.Visibility.Hidden;
                    DueDateEnd.Visibility = System.Windows.Visibility.Hidden;

                    //MultipleGrid.Visibility = System.Windows.Visibility.Hidden;
                }
                else if (item.Content.ToString() == "Multiple")
                {
                    BeginFreqBlock.Visibility = System.Windows.Visibility.Visible;
                    DueDateBegin.Visibility = System.Windows.Visibility.Visible;
                    EndFreqBlock.Visibility = System.Windows.Visibility.Visible;
                    DueDateEnd.Visibility = System.Windows.Visibility.Visible;

                    OnceFreqBlock.Visibility = System.Windows.Visibility.Hidden;
                    ExtraDueDateBox.Visibility = System.Windows.Visibility.Hidden;
                }

                else if (item.Content.ToString() == "All")
                {
                    OnceFreqBlock.Visibility = System.Windows.Visibility.Hidden;
                    ExtraDueDateBox.Visibility = System.Windows.Visibility.Hidden;

                    BeginFreqBlock.Visibility = System.Windows.Visibility.Hidden;
                    DueDateBegin.Visibility = System.Windows.Visibility.Hidden;
                    EndFreqBlock.Visibility = System.Windows.Visibility.Hidden;
                    DueDateEnd.Visibility = System.Windows.Visibility.Hidden;
                }
            }
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            //NewMortgageForm back1 = new NewMortgageForm();
            //this.NavigationService.Navigate(back1);
            this.NavigationService.GoBack();
        }
    }
}
