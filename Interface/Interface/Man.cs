using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Man : Human , LivingBeings
    {
        public string Run()
        {
            throw new NotImplementedException();
        }

        public override void Speak()
        {
            Console.WriteLine("Salam!");
        }
    }
}
