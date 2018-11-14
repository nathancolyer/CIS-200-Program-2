//ID: C2518
//CIS 200-01
//Prog2
//Due: 10/23/17
// This is the Prog2Form class. It is the main form that contains the list reports and navigation to other forms.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPVApp
{
    public partial class Prog2Form : Form
    {
        private UserParcelView upv;

        public Prog2Form()
        {
            InitializeComponent();

           upv = new UserParcelView();  //holds user parcel view

            upv.AddAddress("John Smith", "123 Any St.", "Apt. 45", "Louisville", "KY", 40202);     // Test Addresses
            upv.AddAddress("Jane Doe", "987 Main St.", "","Beverly Hills", "CA", 90210);                                           
            upv.AddAddress("James Kirk", "654 Roddenberry Way", "Suite 321","El Paso", "TX", 79901);                                                 
            upv.AddAddress("John Crichton", "678 Pau Place", "Apt. 7",
                "Portland", "ME", 04101);
            upv.AddAddress("Bob Snob", "777 Big Ave", "Compton", "CA", 94091);
            upv.AddAddress("Timmy Turner", "581 Head St.", "Apt 8", "Fairyland", "MS", 44014);

            upv.AddLetter(upv.AddressAt(0), upv.AddressAt(5), 10.0m); //Test Letters
            upv.AddLetter(upv.AddressAt(5), upv.AddressAt(4), 5.0m);
            upv.AddLetter(upv.AddressAt(3), upv.AddressAt(2), 2.5m);

        }

        List<Parcel> parcels = new List<Parcel>(); // holds parcels in list
        List<Address> addresses = new List<Address>(); //holds addresses in list


        //Pre: File About is clicked
        //Post:Info about program2 is shown
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Grade ID: C2518" + Environment.NewLine + "Program 2" + Environment.NewLine + "CIS 200-01" +
                Environment.NewLine + "Due: 10/23/17");

        }
        //Pre: File exit is clicked
        //Post:Exits application
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Pre: Insert address clicked
        //Post:The addressform dialog box is displayed. An new address is submitted and added to addressList
        private void addressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddressForm addressForm = new AddressForm(); //dialog box form
            string name;        //variables for addressform fields
            string address1;
            string address2;
            string city;
            string state;
            int zip;
            DialogResult result = addressForm.ShowDialog(); //shows dialog box, and stores result

            if (result == DialogResult.OK)
            {
                name = addressForm.name;      
                address1 = addressForm.AddressLine1;
                address2 = addressForm.AddressLine2;
                city = addressForm.City;
                state = addressForm.State;
                zip = int.Parse(addressForm.Zip);

                upv.AddAddress(name,address1,address2,city,state,zip);
            }
            addressForm.Dispose();
        }
        //Pre: Insert letter clicked
        //Post:The letterform dialog box is displayed. An new letter is submitted and added to parcelist
        private void letterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LetterForm letterForm = new LetterForm(upv.AddressList); //dialog box form
            DialogResult result = letterForm.ShowDialog();       //shows dialog box, and stores result
            Address originAddress;        //variables for letterform fields
            Address destAddress;
            decimal cost;


            if (result == DialogResult.OK)
            {
                originAddress = upv.AddressList[letterForm.OriginIndex];
                destAddress = upv.AddressList[letterForm.DestIndex];
                cost = decimal.Parse(letterForm.Cost);

                upv.AddLetter(originAddress, destAddress, cost);
            }
        }
        //Pre: Report List Addresses clicked
        //Post:The report textbox clears itself and displays the list of addresses
        private void listAddressesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reportTextBox.Clear();

            reportTextBox.AppendText(string.Format("{0}{1}{1}", "Addresses", System.Environment.NewLine));

            foreach (Address a in upv.AddressList)
            {
                reportTextBox.AppendText(string.Format("{0}{1}{1}", a, System.Environment.NewLine));
            }
        }
        //Pre: Report List Parcels clicked
        //Post:The report textbox clears itself and displays the list of parcels. It also displays total cost of parcels.
        private void listParcelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                reportTextBox.Clear(); 

                reportTextBox.AppendText(string.Format("{0}{1}{1}", "Parcels", System.Environment.NewLine)); // header

                decimal totalCost = 0; // variable to hold the total cost

                foreach (var p in upv.ParcelList) 
                {
                    reportTextBox.AppendText(string.Format("{0}{1}{1}{1}", p, System.Environment.NewLine));

                    totalCost += p.CalcCost(); // adds costs
                }

                reportTextBox.AppendText(string.Format("Total Cost: {0}", totalCost.ToString("c"))); // displays the total cost

            }
        }
    }
    }

