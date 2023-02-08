using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course
{
    internal class Mazda : Cars
    {
        public Mazda()
        {
            base.Model = "Mazda";
            base.Engine = "2.4";
            base.Year = "2020";
            base.Description = "Big car";
        }
        public override void CarInfo()
        {
            Console.WriteLine(base.Model);
            Console.WriteLine(base.Engine);
            Console.WriteLine(base.Year);
            Console.WriteLine(base.Description);
        }

        public override void PrintYear()
        {
            Console.WriteLine(base.Year);
        }
    }
}
