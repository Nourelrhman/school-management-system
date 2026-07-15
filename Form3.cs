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
    public partial class Form3 : Form
    {
        string con = "Data Source=.;Initial Catalog=School;Integrated Security=True;";
        public Form3()
        {
            InitializeComponent();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(con);

            string query =
                "SELECT SubjectID, MAX(Score) AS MaxScore " +
                "FROM ExamResult " +
                "GROUP BY SubjectID " +
                "HAVING MAX(Score) > 50 " +
                "ORDER BY MaxScore DESC";

            SqlDataAdapter da = new SqlDataAdapter(query, cn);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dgvMax.DataSource = dt;

        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(con);

            string query =
                "SELECT SubjectID, MIN(Score) AS MinScore " +
                "FROM ExamResult " +
                "GROUP BY SubjectID " +
                "HAVING MIN(Score) >= 0 " +
                "ORDER BY MinScore ASC";

            SqlDataAdapter da = new SqlDataAdapter(query, cn);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dgvMin.DataSource = dt;

        }

        private void btnAge_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(con);

            string query =
                "SELECT StudentID, Fname, " +
                "DATEDIFF(YEAR, BirthDate, GETDATE()) AS Age " +
                "FROM Student " +
                "ORDER BY Age DESC";

            SqlDataAdapter da = new SqlDataAdapter(query, cn);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dgvAge.DataSource = dt;

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Show();
            this.Hide();
        }
    }
}
