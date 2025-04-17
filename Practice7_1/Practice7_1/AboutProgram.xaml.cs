using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace Practice7_1
{
    /// <summary>
    /// Логика взаимодействия для AboutProgram.xaml
    /// </summary>
    public partial class AboutProgram : Window
    {
        public AboutProgram()
        {
            InitializeComponent();
        }

        private void Close(object sender, EventArgs e)
        {
            Program.GetInstance().aboutProgram = false;
        }

        private void SizeControl(object sender, SizeChangedEventArgs e)
        {
            if (this.Height < 400)
            {
                this.Height = 400;
            }
            if (this.Width < 400)
            {
                this.Width = 400;
            }
        }

        private void Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://web.telegram.org/k/#@BackSpacePeek",
                UseShellExecute = true
            }
            );
        }
    }
}
