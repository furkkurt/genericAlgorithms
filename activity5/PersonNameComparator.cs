using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using activity5;

namespace algorithms
{
    internal class PersonNameComparator : IEqualsPredicate
    {
        public bool CompareTo(object a, object b)
        {
            Person p1 = a as Person;
            Person p2 = b as Person;
            if (p1 == null || p2 == null)
                return false;
            return p1.FirstName.Equals(p2.FirstName);
        }
       
    }
}