using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTracking
{
    class Person
    {
        //Creates the end user profile
        protected string firstName;
        protected string lastName;
        protected string job;
       
        
        public Person(string nFirstName, string nLastName, string nJob)
        {
            firstName = nFirstName;
            lastName = nLastName;
            job = nJob;
            
        }
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }
        public string Job
        {
            get
            {
                return job;
            }
            set
            {
                job = value;
            }
        }
    }
}
