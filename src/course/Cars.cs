using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course
{
    public abstract class Cars
    {
        protected string Model;
        protected string Year;
        protected string Engine;
        protected string Description;

        public abstract void CarInfo();

        public virtual void PrintYear() { }
    }
}
