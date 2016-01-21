using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass1
{
    class Employee
    {
        //Backing fields
        private string firstNameString;
        private string lastNameString;
        private decimal weeklySalaryDecimal;

        //getters and setters
        public string FirstNameString
        {
            get { return firstNameString; }
            set { firstNameString = value; }
        }

        public string LastNameString
        {
            get { return lastNameString; }
            set { lastNameString = value; }
        }

        public decimal WeeklySalaryDecimal
        {
            get { return weeklySalaryDecimal; }
            set {weeklySalaryDecimal = value; }
        }

        //One Method that is public.  Can be accessed from other classes
        public string GetFullName()                  
        {
            return this.firstNameString + "  " + this.lastNameString;
        }

        public override string ToString()
        {
            return this.firstNameString + " " + this.lastNameString + " " + this.weeklySalaryDecimal.ToString("C");
        }

        //One method that is private.  Can only be called from inside this class
        private string foo()
        {
            return "FOO";
        }

        // 3 parameter constructor
        public Employee(string firstNameString, string lastNameString, decimal weeklySalaryDecimal)
        {
            //Assign the passed in values to the fields
            this.firstNameString = firstNameString;
            this.lastNameString = lastNameString;
            //Assign the passed in value by the property
            this.WeeklySalaryDecimal = weeklySalaryDecimal;
        }

        //Default constructor
        public Employee()
        {
            //Left blank...For now...
        }
    }
}
