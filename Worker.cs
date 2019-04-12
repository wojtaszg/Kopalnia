using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadDom
{
    //stworzenie klasy Worker
    public class Worker
    {
        //atrybuty klasy
        public int workerLevel;
        public int workerSalary;
        //kosntruktor bezparametryczny
        public Worker()
        {
            //przypisanie wartości początkowych
            workerLevel = 2;
            workerSalary = 1;
        }
    }
}
