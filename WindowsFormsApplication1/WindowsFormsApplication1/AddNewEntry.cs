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
        Random rng = new Random();

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
            //prevVisTextField = prevVis;
            numChildTextField = numC;
            numAdultsTextField = numA;
            monthTab1 = month;
            yearTab1 = year;
            dayTab1 = day;
        }
        public void save(AddNewEntry cust)
        {
            bool rand = false; 
            DBConnect db = new DBConnect();
            int count = -1;
            //need to fill in addr
            int idRand = -1; 
            while (!rand)
            {
                idRand = rng.Next(1, 1000000);
                String query1 = "SELECT * FROM patron WHERE id = '" + idRand + "'";
                count = db.Count(query1);
                if (count == 0)
                {
                    rand = true;
                }
                db.CloseAll();
            }
            Address addr = new Address(idRand, cust.streetNumNameTextField, cust.addrTextField2, cust.cityTextField, cust.stateTextField, cust.zipTextField);
            int month=DateTime.ParseExact(cust.monthTab1, "MMMM", CultureInfo.CurrentCulture).Month;
            DateTime d1 = new DateTime(Convert.ToInt32(cust.yearTab1), month, Convert.ToInt32(cust.dayTab1));

            PreviousVisit pv = new PreviousVisit(idRand, Convert.ToInt32(cust.numChildTextField), Convert.ToInt32(cust.numAdultsTextField), d1);
            Patron p = new Patron(idRand, cust.fNameTextField, cust.lNameTextField, cust.miTextField, cust.phoneTextField, addr, pv);
            db.addPatron(p);
            db.CloseAll();
        }
    }
}