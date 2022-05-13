using CoreRepository;
using Loreal.DAL.Contexts;
using Loreal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loreal.Dal.Concrete.PostgreSql
{
    public class BirimPostgreDAL:RepositoryBase<Birim,PostgreDbContext>,IEntity
    {
    }
}
