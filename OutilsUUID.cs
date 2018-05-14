using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEDESYS.OUTILS
{
    public class OutilsUUID
    {
        public static string generateUUID()
        {
            Guid id = Guid.NewGuid();
            return id.ToString() ;
        }

    }
}
