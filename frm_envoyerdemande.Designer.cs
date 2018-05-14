namespace MEDESYS.IHM
{
    partial class frm_envoyerdemande
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
            this.lbl_destinataire = new System.Windows.Forms.Label();
            this.cmb_destinataire = new System.Windows.Forms.ComboBox();
            this.lbl_objet = new System.Windows.Forms.Label();
            this.txt_objet = new System.Windows.Forms.TextBox();
            this.txt_message = new System.Windows.Forms.TextBox();
            this.lbl_message = new System.Windows.Forms.Label();
            this.txt_ajouterpj = new System.Windows.Forms.TextBox();
            this.btn_ajouterpj = new System.Windows.Forms.Button();
            this.btn_envoyerdemande = new System.Windows.Forms.Button();
            this.btn_annulerdemande = new System.Windows.Forms.Button();
            this.grpb_demandeavis = new System.Windows.Forms.GroupBox();
            this.grpb_demandeavis.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_titre
            // 
            this.lbl_titre.BackColor = System.Drawing.Color.DarkCyan;
            this.lbl_titre.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_titre.Location = new System.Drawing.Point(1, 9);
            this.lbl_titre.Name = "lbl_titre";
            this.lbl_titre.Size = new System.Drawing.Size(799, 34);
            this.lbl_titre.TabIndex = 0;
            this.lbl_titre.Text = "Envoyer une demande d\'avis";
            this.lbl_titre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_titre.Click += new System.EventHandler(this.lbl_titre_Click);
            // 
            // lbl_destinataire
            // 
            this.lbl_destinataire.AutoSize = true;
            this.lbl_destinataire.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_destinataire.Location = new System.Drawing.Point(68, 110);
            this.lbl_destinataire.Name = "lbl_destinataire";
            this.lbl_destinataire.Size = new System.Drawing.Size(104, 23);
            this.lbl_destinataire.TabIndex = 1;
            this.lbl_destinataire.Text = "Destinataire";
            // 
            // cmb_destinataire
            // 
            this.cmb_destinataire.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_destinataire.FormattingEnabled = true;
            this.cmb_destinataire.Location = new System.Drawing.Point(211, 110);
            this.cmb_destinataire.Name = "cmb_destinataire";
            this.cmb_destinataire.Size = new System.Drawing.Size(497, 27);
            this.cmb_destinataire.TabIndex = 2;
            this.cmb_destinataire.SelectedIndexChanged += new System.EventHandler(this.cmb_destinataire_SelectedIndexChanged);
            // 
            // lbl_objet
            // 
            this.lbl_objet.AutoSize = true;
            this.lbl_objet.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_objet.Location = new System.Drawing.Point(68, 156);
            this.lbl_objet.Name = "lbl_objet";
            this.lbl_objet.Size = new System.Drawing.Size(53, 23);
            this.lbl_objet.TabIndex = 3;
            this.lbl_objet.Text = "Objet";
            // 
            // txt_objet
            // 
            this.txt_objet.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_objet.Location = new System.Drawing.Point(211, 153);
            this.txt_objet.Name = "txt_objet";
            this.txt_objet.Size = new System.Drawing.Size(497, 31);
            this.txt_objet.TabIndex = 4;
            // 
            // txt_message
            // 
            this.txt_message.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_message.Location = new System.Drawing.Point(72, 233);
            this.txt_message.Multiline = true;
            this.txt_message.Name = "txt_message";
            this.txt_message.Size = new System.Drawing.Size(636, 88);
            this.txt_message.TabIndex = 5;
            // 
            // lbl_message
            // 
            this.lbl_message.AutoSize = true;
            this.lbl_message.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_message.Location = new System.Drawing.Point(68, 198);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(78, 23);
            this.lbl_message.TabIndex = 6;
            this.lbl_message.Text = "Message";
            // 
            // txt_ajouterpj
            // 
            this.txt_ajouterpj.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ajouterpj.Location = new System.Drawing.Point(228, 280);
            this.txt_ajouterpj.Name = "txt_ajouterpj";
            this.txt_ajouterpj.Size = new System.Drawing.Size(438, 26);
            this.txt_ajouterpj.TabIndex = 8;
            this.txt_ajouterpj.TextChanged += new System.EventHandler(this.txt_ajouterpj_TextChanged);
            // 
            // btn_ajouterpj
            // 
            this.btn_ajouterpj.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajouterpj.Location = new System.Drawing.Point(72, 349);
            this.btn_ajouterpj.Name = "btn_ajouterpj";
            this.btn_ajouterpj.Size = new System.Drawing.Size(180, 25);
            this.btn_ajouterpj.TabIndex = 9;
            this.btn_ajouterpj.Text = "Ajouter une pièce jointe";
            this.btn_ajouterpj.UseVisualStyleBackColor = true;
            this.btn_ajouterpj.Click += new System.EventHandler(this.btn_ajouterpj_Click);
            // 
            // btn_envoyerdemande
            // 
            this.btn_envoyerdemande.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_envoyerdemande.Location = new System.Drawing.Point(454, 396);
            this.btn_envoyerdemande.Name = "btn_envoyerdemande";
            this.btn_envoyerdemande.Size = new System.Drawing.Size(157, 25);
            this.btn_envoyerdemande.TabIndex = 10;
            this.btn_envoyerdemande.Text = "Envoyer la demande";
            this.btn_envoyerdemande.UseVisualStyleBackColor = true;
            this.btn_envoyerdemande.Click += new System.EventHandler(this.btn_envoyerdemande_Click);
            // 
            // btn_annulerdemande
            // 
            this.btn_annulerdemande.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_annulerdemande.Location = new System.Drawing.Point(633, 396);
            this.btn_annulerdemande.Name = "btn_annulerdemande";
            this.btn_annulerdemande.Size = new System.Drawing.Size(75, 25);
            this.btn_annulerdemande.TabIndex = 11;
            this.btn_annulerdemande.Text = "Annuler";
            this.btn_annulerdemande.UseVisualStyleBackColor = true;
            this.btn_annulerdemande.Click += new System.EventHandler(this.btn_annulerdemande_Click);
            // 
            // grpb_demandeavis
            // 
            this.grpb_demandeavis.Controls.Add(this.txt_ajouterpj);
            this.grpb_demandeavis.Location = new System.Drawing.Point(42, 69);
            this.grpb_demandeavis.Name = "grpb_demandeavis";
            this.grpb_demandeavis.Size = new System.Drawing.Size(706, 369);
            this.grpb_demandeavis.TabIndex = 12;
            this.grpb_demandeavis.TabStop = false;
            // 
            // frm_envoyerdemande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_annulerdemande);
            this.Controls.Add(this.btn_envoyerdemande);
            this.Controls.Add(this.btn_ajouterpj);
            this.Controls.Add(this.lbl_message);
            this.Controls.Add(this.txt_message);
            this.Controls.Add(this.txt_objet);
            this.Controls.Add(this.lbl_objet);
            this.Controls.Add(this.cmb_destinataire);
            this.Controls.Add(this.lbl_destinataire);
            this.Controls.Add(this.lbl_titre);
            this.Controls.Add(this.grpb_demandeavis);
            this.IsMdiContainer = true;
            this.Name = "frm_envoyerdemande";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Envoyer une demande";
            this.Load += new System.EventHandler(this.frm_envoyerdemande_Load);
            this.grpb_demandeavis.ResumeLayout(false);
            this.grpb_demandeavis.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titre;
        private System.Windows.Forms.Label lbl_destinataire;
        private System.Windows.Forms.Label lbl_objet;
        private System.Windows.Forms.TextBox txt_objet;
        private System.Windows.Forms.TextBox txt_message;
        private System.Windows.Forms.Label lbl_message;
        private System.Windows.Forms.TextBox txt_ajouterpj;
        private System.Windows.Forms.Button btn_ajouterpj;
        private System.Windows.Forms.Button btn_envoyerdemande;
        private System.Windows.Forms.Button btn_annulerdemande;
        private System.Windows.Forms.GroupBox grpb_demandeavis;
        private System.Windows.Forms.ComboBox cmb_destinataire;
    }
}