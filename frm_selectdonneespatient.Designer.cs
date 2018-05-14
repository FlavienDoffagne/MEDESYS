namespace MEDESYS.IHM
{
    partial class frm_selectdonneespatient
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
            this.grpb_selectdonneespatient = new System.Windows.Forms.GroupBox();
            this.chk_selectall = new System.Windows.Forms.CheckBox();
            this.lbl_infos = new System.Windows.Forms.Label();
            this.chk_consultations = new System.Windows.Forms.CheckBox();
            this.chk_antecedentspatient = new System.Windows.Forms.CheckBox();
            this.chk_mobilepatient = new System.Windows.Forms.CheckBox();
            this.chk_telpatient = new System.Windows.Forms.CheckBox();
            this.chk_adressepatient = new System.Windows.Forms.CheckBox();
            this.chk_sexe = new System.Windows.Forms.CheckBox();
            this.chk_ddn = new System.Windows.Forms.CheckBox();
            this.chk_idnational = new System.Windows.Forms.CheckBox();
            this.chk_prenompatient = new System.Windows.Forms.CheckBox();
            this.chk_nompatient = new System.Windows.Forms.CheckBox();
            this.btn_selectdonneespatient = new System.Windows.Forms.Button();
            this.btn_retour = new System.Windows.Forms.Button();
            this.grpb_selectdonneespatient.SuspendLayout();
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
            this.lbl_titre.Text = "Sélection des données";
            this.lbl_titre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpb_selectdonneespatient
            // 
            this.grpb_selectdonneespatient.Controls.Add(this.chk_selectall);
            this.grpb_selectdonneespatient.Controls.Add(this.lbl_infos);
            this.grpb_selectdonneespatient.Controls.Add(this.chk_consultations);
            this.grpb_selectdonneespatient.Controls.Add(this.chk_antecedentspatient);
            this.grpb_selectdonneespatient.Controls.Add(this.chk_mobilepatient);
            this.grpb_selectdonneespatient.Controls.Add(this.chk_telpatient);
            this.grpb_selectdonneespatient.Controls.Add(this.chk_adressepatient);
            this.grpb_selectdonneespatient.Controls.Add(this.chk_sexe);
            this.grpb_selectdonneespatient.Controls.Add(this.chk_ddn);
            this.grpb_selectdonneespatient.Controls.Add(this.chk_idnational);
            this.grpb_selectdonneespatient.Controls.Add(this.chk_prenompatient);
            this.grpb_selectdonneespatient.Controls.Add(this.chk_nompatient);
            this.grpb_selectdonneespatient.Location = new System.Drawing.Point(32, 90);
            this.grpb_selectdonneespatient.Name = "grpb_selectdonneespatient";
            this.grpb_selectdonneespatient.Size = new System.Drawing.Size(371, 388);
            this.grpb_selectdonneespatient.TabIndex = 3;
            this.grpb_selectdonneespatient.TabStop = false;
            this.grpb_selectdonneespatient.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // chk_selectall
            // 
            this.chk_selectall.AutoSize = true;
            this.chk_selectall.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_selectall.Location = new System.Drawing.Point(38, 54);
            this.chk_selectall.Name = "chk_selectall";
            this.chk_selectall.Size = new System.Drawing.Size(138, 23);
            this.chk_selectall.TabIndex = 11;
            this.chk_selectall.Text = "Sélectionner tout";
            this.chk_selectall.UseVisualStyleBackColor = true;
            this.chk_selectall.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lbl_infos
            // 
            this.lbl_infos.AutoSize = true;
            this.lbl_infos.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_infos.Location = new System.Drawing.Point(35, 16);
            this.lbl_infos.Name = "lbl_infos";
            this.lbl_infos.Size = new System.Drawing.Size(291, 23);
            this.lbl_infos.TabIndex = 10;
            this.lbl_infos.Text = "Sélectionner les données à envoyer";
            // 
            // chk_consultations
            // 
            this.chk_consultations.AutoSize = true;
            this.chk_consultations.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_consultations.Location = new System.Drawing.Point(39, 344);
            this.chk_consultations.Name = "chk_consultations";
            this.chk_consultations.Size = new System.Drawing.Size(127, 23);
            this.chk_consultations.TabIndex = 9;
            this.chk_consultations.Text = "Consultation(s)";
            this.chk_consultations.UseVisualStyleBackColor = true;
            // 
            // chk_antecedentspatient
            // 
            this.chk_antecedentspatient.AutoSize = true;
            this.chk_antecedentspatient.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_antecedentspatient.Location = new System.Drawing.Point(39, 315);
            this.chk_antecedentspatient.Name = "chk_antecedentspatient";
            this.chk_antecedentspatient.Size = new System.Drawing.Size(109, 23);
            this.chk_antecedentspatient.TabIndex = 8;
            this.chk_antecedentspatient.Text = "Antécédents";
            this.chk_antecedentspatient.UseVisualStyleBackColor = true;
            // 
            // chk_mobilepatient
            // 
            this.chk_mobilepatient.AutoSize = true;
            this.chk_mobilepatient.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_mobilepatient.Location = new System.Drawing.Point(39, 286);
            this.chk_mobilepatient.Name = "chk_mobilepatient";
            this.chk_mobilepatient.Size = new System.Drawing.Size(73, 23);
            this.chk_mobilepatient.TabIndex = 7;
            this.chk_mobilepatient.Text = "Mobile";
            this.chk_mobilepatient.UseVisualStyleBackColor = true;
            // 
            // chk_telpatient
            // 
            this.chk_telpatient.AutoSize = true;
            this.chk_telpatient.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_telpatient.Location = new System.Drawing.Point(39, 257);
            this.chk_telpatient.Name = "chk_telpatient";
            this.chk_telpatient.Size = new System.Drawing.Size(95, 23);
            this.chk_telpatient.TabIndex = 6;
            this.chk_telpatient.Text = "Téléphone";
            this.chk_telpatient.UseVisualStyleBackColor = true;
            // 
            // chk_adressepatient
            // 
            this.chk_adressepatient.AutoSize = true;
            this.chk_adressepatient.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_adressepatient.Location = new System.Drawing.Point(39, 228);
            this.chk_adressepatient.Name = "chk_adressepatient";
            this.chk_adressepatient.Size = new System.Drawing.Size(167, 23);
            this.chk_adressepatient.TabIndex = 5;
            this.chk_adressepatient.Text = "Adresse de résidence";
            this.chk_adressepatient.UseVisualStyleBackColor = true;
            // 
            // chk_sexe
            // 
            this.chk_sexe.AutoSize = true;
            this.chk_sexe.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_sexe.Location = new System.Drawing.Point(39, 199);
            this.chk_sexe.Name = "chk_sexe";
            this.chk_sexe.Size = new System.Drawing.Size(58, 23);
            this.chk_sexe.TabIndex = 4;
            this.chk_sexe.Text = "Sexe";
            this.chk_sexe.UseVisualStyleBackColor = true;
            // 
            // chk_ddn
            // 
            this.chk_ddn.AutoSize = true;
            this.chk_ddn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_ddn.Location = new System.Drawing.Point(39, 170);
            this.chk_ddn.Name = "chk_ddn";
            this.chk_ddn.Size = new System.Drawing.Size(148, 23);
            this.chk_ddn.TabIndex = 3;
            this.chk_ddn.Text = "Date de naissance";
            this.chk_ddn.UseVisualStyleBackColor = true;
            // 
            // chk_idnational
            // 
            this.chk_idnational.AutoSize = true;
            this.chk_idnational.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_idnational.Location = new System.Drawing.Point(39, 141);
            this.chk_idnational.Name = "chk_idnational";
            this.chk_idnational.Size = new System.Drawing.Size(151, 23);
            this.chk_idnational.TabIndex = 2;
            this.chk_idnational.Text = "Identifiant national";
            this.chk_idnational.UseVisualStyleBackColor = true;
            // 
            // chk_prenompatient
            // 
            this.chk_prenompatient.AutoSize = true;
            this.chk_prenompatient.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_prenompatient.Location = new System.Drawing.Point(39, 112);
            this.chk_prenompatient.Name = "chk_prenompatient";
            this.chk_prenompatient.Size = new System.Drawing.Size(147, 23);
            this.chk_prenompatient.TabIndex = 1;
            this.chk_prenompatient.Text = "Prénom du patient";
            this.chk_prenompatient.UseVisualStyleBackColor = true;
            // 
            // chk_nompatient
            // 
            this.chk_nompatient.AutoSize = true;
            this.chk_nompatient.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_nompatient.Location = new System.Drawing.Point(39, 83);
            this.chk_nompatient.Name = "chk_nompatient";
            this.chk_nompatient.Size = new System.Drawing.Size(128, 23);
            this.chk_nompatient.TabIndex = 0;
            this.chk_nompatient.Text = "Nom du patient";
            this.chk_nompatient.UseVisualStyleBackColor = true;
            // 
            // btn_selectdonneespatient
            // 
            this.btn_selectdonneespatient.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_selectdonneespatient.Location = new System.Drawing.Point(149, 497);
            this.btn_selectdonneespatient.Name = "btn_selectdonneespatient";
            this.btn_selectdonneespatient.Size = new System.Drawing.Size(136, 25);
            this.btn_selectdonneespatient.TabIndex = 4;
            this.btn_selectdonneespatient.Text = "Valider la sélection";
            this.btn_selectdonneespatient.UseVisualStyleBackColor = true;
            this.btn_selectdonneespatient.Click += new System.EventHandler(this.btn_selectdonneespatient_Click);
            // 
            // btn_retour
            // 
            this.btn_retour.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_retour.Location = new System.Drawing.Point(313, 497);
            this.btn_retour.Name = "btn_retour";
            this.btn_retour.Size = new System.Drawing.Size(61, 25);
            this.btn_retour.TabIndex = 5;
            this.btn_retour.Text = "Retour";
            this.btn_retour.UseVisualStyleBackColor = true;
            this.btn_retour.Click += new System.EventHandler(this.btn_retour_Click);
            // 
            // frm_selectdonneespatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 546);
            this.Controls.Add(this.btn_retour);
            this.Controls.Add(this.btn_selectdonneespatient);
            this.Controls.Add(this.grpb_selectdonneespatient);
            this.Controls.Add(this.lbl_titre);
            this.Name = "frm_selectdonneespatient";
            this.Text = "Sélection des données à envoyer";
            this.Load += new System.EventHandler(this.frm_selectdonneespatient_Load);
            this.grpb_selectdonneespatient.ResumeLayout(false);
            this.grpb_selectdonneespatient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_titre;
        private System.Windows.Forms.GroupBox grpb_selectdonneespatient;
        private System.Windows.Forms.Button btn_selectdonneespatient;
        private System.Windows.Forms.CheckBox chk_antecedentspatient;
        private System.Windows.Forms.CheckBox chk_mobilepatient;
        private System.Windows.Forms.CheckBox chk_telpatient;
        private System.Windows.Forms.CheckBox chk_adressepatient;
        private System.Windows.Forms.CheckBox chk_sexe;
        private System.Windows.Forms.CheckBox chk_ddn;
        private System.Windows.Forms.CheckBox chk_idnational;
        private System.Windows.Forms.CheckBox chk_prenompatient;
        private System.Windows.Forms.CheckBox chk_nompatient;
        private System.Windows.Forms.Label lbl_infos;
        private System.Windows.Forms.CheckBox chk_consultations;
        private System.Windows.Forms.Button btn_retour;
        private System.Windows.Forms.CheckBox chk_selectall;
    }
}