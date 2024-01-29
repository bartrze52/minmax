using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Controls;

namespace minmax
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton != null)
            {
                textBlock.Text = $"Opcja {radioButton.Content} wybrana";
                textBlock.Foreground = radioButton.IsChecked.Value ? System.Windows.Media.Brushes.Red : System.Windows.Media.Brushes.Black;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (image2.Source.ToString().EndsWith("kat.jpg"))
            {
                image2.Source = new BitmapImage(new Uri("kat2.jpg", UriKind.Relative));
            }
            else
            {
                image2.Source = new BitmapImage(new Uri("kat.jpg", UriKind.Relative));
            }
        }
    }
}