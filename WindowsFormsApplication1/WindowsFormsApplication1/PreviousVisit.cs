using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class PreviousVisit
    {
        private int numChildren;
        private int numAdults;
        private DateTime date = new DateTime();
        private int patronId;
        private String date1;
        public PreviousVisit()
        {
            DateTime d=new DateTime ();
            setPreviousVisit(0,0,0,d);
        }

        public PreviousVisit(int id, int numC, int numA, DateTime d)
        {
            setPreviousVisit(id,numC, numA, d);
        }

        public int NumChildren
        {
            set { numChildren = value; }
            get { return numChildren; }
        }

        public int NumAdults
        {
            set { numAdults = value; }
            get { return numAdults; }
        }

        public DateTime Date
        {
            set { date = value; }
            get { return date; }
        }
        public String Date1
        {
            set { date1 = value; }
            get { return date1; }
        }
        public int PatronId
        {
            set { patronId = value; }
            get { return patronId; }
        }
        public void setPreviousVisit(int id,int numC, int numA, DateTime d)
        {
            this.patronId =id;
            this.numAdults = numA;
            this.numChildren = numC;
            this.date = d;
        }
    }

    
}
