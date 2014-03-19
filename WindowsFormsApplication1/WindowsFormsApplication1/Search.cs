using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//namespace ChardWayFoodPantryProject
namespace WindowsFormsApplication1
{
    class Search
    {
        String searchTextField;//user's text input
        String searchCriteriaColumn;//the name of the column to search 
        
        String extraSearchTextField;//for saving extra input data
        String extraSearchCriteriaColumn;//for last name or if need data from 2 columns from table

        String selection;//the selected drop down menu item
 

        public Search()
        {
            searchTextField = "";
            searchCriteriaColumn = "";
            selection = "";
        }
        public Search(String textField, String criteriaMenuText)
        {

            //user wants to search by name
            if (criteriaMenuText.Equals("First and Last Name"))
            {
                searchCriteriaColumn= "firstName";//column in database to get first name
                extraSearchCriteriaColumn="lastName";//column in database to get second name
                selection = criteriaMenuText;
                String[] splitName=textField.Split(' ');//separate first and last name by space
                try
                {
                    searchTextField = splitName[0];//first ele. is first name
                    extraSearchTextField = splitName[1];//second ele. is second name
                }
                catch 
                {
                    MessageBox.Show("Please enter the first and last name again in the format:(Bob Smith)");
                }
            }
            //user wants to search records by phone number
            if (criteriaMenuText.Equals("Phone"))
            {
                try
                {
                    searchCriteriaColumn = "phone";
                    searchTextField = textField;
                    selection = criteriaMenuText;
                }
                catch
                {
                    MessageBox.Show("Please enter the phone # in the format:(123456789)");

                }
                MessageBox.Show("phone works");

            }
            //user wants to search records by date of patron's last visit
            //format of date is YYYY-MM-DD
            if (criteriaMenuText.Equals("LastVisit"))
            {
                try
                {
                    searchCriteriaColumn = "date";
                    searchTextField = textField;
                    selection = criteriaMenuText;
                }
                catch
                {
                    MessageBox.Show("Please enter the date in the format(YYYY-MM-DD)");
                }
                MessageBox.Show("date works");

            }
        }

        public void fillTable()
        {
           
        }
        public void edit()
        {


        }
        //Takes a Search obj that has all user input
        public void searchInformation(Search search)
        {
           String[] allInfo=null;
           DBConnect db = new DBConnect();
           String[] criteriaSelected=null;
           int count =0;//the number of patrons to be added to the table
           String query = "";//the SQL query for the database
            //Create SQL statements. Look at database for column names and variable information.
           if (search.selection.Equals("First and Last Name"))
           {
               //get all patron info. where the first and last name match user input
               query = "SELECT * FROM patron WHERE " + search.searchCriteriaColumn + "='" + search.searchTextField + "' AND " + search.extraSearchCriteriaColumn + "='" + search.extraSearchTextField+"'";
               count = db.Count(query);

           }
           else if (search.selection.Equals("Phone"))
           {
               //get all patron info. where phone# match user input
               query = "SELECT * FROM patron WHERE " + search.searchCriteriaColumn + "='" + search.searchTextField + "'";
               count = db.Count(query);
           }
           else
           {
               //get all patron info. where their previous visit matches user input
              // query = "SELECT * FROM patron WHERE patron_id= (SELECT patron_id FROM previousvisits WHERE " + search.searchCriteriaColumn + "='" + search.searchTextField + "')";
             //  query = "SELECT * FROM patron,previousvisits WHERE p.patron_id=v.patron_id AND v.date=" + search.searchCriteriaColumn + "='" + search.searchTextField + "'";
                query = "SELECT * FROM patron WHERE patron_id IN (SELECT patron_id FROM previousvisits WHERE " + search.searchCriteriaColumn + "='" + search.searchTextField + "')";

               count = db.Count(query);
           }
               
               String[] rows = new String[count];//holds the record of patron info. from query 

               List<Patron> list = new List<Patron>();//holds all the patron info
               db.CloseAll();  //close all the connections. they no longer need to be open
               list = db.SelectPatron(query);//Put patron info. into list which matches query
              
    /*        Int32 index = 0;
            while (index < list.Count - 1)
            {
                if (list[index].Date == list[index + 1].Date)
                list.RemoveAt(index);
                else
                index++;
            }*/
            
               var form = Form1.ActiveForm as Form1;
            //For each patorn, grab all their info. and store it into a row and add it to the GUI
               for (int x = 0; x < list.Count; x++)
               {
                   String date = list[x].Date.Month + "/" + list[x].Date.Day + "/" + list[x].Date.Year;
                   String children = "";
                   children += list[x].NumChildren;
                   String adults = "";
                   adults += list[x].NumAdults;
                   string[] row = { list[x].FirstName, list[x].LastName, list[x].MiddleInitial, list[x].StreetName1, list[x].AddressLine2, list[x].City, list[x].State, list[x].Zip, list[x].Phone, children, adults, date };
                   allInfo = row;
                   form.searchDataGrid.Rows.Add(row);
               }
           
            db.CloseAll();
        }
    
    }
}
