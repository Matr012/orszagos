using hegyekCLI13B;
using System.IO;
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

namespace hegyekWPF13B
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Program.Beolvas();
            dgrAdatok.ItemsSource = Program.hegysegek;
        }

        private void btnHozzaad_Click(object sender, RoutedEventArgs e)
        {
            if (int.Parse(tbxMagassag.Text) > 0 && (int.Parse(tbxMagassag.Text) < 2000))
            {
                Program.hegysegek.Add(new Hegyek($"{tbxNev.Text};{tbxHegyseg.Text};{tbxMagassag.Text}"));
                dgrAdatok.Items.Refresh();
            }
            else
            {
                MessageBox.Show("Nem megfelelő értékek!");
            }

        }

        private void btnMentes_Click(object sender, RoutedEventArgs e)
        {
            StreamWriter sw = new StreamWriter("hegycsucsok2.csv");
            foreach (var item in Program.hegysegek)
            {
                sw.WriteLine($"{item.Nev};{item.Hegyseg};{item.Magassag}");

            }
            sw.Close();
            MessageBox.Show("Sikeres mentés");
        }
    }
}