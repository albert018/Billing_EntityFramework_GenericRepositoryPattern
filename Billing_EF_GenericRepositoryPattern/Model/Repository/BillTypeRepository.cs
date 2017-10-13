using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Model
{
    public class BillTypeRepository: GenericRepository<BillType>, IBillTypeRepository
    {
        public BillTypeRepository(DbContext v_Value)
            : base(v_Value) { }

        public BillType QueryByBillTypeName(string v_sValue)
        {
            return base.Query(x => x.BillTypeName == v_sValue);
        }
    }
}
