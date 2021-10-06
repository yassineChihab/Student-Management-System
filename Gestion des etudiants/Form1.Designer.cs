
namespace Gestion_des_etudiants
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filiéreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.etidiantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statistiqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tousLesÉtudiantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chaqueÉtudiantToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filiéreToolStripMenuItem,
            this.etidiantToolStripMenuItem,
            this.statistiqueToolStripMenuItem,
            this.reportingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // filiéreToolStripMenuItem
            // 
            this.filiéreToolStripMenuItem.Name = "filiéreToolStripMenuItem";
            this.filiéreToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.filiéreToolStripMenuItem.Text = "Filiére";
            this.filiéreToolStripMenuItem.Click += new System.EventHandler(this.filiéreToolStripMenuItem_Click);
            // 
            // etidiantToolStripMenuItem
            // 
            this.etidiantToolStripMenuItem.Name = "etidiantToolStripMenuItem";
            this.etidiantToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.etidiantToolStripMenuItem.Text = "Etudiant";
            this.etidiantToolStripMenuItem.Click += new System.EventHandler(this.etidiantToolStripMenuItem_Click);
            // 
            // statistiqueToolStripMenuItem
            // 
            this.statistiqueToolStripMenuItem.Name = "statistiqueToolStripMenuItem";
            this.statistiqueToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.statistiqueToolStripMenuItem.Text = "Statistique";
            this.statistiqueToolStripMenuItem.Click += new System.EventHandler(this.statistiqueToolStripMenuItem_Click);
            // 
            // reportingToolStripMenuItem
            // 
            this.reportingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tousLesÉtudiantsToolStripMenuItem,
            this.chaqueÉtudiantToolStripMenuItem1});
            this.reportingToolStripMenuItem.Name = "reportingToolStripMenuItem";
            this.reportingToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.reportingToolStripMenuItem.Text = "Reporting";
            // 
            // tousLesÉtudiantsToolStripMenuItem
            // 
            this.tousLesÉtudiantsToolStripMenuItem.Name = "tousLesÉtudiantsToolStripMenuItem";
            this.tousLesÉtudiantsToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.tousLesÉtudiantsToolStripMenuItem.Text = "tous les étudiants";
            this.tousLesÉtudiantsToolStripMenuItem.Click += new System.EventHandler(this.tousLesÉtudiantsToolStripMenuItem_Click);
            // 
            // chaqueÉtudiantToolStripMenuItem1
            // 
            this.chaqueÉtudiantToolStripMenuItem1.Name = "chaqueÉtudiantToolStripMenuItem1";
            this.chaqueÉtudiantToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.chaqueÉtudiantToolStripMenuItem1.Text = "chaque étudiant";
            this.chaqueÉtudiantToolStripMenuItem1.Click += new System.EventHandler(this.chaqueÉtudiantToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Gestion_des_etudiants.Properties.Resources.student;
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion des étudiants";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filiéreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem etidiantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statistiqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tousLesÉtudiantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chaqueÉtudiantToolStripMenuItem1;
    }
}

