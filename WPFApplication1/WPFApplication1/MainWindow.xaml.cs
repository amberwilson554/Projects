using System;
using System.Collections.Generic;
using System.Diagnostics;
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


namespace WPFApplication1
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

  
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(sender == Button1)
            {
                Square1.Background = new SolidColorBrush(Colors.DeepPink);
            }
            else if (sender == Button2)
            {
                Square1.Background = new SolidColorBrush(Colors.Black);
            }
            else if (sender == Button3)
            {
                Square1.Background = new SolidColorBrush(Colors.Cyan);
            }
            else if (sender == Button4)
            {
                Square1.Background = new SolidColorBrush(Colors.GreenYellow);
            }

        }

    }



}
