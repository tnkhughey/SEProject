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
            //create form componets
            InitializeComponent();

            //specify the icons for the tabs
            tabs.ImageList = imageList1;
           
            //Populate the ViewAll tab with all patron info.
            viewAll();
            
            //Most patrons are from Milledgeville and this makes adding a patron more simpler by allowing the user to not have to type in city, zip, state often
            cityTextBox1.Text = "Milledgeville";
            stateTextBox1.Text = "GA";
            zipTextBox1.Text = "31061";
           // DBConnect db = new DBConnect();
         //   db.Backup();
            //Populate the current date in the AddPatron tab to save user time of typing in the date a patron came on
            DateTime saveNow = DateTime.Now;
            monthMenuTab1.Text = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(saveNow.Month);//convert int to month name
            dayMenuTab1.Text = saveNow.Day+"";
            yearTab1.Text = saveNow.Year + "";
            
        }

       


        //Save and add a patron into the SQL database
        private void saveButton_Click(object sender, EventArgs e)
        {
            //Pass all the user input into an AddNewEntry object
            AddNewEntry adder = new AddNewEntry(fNameTextBox.Text, lNameTextBox.Text, miTextBox.Text, addrNumNameTextBox1.Text, addrTextBox2.Text, cityTextBox1.Text, stateTextBox1.Text, zipTextBox1.Text, referredTextBox.Text, numChildTextBox.Text, numAdultsTextBox.Text, monthMenuTab1.Text, yearTab1.Text, dayMenuTab1.Text);
            //Save the patron to the database
            adder.save(adder);
            //Repopulate viewall to add in new patron
            viewAll();
            //All fields are cleared so the user can freshly add a new patron. Needed to re-add in the current date since it was cleared.
            DateTime saveNow = DateTime.Now;
            monthMenuTab1.Text = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(saveNow.Month);//convert int to month name
            dayMenuTab1.Text = saveNow.Day + "";
            yearTab1.Text = saveNow.Year + "";
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
                string[] row = { Convert.ToString(list[x].Id),list[x].FirstName, list[x].LastName, list[x].MiddleInitial, list[x].StreetName1, list[x].AddressLine2, list[x].City, list[x].State, list[x].Zip, list[x].Referred, children, adults, date };
                viewAllDataGrid.Rows.Add(row);
            }
            db.CloseAll(); //close all database connections
            dataGridViewTextBoxColumn2.DataGridView.Sort(dataGridViewTextBoxColumn2, ListSortDirection.Ascending); //sort the viewAll grid alphabetically
            viewAllDataGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans", 15F,
            System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); //set font style
            //<!---------END VIEW ALL POPULATOR---------->
        }

        //Searches for a patron based on first and last name, last time visited
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
                if (searchCriteria3.Text == "Year")
                {
                    Statistics stat = new Statistics(Int32.Parse(yearMenuTab3.Text), searchCriteria3.Text); //pass year
                    stat.showStats();//put stats on chart
                }
                if (searchCriteria3.Text == "Month")
                {
                    int month = DateTime.ParseExact(monthMenuTab3.Text, "MMMM", CultureInfo.CurrentCulture).Month;//need to convert month name to int
                    Statistics stat = new Statistics(Int32.Parse(yearMenuTab3.Text), month, searchCriteria3.Text);//pass year, month and day
                    stat.showStats();//put stats on chart
                }
                if (searchCriteria3.Text == "Day" || searchCriteria3.Text == "Week")
                {
                    int month = DateTime.ParseExact(monthMenuTab3.Text, "MMMM", CultureInfo.CurrentCulture).Month;//need to convert month name to int
                    Statistics stat = new Statistics(Int32.Parse(yearMenuTab3.Text), month, Int32.Parse(dayMenuTab3.Text), searchCriteria3.Text);//pass year, month and day
                    stat.showStats();//put stats on chart
                }

            }
            catch
            {
                MessageBox.Show("Please select the correct criteria and a time frame.");//User needs to enter day, month, year and search criteria . 
            }
        }

        //If a cell is clicked in the search tab, bring up a patrons info in the Updater form
        private void searchDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                DBConnect db = new DBConnect();
                List<Patron> list = new List<Patron>();
                String patronId = searchDataGrid[0, e.RowIndex].Value.ToString();
                list = db.SelectPatron("SELECT * FROM patron WHERE patron_id = '" + patronId + "'");
                Form2 f = new Form2();
                f.Show();
                Edit edit = new Edit(list[0], f);
            }
            catch
            {

            }
        }
        //If a cell is clicked in the viewAll tab, bring up a patrons info in the Updater form
        private void viewAllDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                DBConnect db = new DBConnect();
                List<Patron> list = new List<Patron>();
                String patronId = viewAllDataGrid[0, e.RowIndex].Value.ToString();
                list = db.SelectPatron("SELECT * FROM patron WHERE patron_id = '" + patronId + "'");
                Form2 f = new Form2();
                f.Show();
                Edit edit = new Edit(list[0], f);
            }
            catch
            {

            }
        }
        
        //Repopulate viewAll tab when it is clicked
        private void tab1Button1_Click(object sender, System.EventArgs e)
        {
            viewAll();
        }

        //Add and remove text fields based on selection criteria for stats 
        private void searchMenuTab3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (searchCriteria3.Text == "Year")
            {
                monthMenuTab3.Visible = false;
                dayMenuTab3.Visible = false; 
                yearMenuTab3.Visible = true;
            }
            if (searchCriteria3.Text == "Month")
            {
                monthMenuTab3.Visible = true;
                dayMenuTab3.Visible = false;
                yearMenuTab3.Visible = true;
            }
            if (searchCriteria3.Text == "Day" || searchCriteria3.Text == "Week")
            {
                monthMenuTab3.Visible = true;
                dayMenuTab3.Visible = true;
                yearMenuTab3.Visible = true;
            } 

        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DBConnect db = new DBConnect();
            try
            {
                db.Backup();
                MessageBox.Show("Successfully backed up database to \"C:\\backups\\patrondata\"");
            }
            catch(Exception e1)
            {
                MessageBox.Show("Could not back up database! Contact Rob and Tommy! Exception: " + e1.ToString() + "");
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The software consists of 2 items: A user program application and a database. The application has been built using C# and the database has been built using MySQL. Adding new patron information, editing existing information, searching for information, seeing statistics and viewing all the patron information can be done using the application."+
            "The database will store the records for the patron’s personal information, address data and visit information. Please refer to the software guide for help. \n This sowftare was developed for Chard Wray Food Pantry. \n Authors: Rob Grimes and Thomas Hughey Georgia College Class of 2014");
        }

        
    }
}
