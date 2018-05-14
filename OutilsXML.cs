using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using MEDESYS.BUSINESS_OBJECTS;

namespace MEDESYS.OUTILS
{
    public class OutilsXML
    {
        public string fctGenererXML(string p_filename, List<string> p_lst_datatosend)
        {
            
            FileStream myFileStream = new FileStream("C:\\Users\\esic\\Desktop\\MEDESYS\\xmlfiles\\" + p_filename, FileMode.Create);

            XmlTextWriter myXmlTextWriter = new XmlTextWriter(myFileStream, System.Text.Encoding.UTF8);

            myXmlTextWriter.Formatting = Formatting.Indented;

            myXmlTextWriter.WriteStartDocument(false);

            myXmlTextWriter.WriteComment("Fichier XML généré pour le transfert des données patient ");

            myXmlTextWriter.WriteStartElement("infos");
            myXmlTextWriter.WriteElementString("nom", p_lst_datatosend[0]);
            myXmlTextWriter.WriteElementString("prenom", p_lst_datatosend[1]);
            myXmlTextWriter.WriteElementString("idnational", p_lst_datatosend[2]);
            myXmlTextWriter.WriteElementString("ddn", p_lst_datatosend[3]);
            myXmlTextWriter.WriteElementString("sexe", p_lst_datatosend[4]);
            myXmlTextWriter.WriteElementString("adresse", p_lst_datatosend[5]);
            myXmlTextWriter.WriteElementString("tel", p_lst_datatosend[6]);
            myXmlTextWriter.WriteElementString("mob", p_lst_datatosend[7]);
            myXmlTextWriter.WriteElementString("antecedents", p_lst_datatosend[8]);
            
            myXmlTextWriter.Flush();
            myXmlTextWriter.Close();

            return "C:\\Users\\esic\\Desktop\\MEDESYS\\xmlfiles\\" + p_filename + ".xml";
        }

        public void fct_addtxtXML(string p_filename, List<Consultation> p_lst_datatosend)
        {
            
            FileStream myFileStream = new FileStream("C:\\Users\\esic\\Desktop\\MEDESYS\\xmlfiles\\" + p_filename, FileMode.Append);

            XmlTextWriter myXmlTextWriter = new XmlTextWriter(myFileStream, System.Text.Encoding.UTF8);

            myXmlTextWriter.Formatting = Formatting.Indented;

            myXmlTextWriter.WriteStartDocument(false);

            myXmlTextWriter.WriteStartElement("consultations");
            
            foreach (Consultation consultation in p_lst_datatosend)
            {
                myXmlTextWriter.WriteElementString("id_consult", consultation.id_consult);
                myXmlTextWriter.WriteElementString("date_consultation", consultation.date_consultation.ToString());
                myXmlTextWriter.WriteElementString("foyer", consultation.foyer);
                myXmlTextWriter.WriteElementString("phono", consultation.phono);
                myXmlTextWriter.WriteElementString("ecg", consultation.ecg);
                myXmlTextWriter.WriteElementString("poids", consultation.poids.ToString());
                myXmlTextWriter.WriteElementString("pression", consultation.pression.ToString());
                myXmlTextWriter.WriteElementString("pression_arterielle_systolique", consultation.pression_arterielle_systolique.ToString());
                myXmlTextWriter.WriteElementString("pression_arterielle_diastolique", consultation.pression_arterielle_diastolique.ToString());
                //myXmlTextWriter.WriteElementString("observations", consultation.obeservation);
            }
            
            myXmlTextWriter.Flush();
            myXmlTextWriter.Close();

            
        }

    }
}
