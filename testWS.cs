using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MEDESYS.Messagerie;
using Message = MEDESYS.BUSINESS_OBJECTS.Message;
using ProfessionnelSante = MEDESYS.BUSINESS_OBJECTS.ProfessionnelSante;


namespace MEDESYS.IHM
{
    public partial class testWS : Form
    {
        public testWS()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessagerieService msgService = new MessagerieService();

            ProfessionnelSante ps = new ProfessionnelSante();

            ps.nom = msgService.getPS("023550f7-5362-11e8-91b0-dc4a3e459883").nom;

            textBox1.Text = ps.nom;
            textBox2.Text = "j'ai fini";


        }

        private void Call_Web_Service_Method()
        {



        }

        private void testWS_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessagerieService msgService = new MessagerieService();

            Message v_message_temp = new Message();

            if (v_message_temp.id_demande != null)
            {

            }

            List<Message> lst_msg = new List<Message>();
            MessageWS[] tab_msg;
            
            tab_msg = msgService.selectAllbyPS("023550f7-5362-11e8-91b0-dc4a3e459883"); 
            

            //foreach (MessageWS msgWS in tab_msg)
            //{
            //    Message message = new Message();
            //    message.id_message = msgWS.idMessage;
            //    message.date_message = (DateTime)msgWS.dateMessage;
            //    message.recu = msgWS.recu;
            //    message.txt_message = msgWS.texteMessage;
            //    message.xml = msgWS.xml;
            //    message.id_demande = msgWS.demande;
            //    message.id_dest = msgWS.destinataire;
            //    message.id_exp = msgWS.expediteur;
            //}

        }
    }
}
