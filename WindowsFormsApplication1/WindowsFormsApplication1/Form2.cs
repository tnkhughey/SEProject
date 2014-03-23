using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

        }

        private void numAdultsTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        //Updates a patron's info. to the database 
        private void updateButton_Click(object sender, EventArgs e)
        {
            //Grab the textfields and store those using the update method
            Edit updater = new Edit();
            try
            {
                updater.update(fNameUpdateTextBox.Text, lNameUpdateTextBox.Text, miUpdateTextBox.Text, addrNumNameUpdateTextBox1.Text, addrUpdateTextBox2.Text, cityUpdateTextBox1.Text, stateUpdateTextBox1.Text, zipUpdateTextBox1.Text, phoneUpdateTextBox.Text, numUpdateChildTextBox.Text, numAdultsUpdateTextBox.Text, monthUpdateMenuTab1.Text, yearUpdateTab1.Text, dayUpdateMenuTab1.Text);
            }
            catch
            {

            }
         }
    }
}
