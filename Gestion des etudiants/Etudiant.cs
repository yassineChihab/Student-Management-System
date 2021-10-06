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

namespace Gestion_des_etudiants
{
    public partial class Etudiant : Form

    {
        SqlConnection cnx;
        public Etudiant()
        {
            InitializeComponent();
             cnx = new SqlConnection();
            cnx.ConnectionString = "Data Source=LAPTOP-NECVBEJ4\\SQLEXPRESS;Initial Catalog=GestionDesEtudiants;Integrated Security=True";
            string rq = "SELECT nom FROM Filiere";
           
            SqlCommand cmd = new SqlCommand(rq, cnx);
            cnx.Open();

            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                comboBoxFiliere.Items.Add(rd.GetValue(0).ToString());
            }

            cnx.Close();

        }
       private bool check()
        {

            if (
                this.txtCNE.Text.Trim().Equals(String.Empty) ||
                this.txtNom.Text.Trim().Equals(String.Empty) ||
                this.txtPrenom.Text.Trim().Equals(String.Empty) ||
                this.dateTime.Text.Trim().Equals(String.Empty) ||
                this.txtAdresse.Text.Trim().Equals(String.Empty) ||
                this.txtTelephone.Text.Trim().Equals(String.Empty) 
              ) return false;

            return true;
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Importer_les_données imp = new Importer_les_données();

        
            imp.Show();
        }

        string gender;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!check())
                {
                    MessageBox.Show("veuillez saisie tous les informations");
                    return;
                }
                String requete = "INSERT INTO Etudiant VALUES('" + this.txtCNE.Text.Trim() + "','" + this.txtNom.Text.Trim() + "','" + this.txtPrenom.Text.Trim() + "','" + gender + "','" + this.dateTime.Text.Trim() + "','" + this.txtAdresse.Text.Trim() + "','" + this.txtTelephone.Text.Trim() + "','" + this.comboBoxFiliere.SelectedItem + "')";

                SqlCommand cmd = new SqlCommand(requete, cnx);

                if (cnx.State == ConnectionState.Open) cnx.Close();

                cnx.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("un ajoutée!!! ");
                cnx.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }





        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gender = "H";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gender = "F";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String Query = "SELECT *FROM Etudiant";
            SqlCommand command = new SqlCommand(Query, cnx);
            cnx.Close();
            cnx.Open();

            SqlDataReader rd = command.ExecuteReader();

            if (rd.HasRows)
            {
                this.dgvEtudiant.Rows.Clear();
                while (rd.Read())
                {
                    this.dgvEtudiant.Rows.Add(rd[0], rd[1],rd[2],rd[3],rd[4],rd[5],rd[6],rd[7]);
                }
                cnx.Close();


            }
            else
            {
                MessageBox.Show("la table est vide!!!");
            }
        }
        String cneEtudiant;
        int position = -1;
        bool ch = false;


        private void dgvEtudiant_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            position = this.dgvEtudiant.CurrentRow.Index;
            cneEtudiant = this.dgvEtudiant.Rows[position].Cells[0].Value.ToString();
            ch = true;
            this.txtCNE.Text = this.dgvEtudiant.Rows[position].Cells[0].Value.ToString();
            this.txtNom.Text = this.dgvEtudiant.Rows[position].Cells[1].Value.ToString();
            this.txtPrenom.Text = this.dgvEtudiant.Rows[position].Cells[2].Value.ToString();
            this.dateTime.Text = this.dgvEtudiant.Rows[position].Cells[4].Value.ToString();
            this.txtAdresse.Text = this.dgvEtudiant.Rows[position].Cells[5].Value.ToString();
            this.txtTelephone.Text = this.dgvEtudiant.Rows[position].Cells[6].Value.ToString();
            this.comboBoxFiliere.SelectedItem = this.dgvEtudiant.Rows[position].Cells[7].Value.ToString();
            if (this.dgvEtudiant.Rows[position].Cells[3].Value.ToString().Equals("H"))
            {
                radioButton1.Checked=true;
            }
            else
            {
                radioButton2.Checked = true ;
            }
            ch = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (ch == false) return;

                if (!check())
                {
                    MessageBox.Show("veuillez saisie tous les informations");
                    return;
                }
                String rq = "UPDATE Etudiant SET cne=@p1, nom=@p2,prenom=@p3,sexe=@p4,dateNaissnce=@p5,adresse=@p6,telephone=@p7 ,nomFiliere=@p8 where cne=@p9 ";
                SqlCommand cmd = new SqlCommand(rq, cnx);
                cmd.Parameters.AddWithValue("@p1",this.txtCNE.Text.Trim());
                cmd.Parameters.AddWithValue("@p2", this.txtNom.Text.Trim());
                cmd.Parameters.AddWithValue("@p3", this.txtPrenom.Text.Trim());
                if (radioButton1.Checked == true)
                {
                    cmd.Parameters.AddWithValue("@p4", "H");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@p4", "F");
                }

                cmd.Parameters.AddWithValue("@p5", this.dateTime.Text);
                cmd.Parameters.AddWithValue("@p6", this.txtAdresse.Text.Trim());
                cmd.Parameters.AddWithValue("@p7", this.txtTelephone.Text.Trim());
               cmd.Parameters.AddWithValue("@p8",  this.comboBoxFiliere.SelectedItem );
                cmd.Parameters.AddWithValue("@p9", cneEtudiant);




                cnx.Close();


                cnx.Open();
                cmd.ExecuteNonQuery();
                cnx.Close();
                
                MessageBox.Show("modifiée");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (position == -1)
                {
                    MessageBox.Show("veuilez svp sélectionner une ligne");
                    return;
                }
                DialogResult dialog = MessageBox.Show("voulez-vous vraiment supprimer l'étudiant", "confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.No) return;

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnx;
                cmd.CommandText = "DELETE FROM Etudiant WHERE cne =@id";
                cmd.Parameters.AddWithValue("@id", cneEtudiant);
                cnx.Close();

                cnx.Open();

                cmd.ExecuteNonQuery();
                this.dgvEtudiant.Rows.RemoveAt(position);
                MessageBox.Show("l'etudiant est bien supprimé");

                cnx.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Etudiant_Load(object sender, EventArgs e)
        {

            string rq1 = "SELECT cne FROM Etudiant";
            SqlCommand cmd1 = new SqlCommand(rq1, cnx);
            cnx.Close();
            cnx.Open();
            SqlDataReader rd1 = cmd1.ExecuteReader();
            while (rd1.Read())
            {
               comboBoxChercherEtud.Items.Add(rd1.GetValue(0).ToString());
            }

            cnx.Close();


        }

        private void comboBoxChercherEtud_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cne = comboBoxChercherEtud.SelectedItem.ToString();
            SqlCommand command = cnx.CreateCommand();
            string rq = "SELECT * FROM Etudiant where  (cne='" + cne + "' ) ";
            command.CommandText = rq;


            cnx.Close();
            cnx.Open();


            SqlDataReader rd = command.ExecuteReader();
            while(rd.Read())
            {
                this.txtCNE.Text = rd.GetValue(0).ToString();
                 this.txtNom.Text = rd.GetValue(1).ToString();
                this.txtPrenom.Text = rd.GetValue(2).ToString();
               // this.dateTime.Text = rd.GetValue(3).ToString();
                this.txtAdresse.Text = rd.GetValue(4).ToString();
                this.txtTelephone.Text = rd.GetValue(5).ToString();
                if (rd.GetValue(3).ToString().Equals("H"))
                {
                    radioButton1.Checked = true;
                }
                else
                {
                    radioButton2.Checked = true;
                }
                this.comboBoxFiliere.SelectedItem = rd.GetValue(7).ToString();
            }




        }

        private void comboBoxFiliere_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }

