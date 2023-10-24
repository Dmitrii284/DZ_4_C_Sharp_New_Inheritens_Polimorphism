using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DZ_4_C_Sharp_New_Inheritens_Polimorphism
{
    
    abstract class Money
    {
        protected int _wholePart;
        protected int _fractionalPart;

        protected Money(int wholePart, int fractionalPart) { _wholePart = wholePart; _fractionalPart = fractionalPart; }

        public int GetWholePart() { return _wholePart; }
        public int GetFractions() { return _fractionalPart; }

        public void SetWholePart(int wholeParts) { this._wholePart = wholeParts; }
        public void SetFractionlPart(int fractionalPart) { this._fractionalPart = fractionalPart; } 
        
        public abstract void DisplayAmount();
        public abstract void SetAmount(int wholePart, int fractionalPart);
    }

    class Currency : Money
    {
        public string currencyname;
        public Currency(int wholePart, int fractionalPart, string name) : base(wholePart, fractionalPart)
        {
            this.currencyname = name;
        }
              

        public override void DisplayAmount()
        {
            Console.WriteLine($"Amount: {_wholePart}.{_fractionalPart} {currencyname}");
        }

        public override void SetAmount(int wholePart, int fractionalPart)
        {
            this._wholePart = wholePart;
            this._fractionalPart = fractionalPart;
        }
    }

}

    

