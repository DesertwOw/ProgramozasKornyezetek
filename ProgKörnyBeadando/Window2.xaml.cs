using System;
using System.Collections.Generic;
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
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Server=LAPTOP-1BSDJ4LJ; Database=LRDATABASE; Integrated Security=True");
            con.Open();
            string add_data = "SELECT * FROM [dbo].[user] where username=@username and password=@password";
            SqlCommand cmd = new SqlCommand(add_data, con);

            cmd.Parameters.AddWithValue("@username", txtUsername.Text);
            cmd.Parameters.AddWithValue("@password", txtPassword.Password);
            cmd.ExecuteNonQuery();
            int Count = Convert.ToInt32(cmd.ExecuteScalar());

            con.Close();

            txtUsername.Text = "";
            txtPassword.Password = "";
            if (Count > 0)
            {
                Window3 w3 = new Window3();
                this.Close();
                w3.Show();
            }
            else
            {
                MessageBox.Show("Password or Username Incorrect!");
            }
        }
    }
}
