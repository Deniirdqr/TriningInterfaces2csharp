using System;
using System.Globalization;
using TainingFifteen.Device;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer p = new Printer() { SerialNumber = 1290 };
            p.ProcessDoc("My letter");
            p.Print("My letter");

            Scanner s = new Scanner() { SerialNumber = 0304 };
            s.ProcessDoc("My Email");
            Console.WriteLine(s.Scan());

            ComboDevice C_B = new ComboDevice() { SerialNumber = 2200}
            C_B.ProcessDoc("My dissertation");
            C_B.Print("My dissertation");
            Console.WriteLine(C_B.Scan);
        }
    }
}