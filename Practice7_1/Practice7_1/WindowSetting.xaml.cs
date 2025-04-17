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

namespace Practice7_1
{
    /// <summary>
    /// Логика взаимодействия для WindowSetting.xaml
    /// </summary>
    public partial class WindowSetting : Window
    {
        List<string> listColorName = new List<string>
            { "Черный", "Серый", "Белый", "Синий", "Красный", "Зеленый", "Желтый"};
        List<Color> listColorBG = new List<Color>
            { Colors.Black, Colors.Gray, Colors.White, Colors.Blue, Colors.Red, Colors.Green, Colors.Yellow};
        List<Color> listColorFont = new List<Color>
            { Colors.White, Colors.White, Colors.Black, Colors.White, Colors.White, Colors.White, Colors.White};

        public WindowSetting()
        {
            InitializeComponent();
            for (int i = 0; i < listColorName.Count; i++)
            {
                ListBoxColor.Items.Add(listColorName[i]);
            }
        }
          
        private void SC(object sender, SelectionChangedEventArgs e)
        {
            int index = ListBoxColor.SelectedIndex;
            Style listBoxStyle = new Style(typeof(ListBox));

            SolidColorBrush highlightBrush = new SolidColorBrush(listColorBG[index]);
            SolidColorBrush highlightTextBrush = new SolidColorBrush(listColorFont[index]);

            // Устанавливаем системные кисти напрямую
            Application.Current.Resources[SystemColors.HighlightBrushKey] = highlightBrush;
            Application.Current.Resources[SystemColors.HighlightTextBrushKey] = highlightTextBrush;
        }

        private void Close(object sender, EventArgs e)
        {
            Program.GetInstance().settisngOpen = false;
        }

        private void SizeControl(object sender, SizeChangedEventArgs e)
        {
            if (this.Height < 470)
            {
                this.Height = 470;
            }
            if (this.Width < 400)
            {
                this.Width = 400;
            }
        }
    }
}
