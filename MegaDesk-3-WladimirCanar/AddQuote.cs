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
        public enum Materials
        {
            laminate = 100,
            oak = 200,
            rosewood = 300,
            veneer = 125,
            pine = 50, 
        }

        public enum rush
        {
            days3 = 3,
            days5 = 5,
            days7 = 7,
            noRush = 0,
        }

        

        List<Materials> material = Enum.GetValues(typeof(Materials)).Cast<Materials>().ToList();
        List<rush> rushDays = Enum.GetValues(typeof(rush)).Cast<rush>().ToList();


        public AddQuote()
        {
            InitializeComponent();
            comboSurfaceMaterials.DataSource = material;
            comboRushOrder.DataSource = rushDays;
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
                errorMessage = "Required value enter depth size between 12 and 48";
                MessageBox.Show(errorMessage);
                return false;
            }

            bool validar = Validar(depth);
          
            if (validar)
            {
                        errorMessage = "";
                        return true;
            } else  
                errorMessage = "Pleae enter value min 12 max 48 funcion";
                MessageBox.Show(errorMessage);
                return false;
            }

            public bool Validar(string depth)
            {
                int x;
                try
                {
                    x = Convert.ToInt32(depth);
                   
                    if (x > 11 && x < 49)
                        return true;
                    else
                        return false;
                }
                catch (Exception e)
                {
                    MessageBox.Show("Value must be a numeric");
                    return false;
                }

           
        }


        private void textBoxSizeDeskDepth_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSizeDeskWidth_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidWidth(textBoxSizeDeskWidth.Text, out errorMsg))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                textBoxSizeDeskDepth.Select(0, textBoxSizeDeskDepth.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                //this.errorProvider1.SetError(textBox1, errorMsg);
            }
        }

        public bool ValidWidth(string depth, out string errorMessage)
        {
            // Confirm that the deoth string is not empty.
            if (depth.Length == 0)
            {
                errorMessage = "Required value enter depth size between 24 and 96";
                MessageBox.Show(errorMessage);
                return false;
            }

            bool validar = Validar2(depth);

            if (validar)
            {
                errorMessage = "";  
                return true;
            }
            else
                errorMessage = "Pleae enter value min 24 max 96 funcion";
            MessageBox.Show(errorMessage);
            return false;
        }

        public bool Validar2(string depth)
        {
            int x;
            try
            {
                x = Convert.ToInt32(depth);

                if (x > 23 && x < 97)
                    return true;
                else
                    return false;
            }
            catch (Exception e)
            {
                MessageBox.Show("Value must be a numeric");
                return false;
            }


        }

        private void AddQuote_Load(object sender, EventArgs e)
        {

        }

        private void textBoxSizeDeskWidth_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnQuote_Click(object sender, EventArgs e)
        {

            
            
            //create a desk objeck
            Desk myDesk = new Desk();
            //myDesk.Name = textBoxName.Text;
            myDesk.Width = Convert.ToInt32(textBoxSizeDeskWidth.Text);
            myDesk.Depth = Convert.ToInt32(textBoxSizeDeskDepth.Text);
            myDesk.DesktopMaterial = (Materials)Enum.Parse(typeof(Materials), comboSurfaceMaterials.Text);
            myDesk.Rush = (rush)Enum.Parse(typeof(rush), comboRushOrder.Text);

            //create a deskQuoteObject

          

            //create a DiplayQuote object
            DisplayQuote displayQuote = new DisplayQuote();
            displayQuote.Tag = this;
            displayQuote.Data = myDesk;
            displayQuote.Show(this);

            Hide();


        }
    }

    
    
    }

