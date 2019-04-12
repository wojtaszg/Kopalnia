using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadDom
{
    //Klasa dziedziczy z klasy bazowej TradeUnion
    public class TradeUnionUpgrade : TradeUnion
    {
        //kosntruktor bezparametryczny
        public TradeUnionUpgrade()
        {
            Diamond = 2;
            Budget = 10;
        }
    }
}
