using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_des_etudiants
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      

       


        private void filiéreToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Filiere f = new Filiere();

            OpenForm(f);
            CloseForm(f);

        }

        private void etidiantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Etudiant etudiant = new Etudiant();

            OpenForm(etudiant);
           CloseForm(etudiant);

        }

        private void statistiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Statistique s = new Statistique();


            OpenForm(s);
           CloseForm(s);
        }

        private void chaqueÉtudiantToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ReportingEtudiant RE = new ReportingEtudiant();


            OpenForm(RE);
           CloseForm(RE);
        }

        private void tousLesÉtudiantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reporting r = new reporting();


            OpenForm(r);
          CloseForm(r);

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
           // CloseForm();
        }
        private void OpenForm(Form form)
        {
            try
            {
                bool isOpen = false;
                foreach (Form f in Application.OpenForms)
                {
                    if (isOpen == true)
                    {
                        f.Focus();
                        break;
                    }
                }
                if (isOpen == false)
                {
                    form.MdiParent = this;
                    form.Show();

                }
            }

            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void CloseForm(Form f)
        {
            foreach(Form  frm in this.MdiChildren)
            {
                if (frm!=f)
                {
                    frm.Visible = false;
                    frm.Dispose();
                }

            }
        }
    }
}
