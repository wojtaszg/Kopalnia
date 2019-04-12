using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadDom
{
    //klasa dziedziczy z klasy Worker
    public class UpgradedWorker : Worker
    {
        //kosntruktor bezparametryczny
        public UpgradedWorker()
        {
            workerLevel = 4;
            workerSalary = 2;
        }
    }
}
