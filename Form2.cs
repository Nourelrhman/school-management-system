using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        string con = "Data Source=.;Initial Catalog=School;Integrated Security=True;";
        public Form2()
        {
            InitializeComponent();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(con);

            string query =
                "SELECT * FROM Student " +
                "WHERE Lname LIKE 'A%' " +
                "ORDER BY Fname";

            SqlDataAdapter da = new SqlDataAdapter(query, cn);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dgvStudent.DataSource = dt;

        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(con);

            string query =
                "SELECT * FROM Teacher " +
                "WHERE HireDate > '2020-01-01' " +
                "ORDER BY HireDate DESC";

            SqlDataAdapter da = new SqlDataAdapter(query, cn);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dgvTeacher.DataSource = dt;

        }

        private void btnSubject_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(con);

            string query =
                "SELECT * FROM Subject " +
                "WHERE SubjectName LIKE '%Math%' " +
                "ORDER BY SubjectName";

            SqlDataAdapter da = new SqlDataAdapter(query, cn);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dgvSubject.DataSource = dt;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
            this.Hide();
        }
    }
    }


