//ID: C2518
//CIS 200-01
//Prog2
//Due: 10/23/17
// This is a letterform class. It validates and stores all combo box and text boxes from the letterform.
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
    public partial class LetterForm : Form
    {
        public List<Address> addresses;

        public LetterForm(List<Address> addresses)
        {
            InitializeComponent();

            foreach (Address a in addresses) // loop that steps through address list and adds them to both combo boxes item list
            {
                originComboBox.Items.Add(a.Name);
                destComboBox.Items.Add(a.Name);
            }
        }


        public int OriginIndex
        {
            // Precondition: None
            // Postcondition: selected index of originComboBox is returned
            get
            {
                return originComboBox.SelectedIndex;
            }
        }

        public int DestIndex
        {
            // Precondition: None
            // Postcondition: selected index of destComboBox is returned
            get
            {
                return destComboBox.SelectedIndex;
            }
        }

        public string Cost
        {
            // Precondition: None
            // Postcondition: Text in the costTextBox is returned
            get
            {
                return costTextBox.Text;
            }
            // Preconditions: None
            // Postconditions: cost is set to the specified value
            set
            {
                costTextBox.Text = value;
            }
        }
        // Precondition: origValidating was validated
        // Postcondition: Error message is cleared
        private void origValidated(object sender, EventArgs e)
        {
            letterErrorProvider.SetError(originComboBox, "");
        }
        // Precondition: Trying to change textbox
        // Postcondition: Error message will appear if invalid value.
        private void origValidating(object sender, CancelEventArgs e)
        {
            if (originComboBox.SelectedIndex < 0)
            {
                e.Cancel = true;

                letterErrorProvider.SetError(originComboBox, "Give origin address");
            }
        }
        // Precondition: origValidating was validated
        // Postcondition: Error message is cleared
        private void destValidated(object sender, EventArgs e)
        {
            letterErrorProvider.SetError(destComboBox, "");
        }
        // Precondition: Trying to change textbox
        // Postcondition: Error message will appear if invalid value.
        private void destValidating(object sender, CancelEventArgs e)
        {
            if (destComboBox.SelectedIndex < 0)
            {
                e.Cancel = true;
                letterErrorProvider.SetError(destComboBox, "Give destination address");
            }
        }
        // Precondition: origValidating was validated
        // Postcondition: Error message is cleared
        private void costValidated(object sender, EventArgs e)
        {
            letterErrorProvider.SetError(costTextBox, "");
        }

        // Precondition: Trying to change textbox
        // Postcondition: Error message will appear if invalid value.
        private void costValidating(object sender, CancelEventArgs e)
        {
            decimal costs;
            if(!decimal.TryParse(costTextBox.Text, out costs))
            {
                e.Cancel = true;
                letterErrorProvider.SetError(costTextBox, "Must provide decimal cost");
            }
            else
            {
                if(costs < 0m)
                {
                    e.Cancel = true;
                    letterErrorProvider.SetError(costTextBox, "Cost can be negative");
                }
            }
        }
        // Precondition: Ok button was clicked
        // Postcondition: Letter form is submitted.
        private void okBtn_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
                this.DialogResult = DialogResult.OK;
        }

        // Precondition: Cancel button was clicked
        // Postcondition: Letter form is canceled.
        private void cancelBtn_MouseDown(object sender, MouseEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
