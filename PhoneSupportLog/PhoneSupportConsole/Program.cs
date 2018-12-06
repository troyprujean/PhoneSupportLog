using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhoneSupportLog;

namespace PhoneSupportConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var phoneCalls = new List<PhoneCall>();
            phoneCalls.Add(new PhoneCall(1, "16/12/2018 - 16:15", "Troy", "Radfords", "0221998021", "KiwiPlus", 15, "N/A", 6134, false, "Asking for help with KiwiPlus"));
            Methods.WriteCSV(phoneCalls, @"C:\Users\PrujeanT\Desktop\PhoneSupportLog\people.csv");
            Console.WriteLine("Data written to CSV");
            Console.ReadLine();
        }
    }
}
