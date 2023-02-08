using System;

namespace course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BMW test = new BMW();
            test.CarInfo();

            Mazda mazda = new Mazda();
            mazda.CarInfo();
            mazda.PrintYear();

        }
    }
}
