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

namespace test
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            float bok = 0;
            if (float.TryParse(bok_textbox.Text, out bok))
            {
                if (bok > 0)
                {
                    if (kwadrat_radio.IsChecked == true)
                    {
                        bok = (float)(bok * 4);
                    }
                    else if (trojkat_radio.IsChecked == true)
                    {
                        bok = (float)(bok * 3);
                    }
                    else if (pieciokat_radio.IsChecked == true)
                    {
                        bok = (float)(bok * 5);
                    }
                    MessageBox.Show("Wynik: " + bok.ToString(), "Odpowiedź", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Bok musi być większy niż 0!", "Błąd. James Błąd.", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Bok musi być liczbą!", "Błąd. James Błąd.", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}