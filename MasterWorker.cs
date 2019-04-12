using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadDom
{
    //klasa dziedziczy z klasy Worker
    public class MasterWorker : Worker
    {
        //kosntruktor bezparametryczny
        public MasterWorker()
        {
            workerLevel = 6;
            workerSalary = 3;
        }
    }
}
