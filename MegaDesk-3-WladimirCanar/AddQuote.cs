using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_WladimirCanar
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            MainMenu addMainMenuForm = new MainMenu();
            addMainMenuForm.Tag = this;
            addMainMenuForm.Show(this);
            Hide();
        }

        private void textBoxSizeDesk_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                    e.Handled = true;
                
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSizeDeskDepth_Validated(object sender, EventArgs e)
        {
            // If all conditions have been met, clear the ErrorProvider of errors.
            //errorProvider1.SetError(textBoxSizeDeskDepth, "");
        }

        private void textBoxSizeDeskDepth_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidDepth(textBoxSizeDeskDepth.Text, out errorMsg))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                textBoxSizeDeskDepth.Select(0, textBoxSizeDeskDepth.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                //this.errorProvider1.SetError(textBox1, errorMsg);
            }
        }

        public bool ValidDepth(string depth, out string errorMessage)
        {
            // Confirm that the deoth string is not empty.
            if(depth.Length == 0)
            {
                errorMessage = "Enter depth value min 12 max 48";
                MessageBox.Show(errorMessage);
                return false;
            }

            // Confirm the value is min 12 max 48r.
            int x = Convert.ToInt32(depth);

            if (x > 11 || x < 49)
            {
                        errorMessage = "";
                        return true;
            } else  
                errorMessage = "Enter depth value min 12 max 48";
                MessageBox.Show(errorMessage);
                return false;
            }
        }
}
