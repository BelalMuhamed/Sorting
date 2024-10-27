using Shared;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderByCompare
{
    internal class EmployeeCompare : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
           var e1year = Convert.ToInt32(x.EmployeeNo.Split('-')[0]);
            var e2year = Convert.ToInt32(y.EmployeeNo.Split("-")[0]);
            var e1Seq= Convert.ToInt32(x.EmployeeNo.Split('-')[2]);
            var e2Seq = Convert.ToInt32(x.EmployeeNo.Split('-')[2]);
            if(e1year == e2year )
            {
                return (e1Seq.CompareTo(e2Seq));
            }
            else
            {
                return(e1year.CompareTo(e2year));
            }
        }
    }
}
