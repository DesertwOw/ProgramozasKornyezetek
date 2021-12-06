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

namespace ProgKörnyBeadando
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

        private void Button_Click_Exit(object sender, RoutedEventArgs e)
        {
            try
            {
                App.Current.Shutdown();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click_Minimize(object sender, RoutedEventArgs e)
        {
            try
            {
                this.WindowState = WindowState.Minimized;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        private void Button_Click_Register(object sender, RoutedEventArgs e)
        {
            Window1 objWindowRegister = new Window1();
            this.Visibility = Visibility.Hidden;
            objWindowRegister.Show();

        }

        private void Button_Click_Login(object sender, RoutedEventArgs e)
        {
            try
            {
                Window2 objWindowLogin = new Window2();
                this.Visibility = Visibility.Hidden;
                objWindowLogin.Show();
            }
            catch (Exception ec)
            {

                MessageBox.Show(ec.Message);

            }
        }
    }
}