using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Model;

namespace Billing_EF_GenericRepositoryPattern
{
    public class BillTagMantain
    {
        IBillTagRepository _Repo;

        public BillTagMantain():this(new BillTagRepository(new BillingEntities()))
        {
        }

        public BillTagMantain(IBillTagRepository v_Value)
        {
            _Repo = v_Value;
        }

        public void Create(BillTag v_Value)
        {
            _Repo.Create(v_Value);
        }

        public BillTag QueryByBillTagName(string v_sValue)
        {
            return _Repo.QueryByBillTagName(v_sValue);
        }

        public IEnumerable<BillTag> QueryAll()
        {
            return _Repo.QueryAll();
        }

        public void Delete(string v_sValue)
        {
            var Q = _Repo.QueryByBillTagName(v_sValue);
            _Repo.Delete(Q);
        }

        public void Update(BillTag v_Value)
        {
            _Repo.Update(v_Value);
        }
    }
}
