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

//The purpose of this class is mainly to be used with the Updater Form.
//A user can change, delete or add data for a patron.
namespace WindowsFormsApplication1
{
    
    public class Edit
    {
        Patron myPatron;
        private String monthTab;
        private String yearTab;
        private String dayTab;

        public Edit()
        {
            myPatron = new Patron();
            monthTab = "";
            yearTab = "";
            dayTab = "";
        }
        
        //pat: the patron to be edited/viewed
        //form:The Updater form(Form2)
        public Edit(Patron pat,Form2 form)
        {
            myPatron = new Patron();
            form.fNameUpdateTextBox.AppendText(pat.FirstName);
            form.lNameUpdateTextBox.Text = pat.LastName;
            form.miUpdateTextBox.Text = pat.MiddleInitial;
            form.addrNumNameUpdateTextBox1.Text = pat.StreetName1;
            form.addrUpdateTextBox2.Text = pat.AddressLine2;
            form.cityUpdateTextBox1.Text = pat.City;
            form.stateUpdateTextBox1.Text = pat.State;
            form.zipUpdateTextBox1.Text = pat.Zip;
            form.numAdultsUpdateTextBox.Text = ""; 
            form.numUpdateChildTextBox.Text = ""; 
            form.phoneUpdateTextBox.Text = pat.Phone;
            form.monthUpdateMenuTab1.Text = "Month";
            form.dayUpdateMenuTab1.Text = "Day";
            form.yearUpdateTab1.Text = "Year"; 
            form.idTextBox.Text = pat.Id.ToString();

            //Populate prev. visits by getting patron visits from table
            DBConnect db=new DBConnect();
            String query="";
            query="SELECT * FROM previousvisits WHERE patron_id='"+pat.Id+"' ORDER BY date DESC";
            List<PreviousVisit> p = new List<PreviousVisit>();
            p=db.SelectPreviousVisit(query);
            //Add in the previous visit dates to the drop down menu "Previous Visits"
            for (int x = 0; x < p.Count; x++)
            {
                String[] row = { p.ElementAt(x).Date.ToShortDateString(), p.ElementAt(x).NumAdults.ToString(), p.ElementAt(x).NumChildren.ToString()  };
                form.prevVisitsDataGrid.Rows.Add(row); 
            }
        }

        //Takes input from text fields in GUI and updates = patron info. 
        public void update(String fName, String lName, String mi, String streetNameNum, String addr2, String city, String state, String zip, String phone, String numC, String numA, String month, String year, String day, String id)
        {
            DBConnect db = new DBConnect();
           
            try
            {
                int formattedMonth = DateTime.ParseExact(month, "MMMM", CultureInfo.CurrentCulture).Month;//Convert a month name to the months corresponding number. Ex: Decemeber-> 12
                String formattedDate = year + "-" + formattedMonth + "-" + Convert.ToInt32(day).ToString("D2") ;
                //Different queries for different tables
                String query1 = "UPDATE patron SET firstName = '" + 
                    fName + "', lastName = '" + 
                    lName + "', middleInitial = '" + 
                    mi + "', phone = '" + 
                    phone + 
                    "' WHERE patron_id = '" + id + "'";

                String query2 = "UPDATE address SET streetNum = '" + 
                    streetNameNum + "', addressLine2 = '" + 
                    addr2 + "', city = '" + 
                    city + "', state = '" + 
                    state + "', zip = '" + 
                    zip + 
                    "' WHERE patron_id='" + id + "'";

                String query3 = "INSERT INTO previousvisits VALUES ('" +
                   id + "', '" +
                   formattedDate + "', '" +
                   numC + "', '" +
                   numA + "')";
                
                //Need to convert month into proper DateTime format YYYY-MM-DD
                int mon = DateTime.ParseExact(month, "MMMM", CultureInfo.CurrentCulture).Month;
                DateTime d1 = new DateTime(Convert.ToInt32(year), mon, Convert.ToInt32(day));
                PreviousVisit pv = new PreviousVisit(myPatron.Id, Convert.ToInt32(numC), Convert.ToInt32(numA), d1);
                db.Query(query1);
                db.Query(query2);
                db.Query(query3);

                db.CloseAll();
                var form = Form2.ActiveForm as Form2;
                form.failureLabel.Visible = false;
                form.successLabel.Visible = true;//Display success
            }
            catch(Exception e)
            {
                MessageBox.Show("Cannot add patron's visit two times on same day");
                var form = Form2.ActiveForm as Form2;
                form.failureLabel.Visible = true;//Display patron not updated
                form.successLabel.Visible = false;

            }
        }

        //Update patron info. without adding a new visit
        public void updateNoPrevVisit(String fName, String lName, String mi, String streetNameNum, String addr2, String city, String state, String zip, String phone, String id)
        {
            DBConnect db = new DBConnect();
           
            try
            {
                //Different queries for different tables
                String query1 = "UPDATE patron SET firstName = '" +
                    fName + "', lastName = '" +
                    lName + "', middleInitial = '" +
                    mi + "', phone = '" +
                    phone +
                    "' WHERE patron_id = '" + id + "'";

                String query2 = "UPDATE address SET streetNum = '" +
                    streetNameNum + "', addressLine2 = '" +
                    addr2 + "', city = '" +
                    city + "', state = '" +
                    state + "', zip = '" +
                    zip +
                    "' WHERE patron_id='" + id + "'";

                db.Query(query1);
                db.Query(query2);

                db.CloseAll();
                var form = Form2.ActiveForm as Form2;
                form.failureLabel.Visible = false;
                form.successLabel.Visible = true;//Display success
            }
            catch
            {
                var form = Form2.ActiveForm as Form2;
                form.failureLabel.Visible = true;//Display patron not updated
            }
        }
    }
}