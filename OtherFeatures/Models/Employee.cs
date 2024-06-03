using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtherFeatures
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Employee employee = (Employee)obj;
            return FirstName == employee.FirstName && LastName == employee.LastName;
        }
        public override int GetHashCode()
        {
            int hash = 17;
            hash = hash * 23 + (FirstName != null ? FirstName.GetHashCode() : 0);
            hash = hash * 23 + (LastName != null ? LastName.GetHashCode() : 0);
            return hash;
        }
    }
}
