using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace catsandflowers
{
    public abstract class Flower
    {
        public abstract int Id { get; set; }
        public abstract string Name { get; set; }
        public abstract string Rarity { get; set; } 
    }
}
