using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    public static class GlobalCon
    {
        public static List<IDataCon> conects { get; private set; } = new List<IDataCon>();


        public static void IntCon(bool databse, bool dataFiles)
        {
            if(databse) {
                SqlConnector sql = new SqlConnector();
                conects.Add(sql);
            }
            if(dataFiles)
            {
                TextConnector text = new TextConnector();
                conects.Add(text);
            }
        }
    }
}
