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

namespace ProgKörnyBeadando
{
    /// <summary>
    /// Interaction logic for Window3.xaml
    /// </summary>


    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();

        }

        private void Button_Click_MediaPlayer(object sender, RoutedEventArgs e)
        {
            MusicPlayer objWindowMusicPlayer = new MusicPlayer();
            this.Visibility = Visibility.Hidden;
            objWindowMusicPlayer.Show();
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
    }
}

