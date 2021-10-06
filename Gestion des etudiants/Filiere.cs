using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Gestion_des_etudiants
{
    public partial class Filiere : Form
    {
        public Filiere()
        {
            InitializeComponent();
        }
        //  String connexionString = ConfigurationManager.ConnectionStrings["MaConnection"].ConnectionString;

        private void button2_Click(object sender, EventArgs e)
        {

            if (check == false) return;

            panelModifier.Visible = true;
            this.txtNewFiliere.Text = this.dgvFiliere.Rows[position].Cells[1].Value.ToString();

            
        }

        private void btnAddFiliere_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.inputFiliere.Text.Trim().Equals(String.Empty))
                {
                    MessageBox.Show("veuillez saisie un nom de filiere");
                    return;
                }


                SqlConnection cnx = new SqlConnection();
                cnx.ConnectionString = "Data Source=LAPTOP-NECVBEJ4\\SQLEXPRESS;Initial Catalog=GestionDesEtudiants;Integrated Security=True";
                String requete = "INSERT INTO Filiere VALUES('" + this.inputFiliere.Text.Trim() + "')";
                SqlCommand cmd = new SqlCommand(requete, cnx);


                if (cnx.State == ConnectionState.Open) cnx.Close();

                cnx.Open();
                cmd.ExecuteNonQuery();
                listeFiliere();
                MessageBox.Show("une filiere ajoutée!!! ");
                cnx.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



        }
        void listeFiliere()
        {
            SqlConnection cnx = new SqlConnection();
            cnx.ConnectionString = "Data Source=LAPTOP-NECVBEJ4\\SQLEXPRESS;Initial Catalog=GestionDesEtudiants;Integrated Security=True ";
            String Query = "SELECT *FROM Filiere";
            SqlCommand command = new SqlCommand(Query, cnx);

            cnx.Open();

            SqlDataReader rd = command.ExecuteReader();

            if (rd.HasRows)
            {
                this.dgvFiliere.Rows.Clear();
                while (rd.Read())
                {
                    this.dgvFiliere.Rows.Add(rd[0], rd[1]);
                }
                cnx.Close();


            }
        }


        private void Filiere_Load(object sender, EventArgs e)
        {
            listeFiliere();
           
        }
        int idfiliere;
        int position = -1;
        bool check = false;


        private void dgvFiliere_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            position = this.dgvFiliere.CurrentRow.Index;
            idfiliere = int.Parse(this.dgvFiliere.Rows[position].Cells[0].Value.ToString());
            check=true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if(position==-1)
                {
                    MessageBox.Show("veuillez svp sélectionner une ligne");
                    return;
                       
                }
                SqlConnection cnx = new SqlConnection();
                cnx.ConnectionString = "Data Source=LAPTOP-NECVBEJ4\\SQLEXPRESS;Initial Catalog=GestionDesEtudiants;Integrated Security=True ";
                DialogResult dialog = MessageBox.Show("are you sure", "confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.No) return;

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnx;
                cmd.CommandText = "DELETE FROM Filiere WHERE ID =@id";
                cmd.Parameters.AddWithValue("@id", idfiliere);
                cnx.Open();
                cmd.ExecuteNonQuery();
                this.dgvFiliere.Rows.RemoveAt(position);
                MessageBox.Show("la filière est bien supprimée");
                cnx.Close();

            }catch(Exception exp)
            {
                MessageBox.Show(exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtNewFiliere.Text.Trim().Equals(String.Empty))
                {
                    return;
                }
                SqlConnection cnx = new SqlConnection();
                cnx.ConnectionString = "Data Source=LAPTOP-NECVBEJ4\\SQLEXPRESS;Initial Catalog=GestionDesEtudiants;Integrated Security=True ";
                String rq = "UPDATE Filiere SET nom=@p WHERE id=@p1";
                SqlCommand cmd = new SqlCommand(rq, cnx);
                cmd.Parameters.AddWithValue("@p", this.txtNewFiliere.Text.Trim());
                cmd.Parameters.AddWithValue("@p1", idfiliere);
                cnx.Open();
                cmd.ExecuteNonQuery();
                cnx.Close();
                listeFiliere();
                MessageBox.Show("la filiere est bien modifiée");
                panelModifier.Visible = false;

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }
    }
}