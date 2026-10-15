using System;
using System.Windows;
using System.Windows.Media; 

namespace Task3_WPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Foreground = Brushes.Red;

            if (!double.TryParse(txtX.Text, out double x))
            {
                txtResult.Text = "Помилка: Некоректно введено x.";
                return; 
            }

            if (!double.TryParse(txtY.Text, out double y))
            {
                txtResult.Text = "Помилка: Некоректно введено y.";
                return;
            }

            if (!double.TryParse(txtZ.Text, out double z))
            {
                txtResult.Text = "Помилка: Некоректно введено z.";
                return;
            }
            if (z <= 0)
            {
                txtResult.Text = "Помилка: число z має бути більше 0 (через логарифм).";
                return;
            }
            if (x == y)
            {
                txtResult.Text = "Помилка: x та y не можуть бути однаковими (ділення на нуль).";
                return;
            }

            double numerator = Math.Cos(y) - (Math.Log(z) / (x - y));
            
            
            double denominator = 1 + Math.Pow(x - z, 2);
            
           
            double s = (y - x) * (numerator / denominator);

            
            txtResult.Foreground = Brushes.Green; 
            
            txtResult.Text = $"Результат: s = {Math.Round(s, 3):F3}";
        }
    }
}