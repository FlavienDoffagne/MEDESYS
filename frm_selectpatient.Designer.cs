namespace MEDESYS.IHM
{
    partial class frm_selectpatient
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
            this.dgv_listepatients = new System.Windows.Forms.DataGridView();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_patient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_nat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_naissance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.antecedents = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_ps = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_ville_residence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_ville_naissance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_titre = new System.Windows.Forms.Label();
            this.btn_selectpatient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listepatients)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_listepatients
            // 
            this.dgv_listepatients.BackgroundColor = System.Drawing.Color.White;
            this.dgv_listepatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listepatients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nom,
            this.id_patient,
            this.sexe,
            this.id_nat,
            this.date_naissance,
            this.adresse,
            this.mob,
            this.tel,
            this.antecedents,
            this.id_ps,
            this.id_ville_residence,
            this.id_ville_naissance,
            this.prenom});
            this.dgv_listepatients.Location = new System.Drawing.Point(99, 106);
            this.dgv_listepatients.Name = "dgv_listepatients";
            this.dgv_listepatients.Size = new System.Drawing.Size(243, 352);
            this.dgv_listepatients.TabIndex = 0;
            this.dgv_listepatients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_listepatients_CellContentClick);
            // 
            // nom
            // 
            this.nom.DataPropertyName = "nom";
            this.nom.HeaderText = "Nom";
            this.nom.Name = "nom";
            // 
            // id_patient
            // 
            this.id_patient.DataPropertyName = "id_patient";
            this.id_patient.HeaderText = "ID Patient";
            this.id_patient.Name = "id_patient";
            this.id_patient.Visible = false;
            // 
            // sexe
            // 
            this.sexe.DataPropertyName = "sexe";
            this.sexe.HeaderText = "Sexe";
            this.sexe.Name = "sexe";
            this.sexe.Visible = false;
            // 
            // id_nat
            // 
            this.id_nat.DataPropertyName = "id_nat";
            this.id_nat.HeaderText = "ID Nat";
            this.id_nat.Name = "id_nat";
            this.id_nat.Visible = false;
            // 
            // date_naissance
            // 
            this.date_naissance.DataPropertyName = "date_naissance";
            this.date_naissance.HeaderText = "Date de Naissance";
            this.date_naissance.Name = "date_naissance";
            this.date_naissance.Visible = false;
            // 
            // adresse
            // 
            this.adresse.DataPropertyName = "adresse";
            this.adresse.HeaderText = "Adresse";
            this.adresse.Name = "adresse";
            this.adresse.Visible = false;
            // 
            // mob
            // 
            this.mob.DataPropertyName = "mob";
            this.mob.HeaderText = "Mobile";
            this.mob.Name = "mob";
            this.mob.Visible = false;
            // 
            // tel
            // 
            this.tel.DataPropertyName = "tel";
            this.tel.HeaderText = "Fixe";
            this.tel.Name = "tel";
            this.tel.Visible = false;
            // 
            // antecedents
            // 
            this.antecedents.DataPropertyName = "antecedents";
            this.antecedents.HeaderText = "Antecedents";
            this.antecedents.Name = "antecedents";
            this.antecedents.Visible = false;
            // 
            // id_ps
            // 
            this.id_ps.DataPropertyName = "id_ps";
            this.id_ps.HeaderText = "ID PS";
            this.id_ps.Name = "id_ps";
            this.id_ps.Visible = false;
            // 
            // id_ville_residence
            // 
            this.id_ville_residence.DataPropertyName = "id_ville_residence";
            this.id_ville_residence.HeaderText = "ID Ville Résidence";
            this.id_ville_residence.Name = "id_ville_residence";
            this.id_ville_residence.Visible = false;
            // 
            // id_ville_naissance
            // 
            this.id_ville_naissance.DataPropertyName = "id_ville_naissance";
            this.id_ville_naissance.HeaderText = "ID Ville Naissance";
            this.id_ville_naissance.Name = "id_ville_naissance";
            this.id_ville_naissance.Visible = false;
            // 
            // prenom
            // 
            this.prenom.DataPropertyName = "prenom";
            this.prenom.HeaderText = "Prénom";
            this.prenom.Name = "prenom";
            // 
            // lbl_titre
            // 
            this.lbl_titre.BackColor = System.Drawing.Color.DarkCyan;
            this.lbl_titre.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titre.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_titre.Location = new System.Drawing.Point(-3, 25);
            this.lbl_titre.Name = "lbl_titre";
            this.lbl_titre.Size = new System.Drawing.Size(451, 37);
            this.lbl_titre.TabIndex = 1;
            this.lbl_titre.Text = "Liste des Patients";
            this.lbl_titre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_selectpatient
            // 
            this.btn_selectpatient.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_selectpatient.Location = new System.Drawing.Point(171, 490);
            this.btn_selectpatient.Name = "btn_selectpatient";
            this.btn_selectpatient.Size = new System.Drawing.Size(96, 25);
            this.btn_selectpatient.TabIndex = 2;
            this.btn_selectpatient.Text = "Sélectionner";
            this.btn_selectpatient.UseVisualStyleBackColor = true;
            this.btn_selectpatient.Click += new System.EventHandler(this.btn_selectpatient_Click);
            // 
            // frm_selectpatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 546);
            this.Controls.Add(this.btn_selectpatient);
            this.Controls.Add(this.lbl_titre);
            this.Controls.Add(this.dgv_listepatients);
            this.Name = "frm_selectpatient";
            this.Text = "Sélection du patient";
            this.Load += new System.EventHandler(this.frm_selectpatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listepatients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_listepatients;
        private System.Windows.Forms.Label lbl_titre;
        private System.Windows.Forms.Button btn_selectpatient;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_patient;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexe;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_nat;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_naissance;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn mob;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn antecedents;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_ps;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_ville_residence;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_ville_naissance;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenom;
    }
}