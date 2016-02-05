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
using System.Windows.Shapes;

namespace Airline
{
    /// <summary>
    /// Interaction logic for seatingChartWindow.xaml
    /// </summary>
    public partial class seatingChartWindow : Window
    {
        public seatingChartWindow()
        {
            InitializeComponent();
        }

        private void seats_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
