using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadDom
{
    //utworzenie klasy Wagon
   public class Wagon
    {
        //atrybuty klasy
        public int wagonLevel;
        public int wagonVelocity;
        //kosntruktor bezparametryczny
        public Wagon()
        {
            //przypisanie wartości początkowych
            wagonLevel = 2;
            wagonVelocity = 1;
        }
    }
}
