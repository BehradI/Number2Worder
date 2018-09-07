using ClassLibrary;
using System;

namespace NumberWorderNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            INWorder nw = new NWorder();
            nw.Run(args);

            Console.ReadLine();
        }
    }
}
