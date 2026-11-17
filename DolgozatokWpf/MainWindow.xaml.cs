using System.Windows;

namespace DolgozatokWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public class Dolgozatok
        {
            public string Nev { get; set; }
            public int Eletkor { get; set; }
            public int Pontszam { get; set; }


            public Dolgozatok(string nev, int eletkor, int pontszam)
            {
                Nev = nev;
                Eletkor = eletkor;
                Pontszam = pontszam;
            }
        }


        public List<Dolgozatok> dolgozatok = new List<Dolgozatok>()
        {
            new Dolgozatok("Kiss Péter", 16, 87),
            new Dolgozatok("Nagy Anna", 17, 92),
            new Dolgozatok("Szabó Tamás", 16, 78),
            new Dolgozatok("Tóth Éva", 18, 95),
            new Dolgozatok("Varga Bence", 17, 81),
            new Dolgozatok("Horváth Zsolt", 16, 65),
            new Dolgozatok("Molnár Réka", 18, 89),
            new Dolgozatok("Lakatos Dániel", 17, 72)
        };


        public MainWindow()
        {
            InitializeComponent();
            dgAdatok.ItemsSource = dolgozatok;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            var nev = tbName.Text;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}