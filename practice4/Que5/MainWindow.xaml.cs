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

namespace Que5
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
            int k = 1, m = 1;

            if (N == k)
            {
                while (N >= k)
                {
                    m++;
                    k += m;
                    
                }
            }
            else if (N > k)
            {
                while (N > k)
                {   
                    m++;
                    k += m;
                    
                }
            }

            NAnswer.Content = k + "\n" + m;
        }
    }
}
