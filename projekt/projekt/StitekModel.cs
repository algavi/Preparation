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
        public enum jazyk
        {
            CZ,
            EN
        }
        public int pocetStudentu { get; set; }
        public int pocetHodin { get; set; }
        public int pocetTydnu { get; set; }

        /*Počet bodů za pracovní štítek – int – 12.5 (Toto nebude vlastnost, ale metoda.)*/
    }
}
