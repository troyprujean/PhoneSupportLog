using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneSupportLog
{
    public class PhoneCall
    {
        public string DateTime { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public string Phone { get; set; }
        public string Product { get; set; }
        public int CallLength { get; set; }
        public string Resolved { get; set; }
        public int JIRA { get; set; }
        public bool Reception { get; set; }
        public string Comments { get; set; }

        public PhoneCall(string dateTime, string name, string company, string phone, string product, int callLength, string resolved, int jira, bool reception, string comments)
        {
            DateTime = dateTime;
            Name = name;
            Company = company;
            Phone = phone;
            Product = product;
            CallLength = callLength;
            Resolved = resolved;
            JIRA = jira;
            Reception = reception;
            Comments = comments;
        }
    }
}
