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
        public static void WriteCSV<T>(IEnumerable<T> items, string path)
        {
            Type itemType = typeof(T);
            var props = itemType.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            using (var writer = new StreamWriter(path))
            {
                writer.WriteLine(string.Join(", ", props.Select(p => p.Name)));

                foreach (var item in items)
                {
                    writer.WriteLine(string.Join(", ", props.Select(p => p.GetValue(item, null))));
                }
            }
        }


        // Generic method to read from list
        public static void ReadCSV(List<PhoneCall> phoneCalls, string path)
        {
            var lines = System.IO.File.ReadAllLines(path).Skip(1);

            foreach (string item in lines)
            {
                var values = item.Split(',');

                phoneCalls.Add(new PhoneCall()
                {
                    DateTime = values[0],
                    Name = values[1],
                    Company = values[2],
                    Phone = values[3],
                    Product = values[4],
                    CallLength = int.Parse(values[5]),
                    Resolved = values[6],
                    JIRA = int.Parse(values[7]),
                    Reception = bool.Parse(values[8]),
                    Comments = values[9]
                });
            }
        }
    }
}
