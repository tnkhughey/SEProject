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
                if (addNewVisit.Checked)
                {
                    updater.update(fNameUpdateTextBox.Text, lNameUpdateTextBox.Text, miUpdateTextBox.Text, addrNumNameUpdateTextBox1.Text, addrUpdateTextBox2.Text, cityUpdateTextBox1.Text, stateUpdateTextBox1.Text, zipUpdateTextBox1.Text, phoneUpdateTextBox.Text, numUpdateChildTextBox.Text, numAdultsUpdateTextBox.Text, monthUpdateMenuTab1.Text, yearUpdateTab1.Text, dayUpdateMenuTab1.Text, idTextBox.Text);
                    //Updater dot update...my favorite line in the whole program :)
                }
                else
                {
                    updater.updateNoPrevVisit(fNameUpdateTextBox.Text, lNameUpdateTextBox.Text, miUpdateTextBox.Text, addrNumNameUpdateTextBox1.Text, addrUpdateTextBox2.Text, cityUpdateTextBox1.Text, stateUpdateTextBox1.Text, zipUpdateTextBox1.Text, phoneUpdateTextBox.Text, idTextBox.Text);
                }
            }
            catch
            {

            }
         }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (addNewVisit.Checked)
            {
                var form = Form2.ActiveForm as Form2;
                form.numAdultsLabel.Visible = true;
                form.numChildLabel.Visible = true;
                form.dateVistLabelTab1.Visible = true;
                form.numAdultsUpdateTextBox.Visible = true;
                form.numUpdateChildTextBox.Visible = true;
                form.monthUpdateMenuTab1.Visible = true;
                form.dayUpdateMenuTab1.Visible = true;
                form.yearUpdateTab1.Visible = true;
            }
            else
            {
                var form = Form2.ActiveForm as Form2;
                form.numAdultsLabel.Visible = false;
                form.numChildLabel.Visible = false;
                form.dateVistLabelTab1.Visible = false;
                form.numAdultsUpdateTextBox.Visible = false;
                form.numUpdateChildTextBox.Visible = false;
                form.monthUpdateMenuTab1.Visible = false;
                form.dayUpdateMenuTab1.Visible = false;
                form.yearUpdateTab1.Visible = false;
            }
        }

        

    }
}
