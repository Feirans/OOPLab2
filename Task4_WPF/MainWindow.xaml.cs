using System;
using System.Windows;
using System.Windows.Media;

namespace Task4_WPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, RoutedEventArgs e)
        {
            txtMessage.Text = "";
            txtMessage.Foreground = System.Windows.Media.Brushes.Black;
            
            lblX1.Visibility = Visibility.Hidden;
            txtX1.Visibility = Visibility.Hidden;
            lblX2.Visibility = Visibility.Hidden;
            txtX2.Visibility = Visibility.Hidden;
            lblD.Content = "Дискримінант: -";

            if (!double.TryParse(txtA.Text, out double a) || 
                !double.TryParse(txtB.Text, out double b) || 
                !double.TryParse(txtC.Text, out double c))
            {
                txtMessage.Foreground = System.Windows.Media.Brushes.Red;
                txtMessage.Text = "Помилка: Введіть коректні числа у всі поля.";
                return;
            }

            if (a == 0)
            {
                txtMessage.Foreground = System.Windows.Media.Brushes.Red;
                txtMessage.Text = "Помилка: Коефіцієнт 'a' не може бути 0.";
                return;
            }

            double discriminant = Math.Pow(b, 2) - 4 * a * c;
            lblD.Content = $"Дискримінант: {discriminant}";

            if (discriminant > 0)
            {
                txtMessage.Text = "Рівняння має ДВА розв'язки:";
                
                double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);

                lblX1.Visibility = Visibility.Visible;
                txtX1.Visibility = Visibility.Visible;
                lblX2.Visibility = Visibility.Visible;
                txtX2.Visibility = Visibility.Visible;

                txtX1.Text = x1.ToString();
                txtX2.Text = x2.ToString();
            }
            else if (discriminant == 0)
            {
                txtMessage.Text = "Рівняння має ОДИН розв'язок:";
                
                double x = -b / (2 * a);

                lblX1.Visibility = Visibility.Visible;
                txtX1.Visibility = Visibility.Visible;

                txtX1.Text = x.ToString();
            }
            else
            {
                txtMessage.Foreground = System.Windows.Media.Brushes.Red;
                txtMessage.Text = "Дійсних розв'язків немає (дискримінант < 0).";
            }
        }
    }
}