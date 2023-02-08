using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course
{
    public class BMW : Cars
    {
        public BMW()
        {
            base.Model = "BMW";
            base.Engine = "2.0";
            base.Year = "2023";
            base.Description = "small car";
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
