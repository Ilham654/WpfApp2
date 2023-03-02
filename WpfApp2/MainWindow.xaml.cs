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


namespace WpfApp2
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
        private void Button1_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            string newTitle = (string)Button1.Content;
            Window parentWindow = Window.GetWindow(sender as Button);
            parentWindow.Title = newTitle;
            Button button = sender as Button;
            Grid parentGrid = button.Parent as Grid;
            parentGrid.Children.Remove(button);
        }
        private void Button2_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            string newTitle = (string)Button2.Content;
            Window parentWindow = Window.GetWindow(sender as Button);
            parentWindow.Title = newTitle;
            Button button = sender as Button;
            Grid parentGrid = button.Parent as Grid;
            parentGrid.Children.Remove(button);
        }
        private void Button3_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            string newTitle = (string)Button3.Content;
            Window parentWindow = Window.GetWindow(sender as Button);
            parentWindow.Title = newTitle;
            Button button = sender as Button;
            Grid parentGrid = button.Parent as Grid;
            parentGrid.Children.Remove(button);
        }
        private void Button4_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            string newTitle = (string)Button4.Content;
            Window parentWindow = Window.GetWindow(sender as Button);
            parentWindow.Title = newTitle;
            Button button = sender as Button;
            Grid parentGrid = button.Parent as Grid;
            parentGrid.Children.Remove(button);
        }
        private void Button5_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            string newTitle = (string)Button5.Content;
            Window parentWindow = Window.GetWindow(sender as Button);
            parentWindow.Title = newTitle;
            Button button = sender as Button;
            Grid parentGrid = button.Parent as Grid;
            parentGrid.Children.Remove(button);
        }
        private void Button6_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            string newTitle = (string)Button6.Content;
            Window parentWindow = Window.GetWindow(sender as Button);
            parentWindow.Title = newTitle;
            Button button = sender as Button;
            Grid parentGrid = button.Parent as Grid;
            parentGrid.Children.Remove(button);
        }

        private void RandomizeButtonColor(Button button)
        {
            Random random = new Random();
            byte[] colorBytes = new byte[3];
            random.NextBytes(colorBytes);
            Color randomColor = Color.FromRgb(colorBytes[0], colorBytes[1], colorBytes[2]);
            button.Background = new SolidColorBrush(randomColor);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RandomizeButtonColor(sender as Button);
            MessageBox.Show("Changed color 1");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            RandomizeButtonColor(sender as Button);
            MessageBox.Show("Changed color 2");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            RandomizeButtonColor(sender as Button);
            MessageBox.Show("Changed color 3");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            RandomizeButtonColor(sender as Button);
            MessageBox.Show("Changed color 4");
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            RandomizeButtonColor(sender as Button);
            MessageBox.Show("Changed color 5");
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            RandomizeButtonColor(sender as Button);
            MessageBox.Show("Changed color 6");
        }
    }
}
