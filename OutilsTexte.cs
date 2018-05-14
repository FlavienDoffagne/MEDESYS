using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEDESYS.OUTILS
{
    public class OutilsTexte
    {

        public void fctGenererTexte(string p_filename, string p_destinataire, string p_objet, string p_message)
        {
            StreamWriter sw = new StreamWriter("C:\\Users\\esic\\Desktop\\MEDESYS\\txtfiles\\" + p_filename + ".txt");

            sw.WriteLine("destinataire : " + p_destinataire);
            sw.WriteLine("objet : " + p_objet);
            sw.WriteLine("message : " + p_message);
            sw.WriteLine("/end");
            sw.Close();
        }
    }
}
