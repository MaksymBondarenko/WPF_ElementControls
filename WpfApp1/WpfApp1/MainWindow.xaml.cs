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

namespace WpfApp1
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

        private void Button_Paste_Click(object sender, RoutedEventArgs e)
        {
            int Buf = Convert.ToInt16(textBlock1.Text);
            Buf++;
            textBlock1.Text = Buf.ToString();
            PB.Password = TB.SelectedText;
        }

        private void Button_Clear_Click(object sender, RoutedEventArgs e)
        {
            int Buf = Convert.ToInt16(textBlock1.Text);
            Buf++;
            textBlock1.Text = Buf.ToString();
            PB.Clear();
        }

        private void SelectionChange_CB1(object sender, SelectionChangedEventArgs e)
        {
            PB.Clear();
            if (CB1.SelectedIndex == 0)
            {
                PB.PasswordChar = (Char)42;
            }
            else if (CB1.SelectedIndex == 1)
            {
                PB.PasswordChar = (Char)43;
            }
            else if(CB1.SelectedIndex == 2)
            {
                PB.PasswordChar = (Char)176;
            }
            else
            {
                PB.PasswordChar = (Char)174;
            }
            PB.IsEnabled = true;

        }

        private void SelectionChange_CB2(object sender, SelectionChangedEventArgs e)
        {
            TB.Clear();
            if (CB2.SelectedIndex == 0)
            {
                TB.MaxLength = 5;
            }
            else if (CB2.SelectedIndex == 1)
            {
                TB.MaxLength = 6;
            }
            else if (CB2.SelectedIndex == 2)
            {
                TB.MaxLength = 7;
            }
            else if (CB2.SelectedIndex == 3)
            {
                TB.MaxLength = 8;
            }
            else
            {
                TB.MaxLength = 10;
            }
            textBlock_1.Text = TB.MaxLength.ToString();
            TB.IsEnabled = true;
        }

        private void CopyContents_Click(object sender, RoutedEventArgs e)
        {
            TB.Copy();
        }
    }
}
