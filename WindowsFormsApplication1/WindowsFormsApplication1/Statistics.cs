using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace ChardWayFoodPantryProject
namespace WindowsFormsApplication1
{
    class Statistics
    {
        int numChild;
        int numAdult;
        int day;
        int month;
        int year;
        String searchBy;

        public Statistics(){
             day=1;
             month=1;
             year=1;
             searchBy = "";
        }

        public Statistics(int y, int d, int m, String searchCriteria)
        {
            day = d;
            month = 1;
            year = y;
            searchBy = searchCriteria;
        }

        public void showStats(Statistics s)
        {
            DBConnect db= new DBConnect();
            String query = "";
            if (s.searchBy.Equals("Day"))
            {
                query ="SELECT numAdults, numChildren FROM previousvisits WHERE date = '"+s.year+"-"+s.month+"-"+s.day+"'";
                db.Count(query);
            }
            int[] numbers = db.SelectPatron(query);
        }
    }
}
