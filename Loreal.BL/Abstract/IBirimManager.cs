using Loreal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loreal.BL.Abstract
{
    public interface IBirimManager:IManagerBase<Birim>
    {
        string BirSonrakiKoduVer();
    }
}
