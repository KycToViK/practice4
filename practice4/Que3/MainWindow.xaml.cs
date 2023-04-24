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

namespace Que3
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

            int n = Convert.ToInt32(NumberNN.Text);
            double p;
            
            double R, L, S, D;

            switch (n)
            {
                case 1:
                    p = 3.14;
                    R = Convert.ToInt32(NumberCC.Text);
                    D = 2 * R;
                    L = 2 * p * R;
                    S = p * Math.Pow(R, 2);
                    NAnswer.Content = " 2. = " + D + "\n 3. = " + L + "\n 4. = " + S;
                    break;

                case 2:
                    p = 3.14;
                    D = Convert.ToInt32(NumberCC.Text);
                    R = D / 2;
                    L = 2 * p * R;
                    S = p * Math.Pow(R, 2);
                    NAnswer.Content = " 1. = " + R + "\n 3. = " + L + "\n 4. = " + S;
                    break;

                case 3:
                    p = 3.14;
                    L = Convert.ToInt32(NumberCC.Text);
                    R = L / 2 / p;
                    D = 2 * R;
                    S = p * Math.Pow(R, 2);
                    NAnswer.Content = " 1. = " + R + "\n 2. = " + D + "\n 4. = " + S;
                    break;

                case 4:
                    p = 3.14;
                    S = Convert.ToInt32(NumberCC.Text);
                    R = Math.Sqrt(S) / 2;
                    D = 2 * R;
                    L = 2 * p * R;
                    NAnswer.Content = " 1. = " + R + "\n 2. = " + D + "\n 3. = " + L;
                    break;
            }

        }
    }
}
