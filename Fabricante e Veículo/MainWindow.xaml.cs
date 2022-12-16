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

namespace Fabricante_e_Veículo
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

        private void Inserircarro_Click(object sender, RoutedEventArgs e)
        {
            Veiculo v = new Veiculo();
            v.SetNome(nomeveiculo.Text);
            v.SetModelo(modeloveiculo.Text);
            v.SetPreco(double.Parse(precoveiculo.Text));

        }
    }
}
