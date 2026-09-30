using System.Diagnostics.PerformanceData;
using System.Windows;

namespace Lab01App
{
    public partial class MainWindow : Window
    {
        private int clickCount = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string name = NameBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show(
                    "Введите имя.",
                    "Ошибка ввода",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning);

                return;
            }

            ResultText.Text = "Здравствуйте, " + name + "!";

            clickCount++;

            CounterText.Text = "Нажатий: " + clickCount;
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            NameBox.Clear();
            ResultText.Text = "";
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}