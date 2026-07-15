using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp3
{
   
    public partial class Form1 : Form
    {
        string con = "Data Source=.;Initial Catalog=School;Integrated Security=True;";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(con);

            string query = "SELECT * FROM Admins WHERE Username=@u AND Password=@p";

            SqlDataAdapter da = new SqlDataAdapter(query, cn);

            da.SelectCommand.Parameters.AddWithValue("@u", txtUser.Text);
            da.SelectCommand.Parameters.AddWithValue("@p", txtPass.Text);

            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login Success");

                Form2 f = new Form2();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password");
            }


        }
    }
}
