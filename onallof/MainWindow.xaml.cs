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

namespace onallof
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            lbx1.BorderBrush = null;
            kutyaNev.Text = null;


        }

        private void Gomb(object sender, RoutedEventArgs e)
        {
            MessageBoxResult eredmeny = MessageBox.Show("Szeretnél gizsgugyát?", "Kérdés", MessageBoxButton.YesNoCancel, MessageBoxImage.Question);
            if (eredmeny == MessageBoxResult.Yes)
            {
                valasz.Content = "Szeretnék gizsgugyát";
                kutyaNev.Text = "Mi legyen a neve?";
                lbx1.Items.Add("Gyula");
                lbx1.Items.Add("Herceg");
                lbx1.Items.Add("Lucifer");
                lbx1.Items.Add("Picur");

            }
            else
            {
                if (eredmeny == MessageBoxResult.No)
                {
                    valasz.Content = "Nem szeretnék gizsgugyát :c";
                    lbx1.Items.Clear();
                    lbx1.BorderBrush = null;
                    kutyaNev.Text = null;
                }


                else
                {
                    valasz.Content = "Döntésképtelen vagyok";
                    lbx1.Items.Clear();
                    lbx1.BorderBrush = null;
                    kutyaNev.Text = null;
                }


            }
        }

        private void Lista_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}