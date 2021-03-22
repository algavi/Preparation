using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    public class TeamModel
    {
        public PredmetModel list1 { get; set; }
        public SkupinaModel list2 { get; set; }
        public StitekModel list3 { get; set; }
        public ZamestnanciModel list4 { get; set; }



        public TeamModel() {
            Console.WriteLine();
        
        }
    }
}
