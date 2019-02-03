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
    public partial class DisplayQuote : Form
    {
         
        public DisplayQuote()
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

        // asignar el objeto Desk 
        public Desk Data;
     
        private void saveQote()
        {
            var ms = new MemoryStream();
            XmlSerializer x = new XmlSerializer(typeof(Desk));
            x.Serialize(ms,Data);
            var obj = Encoding.UTF8.GetString(ms.ToArray());
            File.AppendAllText(@"c:\temp\test.txt", obj.Replace("\n","").Replace("\r", "")+"\r\n");
        }

        private void DisplayQuote_Load(object sender, EventArgs e)
        {
            //MessageBox.Show((Data != null).ToString());
            label1.Text = ((int)Data.DesktopMaterial).ToString();
            this.saveQote();
            


        }
    }
}
