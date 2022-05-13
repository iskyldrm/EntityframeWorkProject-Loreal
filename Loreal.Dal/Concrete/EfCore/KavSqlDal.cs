using CoreRepository;
using Loreal.Dal.Abstract;
using Loreal.Dal.Contexts;
using Loreal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loreal.Dal.Concrete
{
    public class KavSqlDal:RepositoryBase<Kdv,SqlDbContext>,IKdvDAL
    {
    }
}
