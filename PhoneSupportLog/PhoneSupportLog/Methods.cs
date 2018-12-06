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
    }
}
