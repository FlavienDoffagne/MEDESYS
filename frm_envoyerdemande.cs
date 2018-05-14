using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MEDESYS.BUSINESS_OBJECTS;
using MEDESYS.METIER;
using MEDESYS.OUTILS;
using Microsoft.Build.Framework;

namespace MEDESYS.IHM
{
    public partial class frm_envoyerdemande : Form
    {
        public frm_envoyerdemande()
        {
            InitializeComponent();
        }

        private void lbl_titre_Click(object sender, EventArgs e)
        {

        }

        private void frm_envoyerdemande_Load(object sender, EventArgs e)
        {
            List<ProfessionnelSante> lst_ps = new List<ProfessionnelSante>();
            PSMetier psMetier = new PSMetier();
            lst_ps = psMetier.selectAllPS();

            foreach (ProfessionnelSante ps in lst_ps)
            {
                this.cmb_destinataire.Items.Add(ps.nom + " " + ps.prenom);
            }
        }

        private void btn_annulerdemande_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btn_envoyerdemande_Click(object sender, EventArgs e)
        {
            string v_destinataire = cmb_destinataire.Text;
            string v_objet = txt_objet.Text;
            string v_message = txt_message.Text;
            string v_xmlpath = txt_ajouterpj.Text;

            OutilsTexte outilstxt = new OutilsTexte();
            outilstxt.fctGenererTexte("demande" + "-" + DateTime.Now.Hour + "-" + DateTime.Now.Minute + "-" + DateTime.Now.Second, v_destinataire, v_objet, v_message);



            if (cmb_destinataire.Text.Trim() == "")
            {
            
                MessageBox.Show("Veuillez remplir le champ destinataire",
                    "Critical Warning",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RightAlign,
                    true);
            }
            else
            {
                MessageBox.Show("Message envoyé");
            }
        }

        private void btn_ajouterpj_Click(object sender, EventArgs e)
        {
            frm_selectpatient v_formpatient = new frm_selectpatient();
            v_formpatient.Show();
        }

        private void txt_ajouterpj_TextChanged(object sender, EventArgs e)
        {

        }

        public delegate void delegateUpdateTextBox(string text);
        public void updateTextBox(string text)
        {
            if (this.InvokeRequired)
            {
                delegateUpdateTextBox deleg = new delegateUpdateTextBox(this.updateTextBox);
                this.Invoke(deleg, new object[] { text });
            }
            else
            {
                this.txt_ajouterpj.Text = text;
            }
        }

        
        private void cmb_destinataire_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
