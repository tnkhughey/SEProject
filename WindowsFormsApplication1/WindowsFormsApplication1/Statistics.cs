﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Statistics class allows for user to find stats on number of adults and children who visited during a certain time
namespace WindowsFormsApplication1
{
    class Statistics
    {
        
        private int day;
        private int month;
        private int year;
        private String searchBy;//user's can get stats by day, month or year

        public Statistics(){
             day=1;
             month=1;
             year=1;
             searchBy = "";
        }

       
        public Statistics(int y, int m, int d, String searchCriteria)
        {
            day = d;
            month = m;
            year = y;
            searchBy = searchCriteria;
        }

        public Statistics(int y, String searchCriteria)
        {
            year = y;
            searchBy = searchCriteria;
        }

        public Statistics(int y, int m, String searchCriteria)
        {
            month = m;
            year = y;
            searchBy = searchCriteria;
        }

     
        public void showStats()
        {
            DBConnect db = new DBConnect();
            String query = "";
            int[] numbers = new int[1];//holds the number of children in first element and adults in second element
            
            //user wants to see stats on a specific day of the year
            if (searchBy.Equals("Day"))
            {
                query = "SELECT numAdults, numChildren FROM previousvisits WHERE date = '" + year + "-" + month.ToString("D2") + "-" + day.ToString("D2") + "'";
            }
            //user wants to see stats for certain month of year
            else if (searchBy.Equals("Month"))
            {
                query = "SELECT numAdults, numChildren FROM previousvisits WHERE date LIKE '" + year + "-" + month.ToString("D2") + "-__'";
            }
            //get stats for whole year
            else
            {
                query = "SELECT numAdults, numChildren FROM previousvisits WHERE date LIKE '" + year + "-_____'";
            }
            numbers=db.getStats(query);
            var form = Form1.ActiveForm as Form1;//to access GUI elements
            //clear any data already on the chart
            form.statsChart.Series["Adults"].Points.Clear();
            form.statsChart.Series["Children"].Points.Clear();

            //Display number of children and adults for certain d
            form.statsChart.Series["Children"].Points.AddXY("Number of Children:"+numbers[1]+"       Number of Adults:"+numbers[0] ,numbers[1]);
            form.statsChart.Series["Adults"].Points.AddXY("",numbers[0]);
        }
    }
}
