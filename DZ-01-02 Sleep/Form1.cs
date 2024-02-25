using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Npgsql;

namespace DZ_01_02_Sleep
{
    public partial class Authorization : Form
    {
        public int count = 0;
        public Authorization()
        {
            InitializeComponent();
        }

        private void auto_Click(object sender, EventArgs e)
        {
            try
            {
                if (count == 3)
                {
                    MessageBox.Show("Форма заблокирована");
                    Thread.Sleep(20000);
                    count = 0;
                }
                NpgsqlConnection con = new NpgsqlConnection("Host=localhost;Username=postgres;Password=cxNTVJas;Database=users");
                string query = "select login from users where login=@login and password=@password";
                NpgsqlCommand cmd = new NpgsqlCommand(query, con);
                cmd.Parameters.AddWithValue("@login", Tlogin.Text);
                cmd.Parameters.AddWithValue("@password", Tpassword.Text);
                con.Open();
                string check = (string)cmd.ExecuteScalar();
                con.Close();
                if (check == Tlogin.Text)
                {
                    MessageBox.Show("Вы авторизовались");
                }
                else
                {
                    count++;
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
