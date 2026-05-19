using celloveszetCLI_13B;
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

namespace celloveszetWPF
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
            dtgAdatok.ItemsSource = Program.cellovok;
        }

        private void btnHozzaad_Click(object sender, RoutedEventArgs e)
        {
            int elso=int.Parse(tbxElso.Text);
            int masodik=int.Parse(tbxMasodik.Text);
            int harmadik = int.Parse(tbxHarmadik.Text);
            int negyedik = int.Parse(tbxNegyedik.Text);

            if (elso>0 && elso<100 && masodik>0 && masodik<100 && harmadik>0 && harmadik<100 && negyedik>0 && negyedik<100)
            {
                Program.cellovok.Add(new celloveszetCLI_13B.Modells.cellovo($"{tbxNev.Text};{elso};{masodik};{harmadik};{negyedik}"));
                dtgAdatok.Items.Refresh();
            }
            else
            {
                MessageBox.Show("Nem megfelelő értékek!");
            }
        }

        private void btnMentes_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                StreamWriter sw = new StreamWriter("lovesek2.csv");
                foreach (var item in Program.cellovok)
                {
                    sw.WriteLine($"{item.Nev};{item.elsoloves};{item.masidikloves};{item.harmadikloves};{item.negyedikloves}");
                }
                sw.Close();
                MessageBox.Show("Sikeres mentés");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}