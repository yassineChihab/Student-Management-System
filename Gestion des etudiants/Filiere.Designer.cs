
namespace Gestion_des_etudiants
{
    partial class Filiere
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddFiliere = new System.Windows.Forms.Button();
            this.inputFiliere = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvFiliere = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdateFiliere = new System.Windows.Forms.Button();
            this.btnDeleteFiliere = new System.Windows.Forms.Button();
            this.panelModifier = new System.Windows.Forms.Panel();
            this.update = new System.Windows.Forms.Button();
            this.txtNewFiliere = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiliere)).BeginInit();
            this.panelModifier.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddFiliere);
            this.groupBox1.Controls.Add(this.inputFiliere);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(25, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 232);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ajouter une Filière";
            // 
            // btnAddFiliere
            // 
            this.btnAddFiliere.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFiliere.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddFiliere.Location = new System.Drawing.Point(83, 102);
            this.btnAddFiliere.Name = "btnAddFiliere";
            this.btnAddFiliere.Size = new System.Drawing.Size(139, 31);
            this.btnAddFiliere.TabIndex = 2;
            this.btnAddFiliere.Text = "Ajouter";
            this.btnAddFiliere.UseVisualStyleBackColor = true;
            this.btnAddFiliere.Click += new System.EventHandler(this.btnAddFiliere_Click);
            // 
            // inputFiliere
            // 
            this.inputFiliere.Location = new System.Drawing.Point(157, 46);
            this.inputFiliere.Name = "inputFiliere";
            this.inputFiliere.Size = new System.Drawing.Size(145, 31);
            this.inputFiliere.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(19, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom de filière : ";
            // 
            // dgvFiliere
            // 
            this.dgvFiliere.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFiliere.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiliere.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nom});
            this.dgvFiliere.Location = new System.Drawing.Point(439, 63);
            this.dgvFiliere.Name = "dgvFiliere";
            this.dgvFiliere.Size = new System.Drawing.Size(328, 192);
            this.dgvFiliere.TabIndex = 1;
            this.dgvFiliere.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFiliere_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id_Filiére";
            this.Id.Name = "Id";
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom_Filiére";
            this.Nom.Name = "Nom";
            // 
            // btnUpdateFiliere
            // 
            this.btnUpdateFiliere.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateFiliere.Location = new System.Drawing.Point(451, 295);
            this.btnUpdateFiliere.Name = "btnUpdateFiliere";
            this.btnUpdateFiliere.Size = new System.Drawing.Size(100, 23);
            this.btnUpdateFiliere.TabIndex = 2;
            this.btnUpdateFiliere.Text = "Modifier";
            this.btnUpdateFiliere.UseVisualStyleBackColor = true;
            this.btnUpdateFiliere.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDeleteFiliere
            // 
            this.btnDeleteFiliere.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteFiliere.Location = new System.Drawing.Point(601, 295);
            this.btnDeleteFiliere.Name = "btnDeleteFiliere";
            this.btnDeleteFiliere.Size = new System.Drawing.Size(100, 23);
            this.btnDeleteFiliere.TabIndex = 3;
            this.btnDeleteFiliere.Text = "Supprimer";
            this.btnDeleteFiliere.UseVisualStyleBackColor = true;
            this.btnDeleteFiliere.Click += new System.EventHandler(this.button3_Click);
            // 
            // panelModifier
            // 
            this.panelModifier.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelModifier.Controls.Add(this.update);
            this.panelModifier.Controls.Add(this.txtNewFiliere);
            this.panelModifier.Controls.Add(this.label2);
            this.panelModifier.Location = new System.Drawing.Point(439, 134);
            this.panelModifier.Name = "panelModifier";
            this.panelModifier.Size = new System.Drawing.Size(302, 100);
            this.panelModifier.TabIndex = 4;
            this.panelModifier.Visible = false;
            // 
            // update
            // 
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Location = new System.Drawing.Point(99, 63);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(100, 23);
            this.update.TabIndex = 5;
            this.update.Text = "Valider";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // txtNewFiliere
            // 
            this.txtNewFiliere.Location = new System.Drawing.Point(141, 21);
            this.txtNewFiliere.Name = "txtNewFiliere";
            this.txtNewFiliere.Size = new System.Drawing.Size(147, 20);
            this.txtNewFiliere.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nouveau Nom :";
            // 
            // Filiere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Controls.Add(this.panelModifier);
            this.Controls.Add(this.btnDeleteFiliere);
            this.Controls.Add(this.btnUpdateFiliere);
            this.Controls.Add(this.dgvFiliere);
            this.Controls.Add(this.groupBox1);
            this.Name = "Filiere";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Filiere";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Filiere_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiliere)).EndInit();
            this.panelModifier.ResumeLayout(false);
            this.panelModifier.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddFiliere;
        private System.Windows.Forms.TextBox inputFiliere;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvFiliere;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.Button btnUpdateFiliere;
        private System.Windows.Forms.Button btnDeleteFiliere;
        private System.Windows.Forms.Panel panelModifier;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.TextBox txtNewFiliere;
        private System.Windows.Forms.Label label2;
    }
}