using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    internal class ProductClass
    {
        public int Value { get; set; }
        public string Name { get; set; }

        public ProductClass(int value, string name)
        {
            Value = value;
            Name = name;
        }
    }
}
