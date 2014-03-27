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

            tabs.ImageList = imageList1;
           // tabs.TabPages.IndexOf(addNewEntryTabPage).
            ///imageList1.
            //tabs.TabPages.
            //tabs.SelectedTab.ImageKey.Insert(0, "tabKey1");
            //tabs.TabPages.
            //tabs.TabPages.Add("tabKey1", "ADD NEW ENTRY", 0);
            //tabs.TabPages.
            viewAll();
            
            
        }

       


        //Save and add a patron into the SQL database
        private void saveButton_Click(object sender, EventArgs e)
        {
            AddNewEntry adder = new AddNewEntry(fNameTextBox.Text, lNameTextBox.Text, miTextBox.Text, addrNumNameTextBox1.Text, addrTextBox2.Text, cityTextBox1.Text, stateTextBox1.Text, zipTextBox1.Text, phoneTextBox.Text, numChildTextBox.Text, numAdultsTextBox.Text, monthMenuTab1.Text, yearTab1.Text, dayMenuTab1.Text);
            adder.save(adder);
            viewAll();
        }

      
        //When user goes to view all tab, he or she can see a table of all patrons
        public void viewAll()
        {
            viewAllDataGrid.Rows.Clear(); //To prevent repeat entries
            DBConnect db = new DBConnect();
            //<!---------VIEW ALL POPULATOR---------->
            int count = db.Count("SELECT * FROM patron");

            String[] rows = new String[count];

            List<Patron> list = new List<Patron>();         //Get all patron information in database, put them in a list
            list = db.SelectPatron("SELECT * FROM patron");

            //for each patron in list, add their information into their own row in the viewAll grid
            for (int x = 0; x < list.Count; x++)
            {
                String date = list[x].Date.Month + "/" + list[x].Date.Day + "/" + list[x].Date.Year;
                String children = "";
                children += list[x].NumChildren;
                String adults = "";
                adults += list[x].NumAdults;
                string[] row = { Convert.ToString(list[x].Id),list[x].FirstName, list[x].LastName, list[x].MiddleInitial, list[x].StreetName1, list[x].AddressLine2, list[x].City, list[x].State, list[x].Zip, list[x].Phone, children, adults, date };
                viewAllDataGrid.Rows.Add(row);
            }
            db.CloseAll(); //close all database connections
            dataGridViewTextBoxColumn2.DataGridView.Sort(dataGridViewTextBoxColumn2, ListSortDirection.Ascending); //sort the viewAll grid alphabetically
            viewAllDataGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans", 15F,
            System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); //set font style
            //<!---------END VIEW ALL POPULATOR---------->
        }

        //Searches for a patron based on first and last name, last time visited, or phone number
        private void searchButtonTab2_Click(object sender, EventArgs e)
        {
            searchDataGrid.Rows.Clear();
            Search search = new Search(searchTextTab2.Text,searchMenuTab2.Text);
            search.searchInformation(search);
            searchDataGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans", 15F,
            System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }


        //Gets stats for amount of adutls and children visited at certain time
        private void searchButtonTab3_Click(object sender, EventArgs e)
        {
            try
            {
                int month = DateTime.ParseExact(monthMenuTab3.Text, "MMMM", CultureInfo.CurrentCulture).Month;//need to convert month name to int
                Statistics stat = new Statistics(Int32.Parse(yearMenuTab3.Text), month, Int32.Parse(dayMenuTab3.Text), searchMenuTab3.Text);//pass year, month and day
                stat.showStats();//put stats on chart

            }
            catch
            {
                MessageBox.Show("Please select the correct criteria and a time frame.");//User needs to enter day, month, year and search criteria . 
            }
        }

        private void searchDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DBConnect db = new DBConnect();
            List<Patron> list = new List<Patron>();
            String patronId = searchDataGrid[0, e.RowIndex].Value.ToString();
            list = db.SelectPatron("SELECT * FROM patron WHERE patron_id = '" + patronId + "'");
            Form2 f = new Form2();
            f.Show();     
            Edit edit = new Edit(list[0],f);
        }

        private void viewAllDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DBConnect db = new DBConnect();
            List<Patron> list = new List<Patron>();
            String patronId = viewAllDataGrid[0, e.RowIndex].Value.ToString();
            list = db.SelectPatron("SELECT * FROM patron WHERE patron_id = '" + patronId + "'");
            Form2 f = new Form2();
            f.Show();
            Edit edit = new Edit(list[0], f);
        }

        private void tab1Button1_Click(object sender, System.EventArgs e)
        {
            //if (e.TabNumber -this doesnt work
            viewAll();
        }

      

      

        
    }
}
