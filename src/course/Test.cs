using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course
{
    public class Test
    {
        //setter & getter used for security and protect your code
        private int x;
        private int y;
        public void setX(int value)
        { x = value; }
        public int getX() { return x; }
        public void setY(int value)
        { y = value; }
        public int getY() { return y; }
        public float sum(int x, int y) { return x + y; }
    }
}
