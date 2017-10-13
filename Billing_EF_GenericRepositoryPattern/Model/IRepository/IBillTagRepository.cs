using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public interface IBillTagRepository: IRepository<BillTag>
    {
        BillTag QueryByBillTagName(string v_sValue);
    }
}
