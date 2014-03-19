using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            /*
             * dataGridView2
            private System.Windows.Forms.DataGridViewTextBoxColumn viewAllFirstName;
            private System.Windows.Forms.DataGridViewTextBoxColumn viewAllLastName;
            private System.Windows.Forms.DataGridViewTextBoxColumn viewAllMiddleInitial;
            private System.Windows.Forms.DataGridViewTextBoxColumn viewAllAddressLine1;
            private System.Windows.Forms.DataGridViewTextBoxColumn viewAllAddressLine2;
            private System.Windows.Forms.DataGridViewTextBoxColumn viewAllPhone;
            private System.Windows.Forms.DataGridViewTextBoxColumn viewAllAdults;
            private System.Windows.Forms.DataGridViewTextBoxColumn viewAllChildren;
            private System.Windows.Forms.DataGridViewTextBoxColumn viewAllPrevVisit;
            */

            InitializeComponent();


            viewAll();
            
        }

       


       
        private void saveButton_Click(object sender, EventArgs e)
        {
            AddNewEntry adder = new AddNewEntry(fNameTextBox.Text, lNameTextBox.Text, miTextBox.Text, addrNumNameTextBox1.Text, addrTextBox2.Text, cityTextBox1.Text, stateTextBox1.Text, zipTextBox1.Text, phoneTextBox.Text, numChildTextBox.Text, numAdultsTextBox.Text, monthMenuTab1.Text, yearTab1.Text, dayMenuTab1.Text);
            adder.save(adder);
        }

      

        private void viewAll()
        {
            DBConnect db = new DBConnect();
            //<!---------VIEW ALL POPULATOR---------->
            int count = db.Count("SELECT * FROM patron");

            String[] rows = new String[count];

            List<Patron> list = new List<Patron>();
            list = db.SelectPatron("SELECT * FROM patron");

            for (int x = 0; x < list.Count; x++)
            {
                String date = list[x].Date.Month + "/" + list[x].Date.Day + "/" + list[x].Date.Year;
                String children = "";
                children += list[x].NumChildren;
                String adults = "";
                adults += list[x].NumAdults;
                string[] row = { list[x].FirstName, list[x].LastName, list[x].MiddleInitial, list[x].StreetName1, list[x].AddressLine2, list[x].City, list[x].State, list[x].Zip, list[x].Phone, children, adults, date };
                dataGridView2.Rows.Add(row);
            }
            db.CloseAll(); 
            //<!---------END VIEW ALL POPULATOR---------->
        }

        private void searchButtonTab2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            Search search = new Search(searchTextTab2.Text,searchMenuTab2.Text);
            search.searchInformation(search);
          /*  try
            {
                dataGridView1.Rows.Add(rows);
            }
            catch
            {

            }*/

        }

      

        private void searchButtonTab3_Click(object sender, EventArgs e)
        {
            try
            {
                Statistics stat = new Statistics(Int32.Parse(yearMenuTab3.Text), Int32.Parse(monthMenuTab1.Text), Int32.Parse(dayMenuTab1.Text), searchMenuTab3.Text);
                stat.showStats();
            }
            catch
            {
                MessageBox.Show("Please select the correct criteria and a time frame.");
            }
        }

        
    }
}
