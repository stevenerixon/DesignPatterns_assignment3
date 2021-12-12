using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Adapter
{
    public class PrintingIntsService
    {
        ReturningStrings returningStrings { get; set; }
        PrintingInts printingInts { get; set; }

        public PrintingIntsService()
        {
            returningStrings = new ReturningStrings();
            printingInts = new PrintingInts();
        }

        public int Converter()
        {
            var number = int.Parse(returningStrings.ReturnString());
            return number;
        }

        public void PrintTheParsedNumber()
        {
            printingInts.Print(Converter());
        }
    }
}
