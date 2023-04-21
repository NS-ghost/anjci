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
    /// Interaction logic for Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        String igre;
        public Page3()
        {
            InitializeComponent();
            btnDalje2.Visibility = Visibility.Hidden;
        }

        private void tb1_TextChanged(object sender, TextChangedEventArgs e)
        {
            btnDalje2.Visibility = Visibility.Visible;
        }

        private void btnDalje2_Click_1(object sender, RoutedEventArgs e)
        {
            igre = tb1.Text;
            this.NavigationService.Navigate(new Page4());
        }
    }
}
