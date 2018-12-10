using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PhoneSupportLog
{
    public class Methods
    {
        // Generic method to store list objects in a csv file
        public static void WriteCSV(List<PhoneCall> phoneCalls, string path)
        {
            Type itemType = typeof(PhoneCall);
            var props = itemType.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            using (var writer = new StreamWriter(path))
            {
                writer.WriteLine(string.Join(",", props.Select(p => p.Name)));

                foreach (var phoneCall in phoneCalls)
                {
                    writer.WriteLine(string.Join(",", props.Select(p => p.GetValue(phoneCall, null))));
                }
            }
        }


        // Generic method to read from list
        public static void ReadCSV(List<PhoneCall> phoneCalls, string path)
        {
            var lines = System.IO.File.ReadAllLines(path).Skip(1);

            foreach (var item in lines)
            {
                var values = item.Split(',');
                phoneCalls.Add(new PhoneCall(values[0], values[1], values[2], values[3], values[4], int.Parse(values[5]), values[6], int.Parse(values[7]),bool.Parse(values[8]),values[9]));
            }
        }
    }
}
