using System.Windows.Controls;

namespace KjuCode
{
    /// <summary>
    /// Interaction logic for QrCodeImage.xaml
    /// </summary>
    public partial class QrCodeImage : Page
    {
        public QrCodeImage()
        {
            InitializeComponent();
        }

        public QrCodeImage(string data)
            : this()
        {
            qrImgControl.Text = data;
        }
    }
}
