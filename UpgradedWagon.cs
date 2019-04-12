using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadDom
{
    //klasa dziedziczy z klasy Wagon
    public class UpgradedWagon : Wagon
    {
        //kosntruktor bezparametryczny
        public UpgradedWagon()
        {
            wagonLevel = 3;
            wagonVelocity = 2;
        }
    }
}
