namespace MEDESYS.IHM
{
    partial class frm_selectconsultation
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
            this.lbl_titre = new System.Windows.Forms.Label();
            this.lbl_infos = new System.Windows.Forms.Label();
            this.dgv_listeconsultations = new System.Windows.Forms.DataGridView();
            this.btn_selectconsultation = new System.Windows.Forms.Button();
            this.date_consultation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_consult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foyer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ecg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poids = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pression = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pression_arterielle_systolique = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pression_arterielle_diastolique = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obeservation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listeconsultations)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_titre
            // 
            this.lbl_titre.BackColor = System.Drawing.Color.DarkCyan;
            this.lbl_titre.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titre.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_titre.Location = new System.Drawing.Point(-3, 25);
            this.lbl_titre.Name = "lbl_titre";
            this.lbl_titre.Size = new System.Drawing.Size(451, 37);
            this.lbl_titre.TabIndex = 2;
            this.lbl_titre.Text = "Liste des Consultations";
            this.lbl_titre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_infos
            // 
            this.lbl_infos.AutoSize = true;
            this.lbl_infos.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_infos.Location = new System.Drawing.Point(31, 94);
            this.lbl_infos.Name = "lbl_infos";
            this.lbl_infos.Size = new System.Drawing.Size(383, 23);
            this.lbl_infos.TabIndex = 11;
            this.lbl_infos.Text = "Sélectionner la ou les consultation(s) à envoyer";
            this.lbl_infos.Click += new System.EventHandler(this.lbl_infos_Click);
            // 
            // dgv_listeconsultations
            // 
            this.dgv_listeconsultations.BackgroundColor = System.Drawing.Color.White;
            this.dgv_listeconsultations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listeconsultations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date_consultation,
            this.id_consult,
            this.foyer,
            this.phono,
            this.ecg,
            this.poids,
            this.pression,
            this.pression_arterielle_systolique,
            this.pression_arterielle_diastolique,
            this.obeservation});
            this.dgv_listeconsultations.Location = new System.Drawing.Point(101, 148);
            this.dgv_listeconsultations.Name = "dgv_listeconsultations";
            this.dgv_listeconsultations.Size = new System.Drawing.Size(240, 309);
            this.dgv_listeconsultations.TabIndex = 12;
            this.dgv_listeconsultations.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_listeconsultations_CellContentClick);
            // 
            // btn_selectconsultation
            // 
            this.btn_selectconsultation.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_selectconsultation.Location = new System.Drawing.Point(171, 490);
            this.btn_selectconsultation.Name = "btn_selectconsultation";
            this.btn_selectconsultation.Size = new System.Drawing.Size(96, 25);
            this.btn_selectconsultation.TabIndex = 13;
            this.btn_selectconsultation.Text = "Sélectionner";
            this.btn_selectconsultation.UseVisualStyleBackColor = true;
            this.btn_selectconsultation.Click += new System.EventHandler(this.btn_selectpatient_Click);
            // 
            // date_consultation
            // 
            this.date_consultation.DataPropertyName = "date_consultation";
            this.date_consultation.HeaderText = "Date de la consultation";
            this.date_consultation.Name = "date_consultation";
            this.date_consultation.ReadOnly = true;
            // 
            // id_consult
            // 
            this.id_consult.DataPropertyName = "id_consult";
            this.id_consult.HeaderText = "id_consult";
            this.id_consult.Name = "id_consult";
            this.id_consult.ReadOnly = true;
            this.id_consult.Visible = false;
            // 
            // foyer
            // 
            this.foyer.DataPropertyName = "foyer";
            this.foyer.HeaderText = "foyer";
            this.foyer.Name = "foyer";
            this.foyer.Visible = false;
            // 
            // phono
            // 
            this.phono.DataPropertyName = "phono";
            this.phono.HeaderText = "phono";
            this.phono.Name = "phono";
            this.phono.Visible = false;
            // 
            // ecg
            // 
            this.ecg.DataPropertyName = "ecg";
            this.ecg.HeaderText = "ecg";
            this.ecg.Name = "ecg";
            this.ecg.Visible = false;
            // 
            // poids
            // 
            this.poids.DataPropertyName = "poids";
            this.poids.HeaderText = "poids";
            this.poids.Name = "poids";
            this.poids.Visible = false;
            // 
            // pression
            // 
            this.pression.DataPropertyName = "pression";
            this.pression.HeaderText = "pression";
            this.pression.Name = "pression";
            this.pression.Visible = false;
            // 
            // pression_arterielle_systolique
            // 
            this.pression_arterielle_systolique.DataPropertyName = "pression_arterielle_systolique";
            this.pression_arterielle_systolique.HeaderText = "pression_arterielle_systolique";
            this.pression_arterielle_systolique.Name = "pression_arterielle_systolique";
            this.pression_arterielle_systolique.Visible = false;
            // 
            // pression_arterielle_diastolique
            // 
            this.pression_arterielle_diastolique.DataPropertyName = "pression_arterielle_diastolique";
            this.pression_arterielle_diastolique.HeaderText = "pression_arterielle_diastolique";
            this.pression_arterielle_diastolique.Name = "pression_arterielle_diastolique";
            this.pression_arterielle_diastolique.Visible = false;
            // 
            // obeservation
            // 
            this.obeservation.DataPropertyName = "obeservation";
            this.obeservation.HeaderText = "Observations";
            this.obeservation.MaxInputLength = 1000000000;
            this.obeservation.Name = "obeservation";
            this.obeservation.ReadOnly = true;
            // 
            // frm_selectconsultation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 546);
            this.Controls.Add(this.btn_selectconsultation);
            this.Controls.Add(this.dgv_listeconsultations);
            this.Controls.Add(this.lbl_infos);
            this.Controls.Add(this.lbl_titre);
            this.Name = "frm_selectconsultation";
            this.Text = "Sélection de la ou les consultations à envoyer";
            this.Load += new System.EventHandler(this.frm_selectconsultation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listeconsultations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titre;
        private System.Windows.Forms.Label lbl_infos;
        private System.Windows.Forms.DataGridView dgv_listeconsultations;
        private System.Windows.Forms.Button btn_selectconsultation;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_consultation;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_consult;
        private System.Windows.Forms.DataGridViewTextBoxColumn foyer;
        private System.Windows.Forms.DataGridViewTextBoxColumn phono;
        private System.Windows.Forms.DataGridViewTextBoxColumn ecg;
        private System.Windows.Forms.DataGridViewTextBoxColumn poids;
        private System.Windows.Forms.DataGridViewTextBoxColumn pression;
        private System.Windows.Forms.DataGridViewTextBoxColumn pression_arterielle_systolique;
        private System.Windows.Forms.DataGridViewTextBoxColumn pression_arterielle_diastolique;
        private System.Windows.Forms.DataGridViewTextBoxColumn obeservation;
    }
}