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
        public static List<PhoneCall> phoneCalls = new List<PhoneCall>();
        static void Main(string[] args)
        {
            Methods.ReadCSV(phoneCalls, @"C:\Users\PrujeanT\Desktop\PhoneSupportLog\SupportPhoneLog.csv");
            int mainMenuChoice;
            do
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Radford Software phone support log");
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("Please enter an option");
                Console.WriteLine("1. Log a call");
                Console.WriteLine("2. View log");
                Console.WriteLine("3. Exit");
                mainMenuChoice = int.Parse(Console.ReadLine());
                switch (mainMenuChoice)
                {
                    case 1:
                        LogCall();
                        Methods.WriteCSV(phoneCalls, @"C:\Users\PrujeanT\Desktop\PhoneSupportLog\SupportPhoneLog.csv");
                        break;
                    case 2:
                        DisplayCalls();
                        break;
                    case 3:
                        return;
                    default:
                        Console.Clear();
                        Console.WriteLine("Please enter a valid choice (1 - 3)");
                        break;
                }
            }
            while (mainMenuChoice != 3);
        }
        
        public static void LogCall()

        {
            Console.Clear();
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Company: ");
            string company = Console.ReadLine();
            Console.Write("Phone: ");
            string phone = Console.ReadLine();
            Console.Write("Product: ");
            string product = Console.ReadLine();
            Console.Write("Call Length: ");
            int callLength = int.Parse(Console.ReadLine());
            Console.Write("Resolved?: ");
            string resolved = Console.ReadLine();
            Console.Write("JIRA Ticket Number: ");
            int JIRA = int.Parse(Console.ReadLine());
            Console.Write("Reception?: ");
            bool reception = bool.Parse(Console.ReadLine());
            Console.Write("Comments: ");
            string comments = Console.ReadLine();
            //Add calls to list
            phoneCalls.Add(new PhoneCall(DateTime.Now.ToString(), name, company, phone, product, callLength, resolved, JIRA, reception, comments));
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Call Logged!");
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
        }

        public static void DisplayCalls()
        {
            Console.Clear();
            Console.WriteLine($"Phone calls logged as of {DateTime.Now}");
            Console.WriteLine("-------------------------------------------------");
            foreach (var call in phoneCalls)
            {
                Console.WriteLine($"Date & Time:   {call.DateTime}");
                Console.WriteLine($"Name:          {call.Name}");
                Console.WriteLine($"Company:       {call.Company}");
                Console.WriteLine($"Phone:         {call.Phone}");
                Console.WriteLine($"Product:       {call.DateTime}");
                Console.WriteLine($"Call Length:   {call.DateTime} mins.");
                Console.WriteLine($"Resolved?:     {call.Resolved}");
                Console.WriteLine($"JIRA Ticket:   {call.JIRA}");
                Console.WriteLine($"Reception?:    {call.Reception}");
                Console.WriteLine($"Comments:      {call.Comments}");
                Console.WriteLine("-------------------------------------------------");
            }
            Console.Write("Press enter to continue");
            Console.ReadLine();
        }
    }
}
