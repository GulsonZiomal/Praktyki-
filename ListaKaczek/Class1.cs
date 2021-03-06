using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class Duck : IComparable<Duck>
    {
        public int size;
        public KindOfDuck Kind;

    public int CompareTo(Duck duckToCompare)
    {
        if (this.size > duckToCompare.size)
            return 1;
        else if (this.size < duckToCompare.size)
            return -1;
        else
            return 0;
    }
    }
    public enum KindOfDuck
    {
        Mallard,
        Muscovy,
        Decoy
    }
