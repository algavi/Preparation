using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    public class PredmetModel
    {
        public string zkratka { get; set; }
        public int pocetTydnu { get; set; }
        public int velikostTridy { get; set; }
        public int hodinPrednasek { get; set; }
        public int hodinCviceni { get; set; }
        public int hodinSeminaru { get; set; }
        public enum zakonceni { 
           z,
           zk
        }
        public enum jazyk {
            CZ,
            EN
        }
        public List<SkupinaModel> seznamSkupin { get; set; } = new List<SkupinaModel>();
    }
}
