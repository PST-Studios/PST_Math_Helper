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

namespace WpfApp8
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(main_text.Text != "")
            {
                if(current_text.Text != "")
                {
                    previous_list.Items.Insert(0, current_text.Text);
                }
                
                if(main_text.Text.Length >= 10)
                {
                    MessageBox.Show("Number too large.  Please try a smaller number.", "Invalid Entry");
                }
                else
                {
                    int main = Int32.Parse(main_text.Text);
                    int main_length = main.ToString().Length;

                    //The other boxes.
                    int x1 = 1 * Int32.Parse(main_text.Text);
                    int x2 = 2 * Int32.Parse(main_text.Text);
                    int x3 = 3 * Int32.Parse(main_text.Text);
                    int x4 = 4 * Int32.Parse(main_text.Text);
                    int x5 = 5 * Int32.Parse(main_text.Text);
                    int x6 = 6 * Int32.Parse(main_text.Text);
                    int x7 = 7 * Int32.Parse(main_text.Text);
                    int x8 = 8 * Int32.Parse(main_text.Text);
                    int x9 = 9 * Int32.Parse(main_text.Text);
                    int x10 = 10 * Int32.Parse(main_text.Text);
                    int x11 = 11 * Int32.Parse(main_text.Text);
                    int x12 = 12 * Int32.Parse(main_text.Text);
                    int x13 = 13 * Int32.Parse(main_text.Text);
                    int x14 = 14 * Int32.Parse(main_text.Text);
                    int x15 = 15 * Int32.Parse(main_text.Text);
                    int x16 = 16 * Int32.Parse(main_text.Text);
                    int x17 = 17 * Int32.Parse(main_text.Text);
                    int x18 = 18 * Int32.Parse(main_text.Text);
                    int x19 = 19 * Int32.Parse(main_text.Text);
                    int x20 = 20 * Int32.Parse(main_text.Text);

                    current_text.Text = main.ToString();
                    x1_text.Text = x1.ToString();
                    x2_text.Text = x2.ToString();
                    x3_text.Text = x3.ToString();
                    x4_text.Text = x4.ToString();
                    x5_text.Text = x5.ToString();
                    x6_text.Text = x6.ToString();
                    x7_text.Text = x7.ToString();
                    x8_text.Text = x8.ToString();
                    x9_text.Text = x9.ToString();
                    x10_text.Text = x10.ToString();
                    x11_text.Text = x11.ToString();
                    x12_text.Text = x12.ToString();
                    x13_text.Text = x13.ToString();
                    x14_text.Text = x14.ToString();
                    x15_text.Text = x15.ToString();
                    x16_text.Text = x16.ToString();
                    x17_text.Text = x17.ToString();
                    x18_text.Text = x18.ToString();
                    x19_text.Text = x19.ToString();
                    x20_text.Text = x20.ToString();

                    main_text.Text = "";
                }
                
            }
        }
    }
}
