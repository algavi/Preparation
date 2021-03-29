using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    public interface IDataCon
    {
        ZamestnanciModel CreateZamestnanec(ZamestnanciModel model);
    }
}
