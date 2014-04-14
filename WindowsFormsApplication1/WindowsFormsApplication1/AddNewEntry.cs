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
    public class AddNewEntry
    {
        private String fNameTextField;
        private String lNameTextField;
        private String miTextField;
        private String streetNumNameTextField;
        private String cityTextField;
        private String stateTextField;
        private String zipTextField;
        private String addrTextField2;
        private String phoneTextField;
        private String prevVisTextField;
        private String numChildTextField;
        private String numAdultsTextField;
        private String monthTab1;
        private String yearTab1;
        private String dayTab1;
        Random rng = new Random();//for creating patron id

        //Default AddNewEntry Constructor
        public AddNewEntry()
        {
            fNameTextField = "";
            lNameTextField = "";
            miTextField = "";
            streetNumNameTextField = "";
            cityTextField = "";
            stateTextField = "";
            zipTextField = "";
            addrTextField2 = "";
            phoneTextField = "";
            prevVisTextField = "";
            numChildTextField = "";
            numAdultsTextField = "";
            monthTab1 = "";
            yearTab1 = "";
            dayTab1 = "";
            
        }
        //Takes patron info. from GUI textfields and stores into object
        public AddNewEntry(String fName, String lName, String mi, String streetNameNum, String addr2, String city, String state, String zip, String phone, String numC, String numA, String month, String year, String day)
        {
            fNameTextField = fName;
            lNameTextField = lName;
            miTextField = mi;
            streetNumNameTextField = streetNameNum;
            addrTextField2 = addr2;
            phoneTextField = phone;
            cityTextField = city;
            stateTextField = state;
            zipTextField = zip;
            numChildTextField = numC;
            numAdultsTextField = numA;
            monthTab1 = month;
            yearTab1 = year;
            dayTab1 = day;
        }
        //Save the patron to the database
        public void save(AddNewEntry cust)
        {
            bool rand = false; 
            DBConnect db = new DBConnect();
            int count = -1;
            //need to fill in addr
            int idRand = -1; 
            //generate a pat. id(which will be randomly generated and unique for each patron
            while (!rand)
            {
                idRand = rng.Next(1, 1000000);//id between 1 and 1,000,000
                String query1 = "SELECT * FROM patron WHERE id = '" + idRand + "'";
                count = db.Count(query1);//check to see if pat. id is taken
                if (count == 0)
                {
                    rand = true;
                }
                db.CloseAll();
            }
            try
            {
                Address addr = new Address(idRand, cust.streetNumNameTextField, cust.addrTextField2, cust.cityTextField, cust.stateTextField, cust.zipTextField);
                
                //Format the date in the format "YYYY-MM-DD"
                int month = DateTime.ParseExact(cust.monthTab1, "MMMM", CultureInfo.CurrentCulture).Month;
                DateTime d1 = new DateTime(Convert.ToInt32(cust.yearTab1), month, Convert.ToInt32(cust.dayTab1));
             
                PreviousVisit pv = new PreviousVisit(idRand, Convert.ToInt32(cust.numChildTextField), Convert.ToInt32(cust.numAdultsTextField), d1);
                Patron p = new Patron(idRand, cust.fNameTextField, cust.lNameTextField, cust.miTextField, cust.phoneTextField, addr, pv);
               
                //Add to the database the user's entry
                db.addPatron(p);
                //Close all connections
                db.CloseAll();
                EmptyTextBoxes();

                //produce info. message that patron did  get added
                var form = Form1.ActiveForm as Form1;
                form.successLabel.Visible = true;
            }
            catch
            {
                //produce info. message that patron did not get added
                var form = Form1.ActiveForm as Form1;
                form.failureLabel.Visible = true;
                form.successLabel.Visible = false;
            }
        }
        //Clear textfields in GUI after patron added
        public static void EmptyTextBoxes()
        {
            var form = Form1.ActiveForm as Form1;
            form.fNameTextBox.Clear();
            form.lNameTextBox.Clear();
            form.miTextBox.Clear();
            form.addrNumNameTextBox1.Clear();
            form.addrTextBox2.Clear();
            form.cityTextBox1.Clear();
            form.stateTextBox1.Clear();
            form.zipTextBox1.Clear();
            form.numAdultsTextBox.Clear();
            form.numChildTextBox.Clear();
            form.phoneTextBox.Clear();
            form.monthMenuTab1.SelectedIndex = 0;
            form.dayMenuTab1.SelectedIndex = 0;
            form.yearTab1.Text = "Year";
            form.failureLabel.Visible = false;
            
        }
    }
}