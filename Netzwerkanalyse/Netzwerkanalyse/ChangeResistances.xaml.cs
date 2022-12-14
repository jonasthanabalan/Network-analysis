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
using System.Windows.Shapes;

namespace Netzwerkanalyse
{
    /// <summary>
    /// Interaktionslogik für ChangeResistances.xaml
    /// </summary>
    public partial class ChangeResistances : Window
    {
        public ChangeResistances()
        {
            InitializeComponent();
        }

        public double[] getInput()
        {
            double[] input = new double[5];
            try
            {
                input[0] = Convert.ToDouble(R1.Text);
                input[1] = Convert.ToDouble(R2.Text);
                input[2] = Convert.ToDouble(R3.Text);
                input[3] = Convert.ToDouble(R5.Text);
                input[4] = Convert.ToDouble(R6.Text);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return input;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Resistances resistances = new Resistances();
            resistances.write(getInput());
            Close();
        }
    }
}
