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
using System.Configuration;

namespace Gestion_des_etudiants
{
    public partial class Statistique : Form
    {
        public Statistique()
        {
            InitializeComponent();
        }

        private void Statistique_Load(object sender, EventArgs e)
        {
            LoadData();

        }

        private void LoadData()
        {
            chart1.DataSource = GetData();
            chart1.Series["Series1"].XValueMember = "Filiere";
            chart1.Series["Series1"].YValueMembers = "Total";
        
        }

        private DataTable GetData()
        {
            DataTable dtChartData = new DataTable();

            SqlConnection cnx = new SqlConnection();
            cnx.ConnectionString = "Data Source=LAPTOP-NECVBEJ4\\SQLEXPRESS;Initial Catalog=GestionDesEtudiants;Integrated Security=True";

            SqlCommand cmd = new SqlCommand("usp_ChartData", cnx);

            cmd.CommandType = CommandType.StoredProcedure;

            cnx.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            dtChartData.Load(reader);


            return dtChartData;
        }
    }
}
