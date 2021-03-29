using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    public class SqlConnector : IDataCon
    {
        public ZamestnanciModel CreateZamestnanec(ZamestnanciModel model)
        {
            model.ID = 1;

            return model;
        }
    }
}
