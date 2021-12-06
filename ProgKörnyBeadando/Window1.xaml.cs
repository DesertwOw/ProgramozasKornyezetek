using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Server=LAPTOP-1BSDJ4LJ; Database=LRDATABASE; Integrated Security=True");
                con.Open();
                string add_data = "INSERT INTO [dbo].[user] VALUES(@username, @password)";
                SqlCommand cmd = new SqlCommand(add_data, con);

                cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Password);
                cmd.ExecuteNonQuery();
                con.Close();
                txtUsername.Text = "";
                txtPassword.Password = "";
                MainWindow w1 = new MainWindow();
                this.Close();
                w1.Show();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
