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

namespace Que2
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
            int years = Convert.ToInt32(NumberCC.Text);
            int yc = years / 10;
            int ys = years % 10;
            string pa, pr, pc;

            if(years >= 20 && years <= 69)
            {
                switch (yc)
                {
                    case 2:

                        pc = "Двадцать";
                        NAnswer.Content = pc + " ";
                        break;

                    case 3:

                        pc = "Тридцать";
                        NAnswer.Content = pc + " ";
                        break;

                    case 4:

                        pc = "Сорок";
                        NAnswer.Content = pc + " ";
                        break;

                    case 5:

                        pc = "Пятьдесят";
                        NAnswer.Content = pc + " ";
                        break;

                    case 6:

                        pc = "Шестьдесят";
                        NAnswer.Content = pc + " ";
                        break;

                }

                switch (ys)
                {
                    case 0:
                        pa = "";
                        pr = "лет";
                        NAnswer.Content += pa + " " + pr;
                        break;

                    case 1:

                        pa = "один";
                        pr = "год";
                        NAnswer.Content += pa + " " + pr;
                        break;

                    case 2:

                        pa = "два";
                        pr = "года";
                        NAnswer.Content += pa + " " + pr;
                        break;

                    case 3:

                        pa = "три";
                        pr = "года";
                        NAnswer.Content += pa + " " + pr;
                        break;

                    case 4:

                        pa = "четыре";
                        pr = "года";
                        NAnswer.Content += pa + " " + pr;
                        break;

                    case 5:

                        pa = "пять";
                        pr = "лет";
                        NAnswer.Content += pa + " " + pr;
                        break;

                    case 6:

                        pa = "шесть";
                        pr = "лет";
                        NAnswer.Content += pa + " " + pr;
                        break;

                    case 7:

                        pa = "семь";
                        pr = "лет";
                        NAnswer.Content += pa + " " + pr;
                        break;

                    case 8:

                        pa = "восемь";
                        pr = "лет";
                        NAnswer.Content += pa + " " + pr;
                        break;

                    case 9:

                        pa = "девять";
                        pr = "лет";
                        NAnswer.Content += pa + " " + pr;
                        break;

                }
                
                
            }

            

        }
    }
}
