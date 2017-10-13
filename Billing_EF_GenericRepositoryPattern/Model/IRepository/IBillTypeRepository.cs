using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public interface IBillTypeRepository: IRepository<BillType>
    {
        BillType QueryByBillTypeName(string v_sValue);
    }
}
