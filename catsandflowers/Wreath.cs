using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace catsandflowers
{
    public class Wreath
    {
        private int _id;
        private string _type;
        private int _price;
        public int Id => _id;
        public string Type => _type;
        public int Price => _price;
        public Wreath():this(1,"Default") { }
        public Wreath(int id, string type)
        {
            _id = id;
            _type = type;
        }
    }
}
