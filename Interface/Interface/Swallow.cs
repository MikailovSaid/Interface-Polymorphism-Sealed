using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Swallow : Bird , LivingBeings
    {
        public string Run()
        {
            throw new NotImplementedException();
        }

        public override void Sound()
        {
            Console.WriteLine("Cik cik");
        }
    }
}
