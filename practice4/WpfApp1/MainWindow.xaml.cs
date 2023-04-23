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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnZ_Click(object sender, RoutedEventArgs e)
        {
            int N = Convert.ToInt32(NumberCC.Text);

            int k1;

            k1 = N % 10;

            while (N != 0)
            {
                if(k1 == 0)
                {
                    NAnswer.Content = "True";
                    break;
                }
                else
                {
                    NAnswer.Content = "False";
                    N /= 10;
                    k1 = N % 10;
                }
            }

            
        }
    }
}
