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
        public Edit(Patron pat)
        {
            myPatron = pat; 
            var form = Form2.ActiveForm as Form2;
            String fName = "fdsg ";
            fName = pat.FirstName; 
            //form.fNameUpdateTextBox.Text = fName;
           
            form.fNameUpdateTextBox.AppendText(fName); 
            /*form.miUpdateTextBox.Text = pat.MiddleInitial;
            form.addrNumNameUpdateTextBox1.Text = pat.StreetName1;
            form.addrUpdateTextBox2.Text = pat.AddressLine2;
            form.cityUpdateTextBox1.Text = pat.City;
            form.stateUpdateTextBox1.Text = pat.State;
            form.zipUpdateTextBox1.Text = pat.Zip;
            //form.numAdultsTextBox.Text = Convert.ToString(pat.NumAdults);
            //form.numChildTextBox.Text = Convert.ToString(pat.NumChildren);
            form.phoneUpdateTextBox.Text = pat.Phone;
            /*form.monthMenuTab1.Text = ;
            form.dayMenuTab1.Text = ;
            form.yearTab1.Text = ;*/
        }
        public void update(String fName, String lName, String mi, String streetNameNum, String addr2, String city, String state, String zip, String phone, String numC, String numA, String month, String year, String day)
        {
            DBConnect db = new DBConnect();
            
            try
            {
                String query1 = "UPDATE patron SET firstName = '" + fName + "', lastName = '" + lName + "', middleInitial = '" + mi + "', phone = '" + phone + "' WHERE id = '" + myPatron.Id + "'";
                String query2 = "UPDATE address SET streetNum = '" + streetNameNum + "', addressLine2 = '" + addr2 + "', city = '" + city + "', state = '" + state + "', zip = '" + zip + "'";
                
                int mon = DateTime.ParseExact(month, "MMMM", CultureInfo.CurrentCulture).Month;
                DateTime d1 = new DateTime(Convert.ToInt32(year), mon, Convert.ToInt32(day));
                PreviousVisit pv = new PreviousVisit(myPatron.Id, Convert.ToInt32(numC), Convert.ToInt32(numA), d1);

                db.Query(query1);
                db.Query(query2);

                db.CloseAll();
                var form = Form2.ActiveForm as Form2;
                form.failureLabel.Visible = false;
                form.successLabel.Visible = true;
            }
            catch
            {
                var form = Form2.ActiveForm as Form2;
                form.failureLabel.Visible = true;
            }
        }
    }
}