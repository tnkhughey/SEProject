using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//namespace ChardWayFoodPantryProject
namespace WindowsFormsApplication1
{
    class Statistics
    {
        private int numChild;
        private int numAdult;
        private int day;
        private int month;
        private int year;
        private String searchBy;

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

       /* public void showStats(Statistics s)
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
        */
        public void showStats()
        {
            DBConnect db = new DBConnect();
            String query = "";
            int[] numbers = new int[1];
            if (searchBy.Equals("Day"))
            {
                query = "SELECT numAdults, numChildren FROM previousvisits WHERE date = '" + year + "-" + month + "-" + day + "'";
            }
            else if (searchBy.Equals("Month"))
            {
                query = "SELECT numAdults, numChildren FROM previousvisits WHERE date LIKE '" + year + "-" + month + "-__'";
            }
            else
            {
                query = "SELECT numAdults, numChildren FROM previousvisits WHERE date LIKE '" + year + "-_____'";
            }
            numbers=db.getStats(query);
            MessageBox.Show(numbers[0]+" ");
        }
    }
}
