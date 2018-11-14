//ID: C2518
//CIS 200-01
//Prog2
//Due: 10/23/17
// This is the AddressForm class. It validates all text and combo boxes in the AddressForm.

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
    public partial class AddressForm : Form
    {
        public AddressForm()
        {
            InitializeComponent();
        }

        
        public string name
        {
            // Precondition: None
            // Postcondition: Text in the nameTextBox is returned
            get
            {
                return nameTextBox.Text;
            }
            // Preconditions: None
            // Postconditions: name is set to the specified value
            set
            {
                nameTextBox.Text = value;
            }
        }

        public string AddressLine1
        {
            // Precondition: None
            // Postcondition: Text in the address1TextBox is returned
            get
            {
                return address1TextBox.Text;
            }
            // Preconditions: None
            // Postconditions: addressline1 is set to the specified value
            set
            {
                address1TextBox.Text = value;
            }
        }

        public string AddressLine2
        {
            // Precondition: None
            // Postcondition: Text in the address2TextBox is returned
            get
            {
                return address2TextBox.Text;
            }
            // Preconditions: None
            // Postconditions: addressline2 is set to the specified value
            set
            {
                address2TextBox.Text = value;
            }
        }

        public string City
        {
            // Precondition: None
            // Postcondition: Text in the cityTextBox is returned
            get
            {
                return cityTextBox.Text;
            }
            // Preconditions: None
            // Postconditions: city is set to the specified value
            set
            {
                cityTextBox.Text = value;
            }
        }

        public string State
        {
                // Precondition: None
                // Postcondition: Text of the selected item from the combo box is returned
                get { return stateComboBox.SelectedItem.ToString(); }
            
        }

        public string Zip
        {
            // Precondition: None
            // Postcondition: Text in the zipTextBox is returned
            get
            {
                return zipTextBox.Text;
            }
            // Preconditions: None
            // Postconditions: Zip is set to the specified value
            set
            {
                zipTextBox.Text = value;
            }
        }
        // Precondition: Attempting to change focus from text box
        // Postcondition: Error message will appear if invalid value.
        private void nameText_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                e.Cancel = true;
                addressErrorProvider.SetError(nameTextBox, "Enter name in textbox"); //sets error message
            }
        }
        // Precondition: nameText_Validating was validated
        // Postcondition: Error message is cleared
        private void nameText_Validated(object sender, EventArgs e)
        {
            addressErrorProvider.SetError(nameTextBox, ""); //clears the error message
        }
        // Precondition: addreess1Validating was validated
        // Postcondition: Error message is cleared
        private void address1Validated(object sender, EventArgs e)
        {
            addressErrorProvider.SetError(address1TextBox, ""); 
        }
        // Precondition: Attempting to change focus from text box
        // Postcondition: Error message will appear if invalid value.
        private void addrss1Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(address1TextBox.Text))
            {
                e.Cancel = true;
                addressErrorProvider.SetError(address1TextBox, "Enter address in textbox"); //sets error message
            }
        }
        // Precondition: cityValidating was validated
        // Postcondition: Error message is cleared
        private void cityValidated(object sender, EventArgs e)
        {
            addressErrorProvider.SetError(cityTextBox, ""); 
        }
        // Precondition: Attempting to change focus from text box
        // Postcondition: Error message will appear if invalid value.
        private void cityValidating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cityTextBox.Text))
            {
                e.Cancel = true;
                addressErrorProvider.SetError(cityTextBox, "Enter city in textbox");
            }
        }
        // Precondition: Trying to change textbox
        // Postcondition: Error message will appear if invalid value.
        private void zipValidating(object sender, CancelEventArgs e)
        {
            int zip;
            if((!int.TryParse(zipTextBox.Text, out zip))&&(zip >= 0)&&(zip <= 99999))
            {
                e.Cancel = true;

                addressErrorProvider.SetError(zipTextBox, "Enter integer for zip");
            }
            else
            {
                if((zip < 0 ) || (zip > 99999))
                {
                    e.Cancel = true;
                    addressErrorProvider.SetError(zipTextBox, "Enter interger between 0-99999");
                }
            }
        }
        // Precondition: Ok button was clicked
        // Postcondition: Address form is submitted.
        private void okBtn_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
                this.DialogResult = DialogResult.OK;
        }

        // Precondition: zipValidating was validated
        // Postcondition: Error message is cleared
        private void zipValidated(object sender, EventArgs e)
        {
            addressErrorProvider.SetError(zipTextBox, "");
        }
        // Precondition: Trying to change textbox
        // Postcondition: If entered value is valid, textbox focus will change,
        //                else focus will remain and error is sent.
        private void stateValidating(object sender, CancelEventArgs e)
        {
            if (stateComboBox.SelectedIndex <0)
            {
                e.Cancel = true;
                addressErrorProvider.SetError(stateComboBox, "Select state");
            }
            
        }
        // Precondition: stateValidating was validated
        // Postcondition: Error message is cleared
        private void stateValidated(object sender, EventArgs e)
        {
            addressErrorProvider.SetError(stateComboBox, "");
        }
        // Precondition: Cancel button was clicked
        // Postcondition: Address form is canceled.
        private void cancelBtn_MouseDown(object sender, MouseEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
