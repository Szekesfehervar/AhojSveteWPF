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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AhojSveteWPF
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

        private void button1_MouseEnter(object sender, MouseEventArgs e)
        {
            int RanWidth = Convert.ToInt32(Gridos.ActualWidth - button1.Width);
            int RanHeight = Convert.ToInt32(Gridos.ActualHeight - button1.Height);
            Random rand = new Random();
            button1.Margin = new Thickness(rand.Next(RanWidth), rand.Next(RanHeight), 0, 0);
        }

    }
}
