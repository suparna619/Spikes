using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class Number : IMyComparable<Number>
    {
        private readonly int _n;

        public Number(int n)
        {
            _n = n;
        }

        public int CompareTo(Number otherComparable)
        {
            return _n.CompareTo(otherComparable._n);
        }

        public override string ToString()
        {
            return _n.ToString();
        }
    }
}
