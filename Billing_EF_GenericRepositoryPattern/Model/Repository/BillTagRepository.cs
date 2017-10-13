using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Model
{
    public class BillTagRepository: GenericRepository<BillTag>, IBillTagRepository
    {
        public BillTagRepository(DbContext v_Value)
            :base(v_Value)
        {
            
        }

        public BillTag QueryByBillTagName(string v_sValue)
        {
            return base.Query(x => x.BillTagName == v_sValue);
        }
    }
}
