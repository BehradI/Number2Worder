using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberWorder
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
