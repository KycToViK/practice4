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

namespace practice4
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

        private void BtnOk_Click(object sender, RoutedEventArgs e)
        {   
            string cc = Convert.ToString(NumberCC.Text);
            int nn = Convert.ToInt32(NumberNN.Text);

            switch(nn)
            {
                case -1:

                    if (cc == "C")
                        cc = "З";
                    else if (cc == "З")
                        cc = "Ю";
                    else if (cc == "Ю")
                        cc = "В";
                    else if (cc == "В")
                        cc = "С";

                    NumberCC.Text = cc;
                    NAnswer.Content = cc;

                    break;

                case 0:

                    NumberCC.Text = cc;
                    NAnswer.Content = cc;

                    break;

                case 1:

                    if (cc == "C")
                        cc = "В";
                    else if (cc == "В")
                        cc = "Ю";
                    else if (cc == "Ю")
                        cc = "З";
                    else if (cc == "З")
                        cc = "С";

                    NumberCC.Text = cc;
                    NAnswer.Content = cc;

                    break;
            }
        }
    }
}
