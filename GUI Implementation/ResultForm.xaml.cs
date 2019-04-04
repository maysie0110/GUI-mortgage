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
    /// Interaction logic for ResultForm.xaml
    /// </summary>
    public partial class ResultForm : Page
    {
        public ResultForm()
        {
            InitializeComponent();
        }
        public ResultForm(object amount, object interest, object frequency, object length, object payment, DateTime? date) : this()
        {
            // Bind to expense report data.
            this.amountBox.Text = "$ "+ amount.ToString() + ".00";
            this.interestBox.Text = interest.ToString()+"  %";
            this.frequencyBox.Text = frequency.ToString();

            this.rb1Box.Text = length.ToString() + " Yr/Yrs";
            this.rb2Box.Text = payment.ToString();
          // this.dateBox.Text = date.Value.ToShortDateString();

        }

        public ResultForm(object amount, object interest, object frequency, object length, object payment, object date, object extra, object xfrequent) : this()
        {
            this.amountBox.Text = amount.ToString();
            this.interestBox.Text = interest.ToString();
            this.frequencyBox.Text = frequency.ToString();

            this.rb1Box.Text = length.ToString();
            this.rb2Box.Text = payment.ToString();
        }

        private void frequencyBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
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
            ExtraPrinciple extraForm = new ExtraPrinciple();
            this.NavigationService.Navigate(extraForm);
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


        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            //HomePage home1 = new HomePage();
            //this.NavigationService.Navigate(home1);
            this.NavigationService.GoBack();

        }

        private void HandleCheck(object sender, RoutedEventArgs e)
        {
            //expand.Visibility = System.Windows.Visibility.Collapsed;
            amountGrid.Visibility = System.Windows.Visibility.Visible;

            totalPaid.Visibility = System.Windows.Visibility.Hidden;
            totalPaidBox.Visibility = System.Windows.Visibility.Hidden;

            totalExpand.Visibility = System.Windows.Visibility.Hidden;
            totalExpand_Unchecked(sender, e);


            totalExpand1.Visibility = System.Windows.Visibility.Visible;

            nextPaymentBlock.Visibility = System.Windows.Visibility.Hidden;
            nextPayBox.Visibility = System.Windows.Visibility.Hidden;
        }

        private void HandleUnchecked(object sender, RoutedEventArgs e)
        {
            amountGrid.Visibility = System.Windows.Visibility.Hidden;


            totalPaid.Visibility = System.Windows.Visibility.Visible;
            nextPaymentBlock.Visibility = System.Windows.Visibility.Visible;
            totalPaidBox.Visibility = System.Windows.Visibility.Visible;
            nextPayBox.Visibility = System.Windows.Visibility.Visible;

            

            totalExpand1.Visibility = System.Windows.Visibility.Hidden;
            totalExpand1_Unchecked(sender, e);

            totalExpand.Visibility = System.Windows.Visibility.Visible;

        }

        private void totalExpand_Checked(object sender, RoutedEventArgs e)
        {
            TotalAmountGrid.Visibility = System.Windows.Visibility.Visible;


            nextPaymentBlock.Visibility = System.Windows.Visibility.Hidden;

            nextPayBox.Visibility = System.Windows.Visibility.Hidden;

        }

        private void totalExpand_Unchecked(object sender, RoutedEventArgs e)
        {
            TotalAmountGrid.Visibility = System.Windows.Visibility.Hidden;

            nextPaymentBlock.Visibility = System.Windows.Visibility.Visible;

            nextPayBox.Visibility = System.Windows.Visibility.Visible;


        }

        private void totalExpand1_Checked(object sender, RoutedEventArgs e)
        {
            TotalAmountGrid1.Visibility = System.Windows.Visibility.Visible;

            nextpayment4.Visibility = System.Windows.Visibility.Hidden;
            nextPaymentBlock4.Visibility = System.Windows.Visibility.Hidden;

            totalExpand.Visibility = System.Windows.Visibility.Hidden;
        }

        private void totalExpand1_Unchecked(object sender, RoutedEventArgs e)
        {
            TotalAmountGrid1.Visibility = System.Windows.Visibility.Hidden;

            nextpayment4.Visibility = System.Windows.Visibility.Visible;
            nextPaymentBlock4.Visibility = System.Windows.Visibility.Visible;

            totalExpand.Visibility = System.Windows.Visibility.Hidden;

        }
    }
}
