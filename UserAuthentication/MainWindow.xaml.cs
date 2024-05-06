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

namespace UserAuthentication
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

        private void login_button_Click(object sender, RoutedEventArgs e)
        {
            string login = textUsername.Text.Trim();
            string password = textPassword.Password.Trim();

            if (login.Length < 4)
            {
                textUsername.ToolTip = "Введите больше трех символов.";
                textUsername.Background = Brushes.DarkRed;
            }
            else if (password.Length < 4)
            {
                textPassword.ToolTip = "Введите больше трех символов.";
                textPassword.Background = Brushes.DarkRed;
            }
            else
            {
                textUsername.ToolTip = "";
                textUsername.Background = Brushes.Transparent;
                textPassword.ToolTip = "";
                textPassword.Background = Brushes.Transparent;

                MessageBox.Show("Ok");
            }
        }

        private void cancel_button_Click(object sender, RoutedEventArgs e)
        {
            textUsername.Clear();
            textPassword.Clear();
        }
    }
}