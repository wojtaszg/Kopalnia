using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadDom
{
    //klasa dziedziczy z klasy TradeUnionUpgrade
    public class TradeUnionFinalForm : TradeUnionUpgrade
    {
        //kosntruktor bezparametryczny
        public TradeUnionFinalForm()
        {
            Diamond = 1;
            Budget = 100;
        }
    }
}
