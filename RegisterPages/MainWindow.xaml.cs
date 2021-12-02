using System;
using System.Windows;
using RegisterPages.Controller;
using RegisterPages.Model;

namespace RegisterPages
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, VerificationResponse
    {
        MainWindowController controller;
        public MainWindow()
        {
            InitializeComponent();
            controller = new MainWindowController();
            controller.SubcribeVerificationResult(this);
            
        }

        private void OnCheckboxEmailChecked(object sender, RoutedEventArgs e)
        {
            controller.SubscribeEmailVerification();
        }
        private void OnCheckboxEmailUnchecked(object sender, RoutedEventArgs e)
        {
            controller.UnsubscribeEmailVerification();
        }
        private void OnCheckboxWhatsappChecked(object sender, RoutedEventArgs e)
        {
            controller.SubscribeWAVerification();
        }
        private void OnCheckboxWhatsappUnhecked(object sender, RoutedEventArgs e)
        {
            controller.UnsubscribeWAVerification();
        }

        private void OnButtonDaftarClicked(object sender, RoutedEventArgs e)
        {
            labelKeteranganEmail.Content = "";
            labelKeteranganWa.Content = "";
            controller.registeringUser(textBoxName.Text,textBoxEmail.Text,textBoxPhoneNumber.Text);
        }

        public void OnWaVerificationSucceed(object source, EventArgs e)
        {
            labelKeteranganWa.Content = "Wa berhasil dikirim";
        }

        public void OnEmailVerificationSucceed(object source, EventArgs e)
        {
            labelKeteranganEmail.Content = "Email berhasil dikirim";
        }

    }
}
