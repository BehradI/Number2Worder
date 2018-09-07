using System;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public interface INWorder
    {
        void Run(string[] args);
    }
    public class NWorder : INWorder
    {
        public void Run(string[] args)
        {
            if (args == null || !args.Any())
            {
                Console.WriteLine("Please provide arguments.");
                return;
            }

            foreach (var arg in args)
            {
                this.OutPutResult(arg);
            }
        }

        private void OutPutResult(string arg)
        {
            var nChars = arg.ToArray();
            if (nChars.All(c => char.IsNumber(c)))
            {
                var strBuild = new StringBuilder();
                foreach (var nChar in nChars)
                {
                    var nstr = this.Ones((byte)nChar);
                    strBuild.Append(nstr);
                }

                Console.WriteLine($"Result for \"{arg}\": {strBuild.ToString()}");
            }
            else
            {
                Console.WriteLine($"Value \"{arg}\" is incorrect integer value.");
            }
        }
        private String Ones(byte charByteCode)
        {
            switch (charByteCode)
            {
                case 48:
                    return "Zero";
                case 49:
                    return "One";
                case 50:
                    return "Two";
                case 51:
                    return "Three";
                case 52:
                    return "Four";
                case 53:
                    return "Five";
                case 54:
                    return "Six";
                case 55:
                    return "Seven";
                case 56:
                    return "Eight";
                case 57:
                    return "Nine";

            }
            return null;
        }
    }
}
