using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadDom
{
    //klasa dziedziczy po klasie wagon
    public class MasterWagon : Wagon
    {
        //kosntruktor bezparametryczny
        public MasterWagon()
        {
            wagonLevel = 4;
            wagonVelocity = 3;
        }
    }
}
