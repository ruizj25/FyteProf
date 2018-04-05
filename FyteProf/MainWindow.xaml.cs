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

namespace FyteProf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

      

        private void HeavyWinButton_Click(object sender, RoutedEventArgs e)
        {
         
            Heavyweights heavyWin = new Heavyweights(this);
            heavyWin.Show();
        }

        private void MiddleWinButton_Click(object sender, RoutedEventArgs e)
        {
            
            Middleweights middleWin = new Middleweights(this);
            middleWin.Show();
        }

        private void FeatherWinButton_Click(object sender, RoutedEventArgs e)
        {
            
            Featherweights featherWin = new Featherweights(this);
            featherWin.Show();
        }

        private void LightWinButton_Click(object sender, RoutedEventArgs e)
        {
            Lightweights lightWin = new Lightweights(this);
            lightWin.Show();
        }
    }
}
