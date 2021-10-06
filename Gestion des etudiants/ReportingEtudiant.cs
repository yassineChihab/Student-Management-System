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
using Microsoft.Reporting.WinForms;

namespace Gestion_des_etudiants
{
    public partial class ReportingEtudiant : Form
    {
        public ReportingEtudiant()
        {
            InitializeComponent();
        }

        private void ReportingEtudiant_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cnx = new SqlConnection();
                cnx.ConnectionString = "Data Source=LAPTOP-NECVBEJ4\\SQLEXPRESS;Initial Catalog=GestionDesEtudiants;Integrated Security=True ";
                String Query = "SELECT *FROM Etudiant where cne='" + this.txtCne.Text.Trim() + "'";
                SqlCommand command = new SqlCommand(Query, cnx);

                cnx.Open();
                SqlDataAdapter da = new SqlDataAdapter(command);

                

                DataTable dt = new DataTable();
                

                da.Fill(dt);
                
                ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            
                reportViewer1.LocalReport.ReportPath = @"C:\Users\abc\source\repos\Gestion des etudiants\Gestion des etudiants\Report2.rdlc";
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);

                reportViewer1.RefreshReport();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"l'Etudiant de CNE: "+this.txtCne.Text+",n'existe pas ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                

        }


        }
    }
}
