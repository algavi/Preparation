using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    public class SkupinaModel
    {
        public string zkratka { get; set; }
        public int rocnik { get; set; }
        public int pocetStudentu { get; set; }
        public enum semestr { ls, zs }
        public enum formaStudia { p,k }
        public enum typStudia { bc,mag,dok }
        public enum jazyk { cz, en }

    }
}
