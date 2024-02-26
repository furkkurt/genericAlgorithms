using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using activity5;

namespace algorithms
{
    internal class AngleComparator : IEqualsPredicate
    {
        public bool CompareTo(object a, object b)
        {
            Angle a1 = a as Angle;
            Angle a2 = b as Angle;
            if (a1 == null || a2 == null)
                return false;
            return a1.Degrees.Equals(a2.Degrees);
        }
    }
}