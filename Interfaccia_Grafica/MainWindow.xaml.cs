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

namespace Interfaccia_Grafica
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

        private void Calcola_Click(object sender, RoutedEventArgs e)
        {
            if (TxtNumero.Text = 0)
            {
                int a = int.Parse(TxtNumero.Text);
                string binary = Convert.ToString(a, 2);
                LblRisultato.Content = $"{binary}";
            }
            if (TxtNumero.Text = 1)
            {
                string a = TxtNumero.Text;
                string output = Convert.ToInt32(a, 2).ToString();
                LblRisultato.Content = $"{output}";
            }
        }
    }
}
