using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyMarket
{
    class CandyBag
    {
        public User Owner { get; set; }
        public Dictionary<CandyType, int> Bag = new Dictionary<CandyType, int>();

    }
}
