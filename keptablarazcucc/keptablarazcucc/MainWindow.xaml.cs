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

namespace keptablarazcucc
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

        private void Xtext_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void alakvalasztas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Háromszőg = X, Y, Magasság,    Négyzet= X,Y Átló     Kör= X,Y Sugár       Vonal=X,Y  index0=haromszog   index1=negyzet  index2=vonal   index3=kör

            if (alakvalasztas.SelectedIndex == 0) 
            {
                R.Content = "Magasság:";
                Rtext.Visibility = Visibility.Visible;
                R.Visibility = Visibility.Visible;

            }
            else if (alakvalasztas.SelectedIndex == 1)
            {
                R.Content = "Átló:";
                Rtext.Visibility = Visibility.Visible;
                R.Visibility = Visibility.Visible;
            }

            else if (alakvalasztas.SelectedIndex == 3)
            {
                R.Content = "Sugár:";
                Rtext.Visibility = Visibility.Visible;
                R.Visibility= Visibility.Visible;
            }
            else if (alakvalasztas.SelectedIndex == 2)
            {
                Rtext.Visibility = Visibility.Hidden;
                R.Visibility = Visibility.Hidden;
            }




        }
    }
}