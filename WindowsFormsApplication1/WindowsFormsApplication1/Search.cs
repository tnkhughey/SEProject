﻿using System;
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

//namespace ChardWayFoodPantryProject
namespace WindowsFormsApplication1
{
    class Search
    {
        String searchTextField;
        String searchCriteriaColumn;
        
        String extraSearchTextField;
        String extraSearchCriteriaColumn;

 

        public Search()
        {
            searchTextField = "";
            searchCriteriaColumn = "";
        }
        public Search(String textField, String criteriaMenuText)
        {
            if (criteriaMenuText.Equals("First and Last Name"))
            {
                searchCriteriaColumn= "firstName";
                extraSearchCriteriaColumn="lastName";
                String[] splitName=textField.Split(' ');
                searchTextField=splitName[0];
                extraSearchTextField=splitName[1];
                
            }

            if (criteriaMenuText.Equals("Phone"))
            {
                searchCriteriaColumn = "phone";
                searchTextField = textField;
            
            }

            if (criteriaMenuText.Equals("LastVisit"))
            {
                searchCriteriaColumn = "date";
                searchTextField = textField;
              
            }
        }

        public void fillTable(string [] rows)
        {
            
        }
        public void edit()
        {


        }
        public string[] searchInformation(Search search)
        {
           String[] allInfo=null;
           DBConnect db = new DBConnect();
           String[] criteriaSelected=null;
           int count =0;
           String query = "";
           if (!(search.searchCriteriaColumn.Equals("First and Last Name")))
           {
               query = "SELECT * FROM patron WHERE" + search.searchCriteriaColumn + "=" + search.searchTextField;
               count = db.Count(query);
           }
           else
           {
               query="SELECT * FROM patron WHERE" + search.searchCriteriaColumn + "=" + search.searchTextField + "AND" + search.extraSearchCriteriaColumn + "=" + search.extraSearchTextField;
               count = db.Count(query);
           }

               String[] rows = new String[count];

               List<Patron> list = new List<Patron>();
               list = db.SelectPatron(query);

               for (int x = 0; x < list.Count; x++)
               {
                   String date = list[x].Date.Month + "/" + list[x].Date.Day + "/" + list[x].Date.Year;
                   String children = "";
                   children += list[x].NumChildren;
                   String adults = "";
                   adults += list[x].NumAdults;
                   string[] row = { list[x].FirstName, list[x].LastName, list[x].MiddleInitial, list[x].StreetName1, list[x].AddressLine2, list[x].City, list[x].State, list[x].Zip, list[x].Phone, children, adults, date };
                   allInfo = row;
               }
               
           
            db.CloseAll();
            return allInfo;
        }
      /*  DBConnect db = new DBConnect();
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
            db.CloseAll(); */
    }
}
