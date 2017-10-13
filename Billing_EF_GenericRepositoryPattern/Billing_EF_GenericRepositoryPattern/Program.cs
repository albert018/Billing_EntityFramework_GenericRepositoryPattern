using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing_EF_GenericRepositoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var BillTag = new BillTagMantain();
            var R = BillTag.QueryAll();
            foreach (var item in R)
            {
                Console.WriteLine(item.BillTagName);
            }
            //Console.WriteLine(R.BillTagName);
            Console.ReadLine();
        }
    }
}
