using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_4_C_Sharp_New_Inheritens_Polimorphism
{
     class Product : Currency
     {
        public string name;
        public Product(int wholePart, int fractionalPart,string currencyname, string name) : base(wholePart, fractionalPart, currencyname)        
        {
            this.name = name;
        }

        public void DecreasePrice(int amount)
        {            
            _wholePart -= amount;
            if (_wholePart < 0)
            {
                _wholePart = 0;
            }
        }        
       
     }
}
