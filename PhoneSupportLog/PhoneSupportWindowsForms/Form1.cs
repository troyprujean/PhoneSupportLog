using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhoneSupportLog;

namespace PhoneSupportWindowsForms
{
    public partial class Form1 : Form
    {
        public static List<PhoneCall> phoneCalls = new List<PhoneCall>();
        public Form1()
        {
            InitializeComponent();
            Methods.ReadCSV(phoneCalls, @"C:\Users\PrujeanT\Desktop\PhoneSupportLog\SupportPhoneLog.csv");
        }

        private void btnDisplayCalls_Click(object sender, EventArgs e)
        {
            foreach (var phoneCall in phoneCalls)
            {
                lbxDisplay.Items.Add(phoneCall.GetPhoneCall());
            }
        }

        private void lbxDisplay_SelectedValueChanged(object sender, EventArgs e) // Event for selecting an item on the list
        {
            if (lbxDisplay.SelectedIndex >= 0) // Confirmation that one of the items is actually selected
            {
                string[] listArray = lbxDisplay.SelectedItem.ToString().Split('\t'); // Thanks to: https://stackoverflow.com/questions/2797647/separate-string-by-tab-characters
                txtFirstName.Text = listArray[0];
                txtLastName.Text = listArray[1];
                txtPhone.Text = listArray[2];
                // Store the index of the item in the customerdb list by confirming that the objects first name matches that of the first name stored in indices "0" of the array
                listIndex = CustomerDB.FindIndex(customer => customer.FName.Equals(listArray[0], StringComparison.OrdinalIgnoreCase));
            }
            else
            {
                // If no items are selected do nothing...
            }
        }
    }
}
