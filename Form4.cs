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
    public partial class Form4 : Form
    {
        string con = "Data Source=.;Initial Catalog=School;Integrated Security=True;";

        public Form4()
        {
            InitializeComponent();
        }

        private void btnSub1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(con);

            string query =
                "SELECT * FROM ExamResult " +
                "WHERE Score > (SELECT AVG(Score) FROM ExamResult)";

            SqlDataAdapter da = new SqlDataAdapter(query, cn);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dgvSub1.DataSource = dt;

        }

        private void btnSub2_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(con);

            string query =
                "SELECT * FROM Subject " +
                "WHERE TeacherID IN " +
                "(SELECT TeacherID FROM Teacher WHERE HireDate > '2020-01-01')";

            SqlDataAdapter da = new SqlDataAdapter(query, cn);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dgvSub2.DataSource = dt;

        }

        private void btnSub3_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(con);

            string query =
                "SELECT * FROM Student " +
                "WHERE StudentID IN " +
                "(SELECT StudentID FROM Enrollment)";

            SqlDataAdapter da = new SqlDataAdapter(query, cn);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dgvSub3.DataSource = dt;

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            f.Show();
            this.Hide();

        }
    }
}
