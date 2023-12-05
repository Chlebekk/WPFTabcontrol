using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Produkt> Produkty { get; set; }
        public List<String> Strings { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            przygotujDane();
            Strings = new List<String>();
            Strings.Add("first");
            Strings.Add("seconst");
            Strings.Add("thirst");
            DataContext = this;
        }
        private void przygotujDane()
        {
            Produkty = new List<Produkt>();
            Produkty.Add(new Produkt("Woda", 10, "mokra"));
            Produkty.Add(new Produkt("Woda", 10, "sucha"));
            Produkty.Add(new Produkt("Woda", 10, "niewiem"));
        }
    }
}
