using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WeddeberekeningSchuifregelaar
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

        private void salarySlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double result = 0;

            if (salarySlider.Value < 10000)
            {
                result = salarySlider.Value;
            }
            else if (salarySlider.Value >= 10000 && salarySlider.Value <= 50000)
            {
                result = salarySlider.Value * 0.2;
            }
            else if (salarySlider.Value > 50000)
            {
                result = salarySlider.Value * 0.9;
            }

            resultTextBox.Text = result.ToString();

        }
    }
}