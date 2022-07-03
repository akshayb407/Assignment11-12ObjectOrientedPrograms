using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPrograms
{
    internal class Seeds
    {

        public string brand;
        public int PricePerKg;
        public int Weight;
        public int TotalPrice;
        public override string ToString()
        {
            return string.Format("name:\t{0}\nPrice per KG:\t{1}\nWeight:\t{2}\nTotalPrice:\t{3}", this.brand, this.PricePerKg, this.Weight, this.TotalPrice);
        }
    }
}
