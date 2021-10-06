using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace Gestion_des_etudiants
{
    public partial class Importer_les_données : Form
    {
        public Importer_les_données()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "select file";
            fdlg.FileName = txtFile.Text;
            fdlg.Filter = "Excel Sheet(*.xlsx)|*.xlsx|All files(*.*)|*.*";
            fdlg.FilterIndex = 1;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                txtFile.Text = fdlg.FileName;

            }
            OleDbConnection theConnection = new OleDbConnection(@"provider=Microsoft.Jet.OLEDB.4.0;data source='" + txtFile.Text + "';Extended Properties=\"Excel 8.0;HDR=NO;IMEX=1\"");
            try
            {
                theConnection.Open();
                OleDbDataAdapter theDataAdapter = new OleDbDataAdapter("Select * from[etudiant$]", theConnection);
                DataSet thSd = new DataSet();
                DataTable dt = new DataTable();
                theDataAdapter.Fill(dt);
                this.dgrdFile.DataSource = dt.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                SqlConnection cnx = new SqlConnection();
                cnx.ConnectionString = "Data Source=LAPTOP-NECVBEJ4\\SQLEXPRESS;Initial Catalog=GestionDesEtudiants;Integrated Security=True";

                for (int i = 0; i < dgrdFile.Rows.Count; i++)
                {
                    String requete = "INSERT INTO Etudiant VALUES('" + dgrdFile.Rows[i].Cells[0].Value + "','" + dgrdFile.Rows[i].Cells[1].Value+ "','" + dgrdFile.Rows[i].Cells[2].Value + "','" + dgrdFile.Rows[i].Cells[3].Value + "','" + dgrdFile.Rows[i].Cells[4].Value + "','" + dgrdFile.Rows[i].Cells[5].Value + "','" + dgrdFile.Rows[i].Cells[6].Value + "','" + dgrdFile.Rows[i].Cells[7].Value + "')";

                    SqlCommand cmd = new SqlCommand(requete, cnx);

                    if (cnx.State == ConnectionState.Open) cnx.Close();

                    cnx.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("un ajoutée!!! ");
                    cnx.Close();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        
    }
}
