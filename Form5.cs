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
    public partial class Form5 : Form
    {
        string con = "Data Source=.;Initial Catalog=School;Integrated Security=True;";
        public Form5()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form6 f = new Form6();
            f.Show();
            this.Hide();
        }

        private void btnInner_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(con);

            string query =
                "SELECT Student.Fname, Subject.SubjectName " +
                "FROM Enrollment " +
                "INNER JOIN Student ON Enrollment.StudentID = Student.StudentID " +
                "INNER JOIN Subject ON Enrollment.SubjectID = Subject.SubjectID";

            SqlDataAdapter da = new SqlDataAdapter(query, cn);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dgvInner.DataSource = dt;
        }

        private void btnOuter_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(con);

            string query =
                "SELECT Student.Fname, Parent.ParentName " +
                "FROM Student " +
                "LEFT OUTER JOIN Parent " +
                "ON Student.StudentID = Parent.StudentID";

            SqlDataAdapter da = new SqlDataAdapter(query, cn);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dgvOuter.DataSource = dt;
        }
    }
}
