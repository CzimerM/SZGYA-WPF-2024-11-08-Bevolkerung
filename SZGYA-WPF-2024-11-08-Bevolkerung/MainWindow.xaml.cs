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

namespace SZGYA_WPF_2024_11_08_Bevolkerung
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Lakos> lakosok;
        public MainWindow()
        {
            InitializeComponent();
            lakosok = new();
            var sr = new StreamReader("../../../src/bevölkerung.txt", Encoding.UTF8);
            _ = sr.ReadLine(); // fejléc
            while(!sr.EndOfStream)
            {
                lakosok.Add(new Lakos(sr.ReadLine()));
            }
            sr.Close();
            lblListaSorMennyiseg.Content = lakosok.Count;
            lblListaElsoSor.Content = lakosok[0];
        }
    }
}