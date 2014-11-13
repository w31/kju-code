using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace KjuCode
{
    /// <summary>
    /// Interaction logic for QrCodeForm.xaml
    /// </summary>
    public partial class QrCodeForm : Page
    {
        public QrCodeForm()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new QrCodeImage(urlTextBox.Text));
        }
    }
}
