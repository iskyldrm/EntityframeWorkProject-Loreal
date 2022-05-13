using Loreal.BL.Abstract;
using Loreal.Dal.Contexts;
using Loreal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loreal.BL.Concrete
{
    public class BirimManager : ManagerBase<Birim, SqlDbContext>, IBirimManager
    {
        private bool BirimKodKontrol(Birim birim)
        {
            var result = base.db.Birimler.Where(p =>p.BirimKod == birim.BirimKod).FirstOrDefault();
            if (result == null) return false;
            return true;
        }
        public string BirSonrakiKoduVer()
        {
            var birim = base.db.Birimler.OrderByDescending(p => p.BirimKod).FirstOrDefault();
            if (birim != null)
            {
                return CreateCode(birim.BirimKod);
            }
            else
            {
                return "";
            }
        }

        public override int Add(Birim entity)
        {
            if(!BirimKodKontrol(entity))
            return base.Add(entity);
            else return -1;
            
        }

        private string CreateCode(string code)
        {
            var nums = "";
            foreach (var item in code)
            {
                if (Char.IsDigit(item))
                {
                    nums += Char.GetNumericValue(item);
                }
                else
                {
                    nums = "";
                }
            }
            var newNumber = nums == "" ? "1" : (long.Parse(nums) + 1).ToString();
            var diff = code.Length - newNumber.Length;
            if (diff < 0)
            {
                diff = 0;
            }
            string newCode = code.Substring(0, diff);
            newCode += newNumber;
            return newCode;
        }
    }
}
