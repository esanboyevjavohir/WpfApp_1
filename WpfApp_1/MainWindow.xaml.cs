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

namespace WpfApp_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Button button = new Button();

            button.Content = "Button5";
            button.Width = 40;
            button.Height = 50;
            button.Click += OnButton5Clicked;

            Button button1 = new Button();

            button1.Content = "Button6";
            button1.Width = 40;
            button1.Height = 50;
            button1.Click += OnButton6Clicked;

            InitializeComponent();
        }

        private void OnButton6Clicked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button6 was clicked");
        }
        private void OnButton5Clicked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button5 was clicked");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button1 bosildi");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button2 bosildi");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button 3 bosildi");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button4 bosildi");
        }
    }
}