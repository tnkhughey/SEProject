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

namespace WindowsFormsApplication1
{
    //May need to add another button to save new visit? 
    //Updater method: check comments below
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
            form.numAdultsUpdateTextBox.Text = Convert.ToString(pat.NumAdults);
            form.numUpdateChildTextBox.Text = Convert.ToString(pat.NumChildren);
            form.phoneUpdateTextBox.Text = pat.Phone;
            form.monthUpdateMenuTab1.Text = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(pat.Date.Month);
            form.dayUpdateMenuTab1.Text = pat.Date.Day.ToString();
            form.yearUpdateTab1.Text = pat.Date.Year.ToString();
            
            //Get pat. id
            myPatron.Id = pat.Id;

            //Populate prev. visits
            DBConnect db=new DBConnect();
            String query="";
            query="SELECT * FROM patron WHERE patron_id='"+pat.Id+"'";
            List<Patron> p=new List<Patron>();
            p=db.SelectPatron(query);
            for (int x = 0; x < p.Count; x++)
                form.prevVisitsUpdate.Items.Add(p.ElementAt(x).Date);
        }
        //Takes input from text fields in GUI and updates = patron info. 
        public void update(String fName, String lName, String mi, String streetNameNum, String addr2, String city, String state, String zip, String phone, String numC, String numA, String month, String year, String day)
        {
            DBConnect db = new DBConnect();
            //query1 and 2 are not fully correct. Need to add in correct patron id. All ids we are currently getting are 0
            //We may want to just do a select query using fname, lastname, phone, addr, to identify correct patron. Then we can get id
            //Also, do we need to update previousvisits?
            try
            {
                //Different queries for different tables
                String query1 = "UPDATE patron SET firstName = '" + fName + "', lastName = '" + lName + "', middleInitial = '" + mi + "', phone = '" + phone + "' WHERE patron_id = '" + myPatron.Id + "'";
                String query2 = "UPDATE address SET streetNum = '" + streetNameNum + "', addressLine2 = '" + addr2 + "', city = '" + city + "', state = '" + state + "', zip = '" + zip + "' WHERE patron_id='" + myPatron.Id + "'";
                
                //Need to convert month into proper DateTime format YYYY-MM-DD
                int mon = DateTime.ParseExact(month, "MMMM", CultureInfo.CurrentCulture).Month;
                DateTime d1 = new DateTime(Convert.ToInt32(year), mon, Convert.ToInt32(day));
                PreviousVisit pv = new PreviousVisit(myPatron.Id, Convert.ToInt32(numC), Convert.ToInt32(numA), d1);
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