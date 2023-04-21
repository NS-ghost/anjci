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

namespace kviz
{
    /// <summary>
    /// Interaction logic for Page4.xaml
    /// </summary>
    public partial class Page4 : Page
    {
        public Page4()
        {
            InitializeComponent();
            btnDalje3.Visibility = Visibility.Hidden;
        }

        private void tb2_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tb2.Text == "Da" || tb2.Text == "da" || tb2.Text == "DA")
            {
                btnDalje3.Visibility = Visibility.Visible;
            }
            else
            {
                lblDaneMoz.Content = "PRIHVATAM SAMO DA!";
            }
        }

        private void btnDalje3_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Page5());
        }
    }
}
