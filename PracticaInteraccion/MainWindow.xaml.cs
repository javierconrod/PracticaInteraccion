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

namespace PracticaInteraccion
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void sldPorcentajePropina_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lblPorcentajePropina.Text = (((int)(sldPorcentajePropina.Value)).ToString() + "%");
            float cuenta = float.Parse(txtCuenta.Text);
            float montoPropina = (int)(sldPorcentajePropina.Value) / 100.0f * cuenta;

            float totalAPagar = cuenta + montoPropina;

            lblTotalConPropina.Text = ("$ " + totalAPagar.ToString()) ;
        }
    }
}
