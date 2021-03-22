using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    public class StitekModel
    {
        public string nazev { get; set; }
        public enum typ {
            prednska,
            cviceni,
            seminar,
            zapocet,
            klasak,
            zkouska
        }
        public int pocetStudentu { get; set; }
    }
}
