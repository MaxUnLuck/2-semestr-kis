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

namespace Practice7_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Program.GetInstance();
            Program.GetInstance().foodList.Add(new Program.Food("Крекеры", "Смешно хрустят."));
            Program.GetInstance().foodList.Add(new Program.Food("Кофе", "Бодрит немного."));
            Program.GetInstance().foodList.Add(new Program.Food("Доширак", "Сделан для бедных, но цена дорогая."));
            Program.GetInstance().foodList.Add(new Program.Food("Консерва говядины", "Без консерного ножа не открыть."));
            Program.GetInstance().foodList.Add(new Program.Food("Вода", "Водород и кислород."));
            for (int i = 0; i < Program.GetInstance().foodList.Count; i++)
            {
                ListBox.Items.Add(Program.GetInstance().foodList[i].name);
            }
        }

        private void MenuBtnSettingClick(object sender, RoutedEventArgs e)
        {
            if (Program.GetInstance().settisngOpen)
            {
                MessageBox.Show("Окно уже открыто!", "Не состыковка!", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                WindowSetting windowSetting = new WindowSetting();
                Program.GetInstance().settisngOpen = true;
                windowSetting.Show();
            }
        }

        private void MenuBtnClickAboutProgram(object sender, RoutedEventArgs e)
        {
            if (Program.GetInstance().aboutProgram)
            {
                MessageBox.Show("Окно уже открыто!", "Не состыковка!", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                AboutProgram aboutProgram = new AboutProgram();
                Program.GetInstance().aboutProgram = true;
                aboutProgram.Show();
            }
        }

        private void SelectFood(object sender, SelectionChangedEventArgs e)
        {
            TextBox.Text = Program.GetInstance().foodList[ListBox.SelectedIndex].description;
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

        private void CloseProgram(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
