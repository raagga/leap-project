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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Lingoine.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SignUp : Page
    {
        public SignUp()
        {
            this.InitializeComponent();
        }

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void resetButton_Click(object sender, RoutedEventArgs e)
        {
            textBoxFirstName.Text = String.Empty;
            textBoxLastName.Text = String.Empty;
            textBoxUserName.Text = String.Empty;
            textBoxEmail.Text = String.Empty;
            passwordBox1.Password = String.Empty;
            passwordBoxConfirm.Password = String.Empty;
            dateOfBirth.Date = DateTime.Today;
            radioButtonMale.IsChecked = false;
            radioButtonFemale.IsChecked = false;
            textBoxLocation.Text = String.Empty;
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Views.WelcomePage));
        }
    }
}
