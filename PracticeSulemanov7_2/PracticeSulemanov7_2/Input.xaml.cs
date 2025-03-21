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

namespace PracticeSulemanov7_2
{
    /// <summary>
    /// Логика взаимодействия для Input.xaml
    /// </summary>
    public partial class Input : Window
    {
        public Input()
        {
            InitializeComponent();
        }

        private void SqCh(object sender, DependencyPropertyChangedEventArgs e)
        {
            Calc.GetInstance().square = SqR.IsChecked.Value;
        }

        private void LeCh(object sender, DependencyPropertyChangedEventArgs e)
        {
            Calc.GetInstance().lenght = LeR.IsChecked.Value;
        }

        private void SACh(object sender, DependencyPropertyChangedEventArgs e)
        {
            Calc.GetInstance().sectorArea = SAR.IsChecked.Value;
        }

        private void TBInput(object sender, DependencyPropertyChangedEventArgs e)
        {
            TextBoxR.Text
        }
    }
}
