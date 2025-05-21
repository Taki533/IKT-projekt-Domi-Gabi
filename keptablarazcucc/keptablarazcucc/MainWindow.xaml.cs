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
        int r = 0;
        int origoX = 222;
        int origoY = 178;
        void koordRendszer()
        {
            //MessageBox.Show(Convert.ToString(canvas.ActualWidth),Convert.ToString(canvas.ActualHeight));
            Line xTengely = new Line();
            Line yTengely = new Line();

            xTengely.Stroke = Brushes.Black;
            yTengely.Stroke = Brushes.Black;

            xTengely.X1 = 0;
            xTengely.Y1 = origoY;
            xTengely.X2 = canvas.ActualWidth;
            xTengely.Y2 = origoY;

            yTengely.X1 = origoX;
            yTengely.Y1 = 0;
            yTengely.X2 = origoX;
            yTengely.Y2 = canvas.ActualHeight;



            canvas.Children.Add(xTengely);
            canvas.Children.Add(yTengely);

            for (int i = 0; i < canvas.ActualWidth/2; i += 30)
            {
                Line vonas = new Line();
                vonas.Stroke = Brushes.Black;
                vonas.X1 = origoX + i;
                vonas.Y1 = origoY - 5;
                vonas.X2 = origoX + i;
                vonas.Y2 = origoY + 5;

                canvas.Children.Add(vonas);
            }
      

            for (int i = 0; i < origoX; i += 30)
            {
                
                Line vonas = new Line();
                vonas.Stroke = Brushes.Black;
                vonas.X1 = origoX - i;
                vonas.Y1 = origoY - 5;
                vonas.X2 = origoX - i;
                vonas.Y2 = origoY + 5;

                canvas.Children.Add(vonas);
            }
            for (double i = -1; i <= canvas.ActualHeight/2; i +=30)
            {
                Line vonas = new Line();
                vonas.Stroke = Brushes.Black;
                vonas.X1 = origoX - 5;
                vonas.Y1 = origoY + i;
                vonas.X2 = origoX + 5;
                vonas.Y2 = origoY + i;

                canvas.Children.Add(vonas);
            }
            for (double i = 0; i <= canvas.ActualHeight/2; i += 30)
            {
                
                Line vonas = new Line();
                vonas.Stroke = Brushes.Black;
                vonas.X1 = origoX - 5;
                vonas.Y1 = origoY - i;
                vonas.X2 = origoX + 5;
                vonas.Y2 = origoY - i;

                canvas.Children.Add(vonas);
            }



        }
        private void gomb_Click(object sender, RoutedEventArgs e)
        {
            canvas.Children.Clear();
            koordRendszer();
            if (alakvalasztas.SelectedIndex == 3)
            {
                feketeKor();
            }
        }

        private void canvas_loaded(object sender, RoutedEventArgs e)
        {
            
            koordRendszer();
        }

        void feketeKor()
        {


            r = int.Parse(Rtext.Text);
            Ellipse kor= new Ellipse();
            kor.Stroke= Brushes.Black;
            kor.Width = int.Parse(Rtext.Text)*2;
            kor.Height = int.Parse(Rtext.Text)*2;
            kor.Fill = Brushes.Black;
            double dX = Math.Cos(origoX+Convert.ToInt32(Xtext.Text) / 180.0 * Math.PI)* r;
            kor.Margin = new Thickness(origoX + int.Parse(Xtext.Text) - r, origoY - (int.Parse(Ytext.Text)) - r, 0, 0);
            canvas.Children.Add(kor);

        }
    }
}