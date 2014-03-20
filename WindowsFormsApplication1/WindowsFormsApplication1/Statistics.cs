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

        public Statistics(int y, int m, int d, String searchCriteria)
        {
            day = d;
            month = m;
            year = y;
            searchBy = searchCriteria;
            MessageBox.Show(y+" "+m+" "+d+" "+searchBy);
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
            //int[] numbers = db.SelectPatron(query);
        }
        */
        public void showStats()
        {
            DBConnect db = new DBConnect();
            String query = "";
            int[] numbers = new int[1];
            //month = Int32.Parse(month.ToString("#0"));
            //day = Int32.Parse(day.ToString("#0"));
            MessageBox.Show(month.ToString("D2")+" " +day.ToString("D2"));
            if (searchBy.Equals("Day"))
            {
                query = "SELECT numAdults, numChildren FROM previousvisits WHERE date = '" + year + "-" + month.ToString("D2") + "-" + day.ToString("D2") + "'";
                MessageBox.Show(query);
            }
            else if (searchBy.Equals("Month"))
            {
                query = "SELECT numAdults, numChildren FROM previousvisits WHERE date LIKE '" + year + "-" + month.ToString("D2") + "-__'";
                MessageBox.Show(query);
            }
            else
            {
                query = "SELECT numAdults, numChildren FROM previousvisits WHERE date LIKE '" + year + "-_____'";
                MessageBox.Show(query);
            }
            numbers=db.getStats(query);
            var form = Form1.ActiveForm as Form1;
            form.statsChart.Series["Adults"].Points.Clear();
            form.statsChart.Series["Children"].Points.Clear();

            form.statsChart.Series["Children"].Points.AddXY("Number of Children:"+numbers[1]+"       Number of Adults:"+numbers[0] ,numbers[1]);
            form.statsChart.Series["Adults"].Points.AddXY("", numbers[0]);
        }
    }
}
