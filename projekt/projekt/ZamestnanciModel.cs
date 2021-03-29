using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    public class ZamestnanciModel
    {
        public int ID { get; set; }
        public string jmeno { get; set; }
        public string prijmeni { get; set; }
        public string celeJmeno { get; set; } /*na toto se podivat jesti to nejde spojit jmeno a prijmeni nez vytvaet nove*/
        public string verjnyEmail { get; set; }
        public string soukromíEmail { get; set; }
        /*
         
         Pracovní body bez angličtiny – int – 526 (Toto nebude vlastnost, ale metoda.)
Pracovní body – int – 767 (Toto nebude vlastnost, ale metoda.) ??????????

         
         */
        public bool doktorand { get; set; }
        public double uvazek { get; set; }
        public List<StitekModel> seznamStitku { get; set; } = new List<StitekModel>();

    }
}
