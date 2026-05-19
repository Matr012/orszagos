using LolCLI_V2;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows;

namespace LolWPF_V2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Hos> hosokOc = new();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string[] sorok = File.ReadAllLines("champions2017_V2.txt");

            for (int i = 1; i < sorok.Length; i++)
            {
                hosokOc.Add(new Hos(sorok[i]));
            }

            dgHosok.ItemsSource = hosokOc;
        }

        private void btnKereses_Click(object sender, RoutedEventArgs e)
        {
            string keresettNev = txtKereses.Text;

            if (keresettNev == "")
            {
                dgHosok.ItemsSource = hosokOc;
            }
            else
            {
                ObservableCollection<Hos> talalatok = new();
                foreach (Hos hos in hosokOc)
                {
                    if (hos.Name.Contains(keresettNev))
                    {
                        talalatok.Add(hos);
                    }
                }
                dgHosok.ItemsSource = talalatok;
            }

            txtKereses.Text = "";
        }

        private void btnMentes_Click(object sender, RoutedEventArgs e)
        {
            string keresettNev = txtKereses.Text;
            string fajlNev = "teljes.txt";
            
            if (keresettNev != "")
            {
                fajlNev = keresettNev + ".txt";
            }

            ObservableCollection<Hos> aktualisLista = (ObservableCollection<Hos>)dgHosok.ItemsSource;

            StreamWriter sw = new StreamWriter(fajlNev);
            foreach (Hos hos in aktualisLista)
            {
                sw.WriteLine("név: " + hos.Name + ", HP=" + hos.HP);
            }
            sw.Close();

            MessageBox.Show("Sikeres mentés");  
        }
    }
}