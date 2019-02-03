using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace MegaDesk_3_WladimirCanar
{
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
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

        private void SearchQuotes_Load(object sender, EventArgs e)
        {
            foreach (var quoteText in File.ReadAllLines(@"c:\temp\test.txt"))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Desk));
                var qt = new System.IO.StringReader(quoteText);
                var quote = (Desk)serializer.Deserialize(qt);
                listBox1.Text += quote.Name;
            }
            
        }
    }
}
