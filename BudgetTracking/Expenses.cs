using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTracking
{
    class Expenses: Person
    {
        //Object to track expenses

        private decimal extraExpenses;
        private decimal food;
        private decimal housing;
        private decimal vehicle;
        private decimal utilities;
        private decimal entertainment;
        private decimal maintaince;
        private decimal childcare;
        
        public Expenses(decimal nExtraExpenses, decimal nFood, decimal nHousing, decimal nVehicle, decimal nUtilities, decimal nEntertainment,
            decimal nMaintaince, decimal nChildCare, string nFirstName, string nLastName, string nJob) : base (nFirstName, nLastName, nJob)
        {
            extraExpenses = nExtraExpenses;
            food = nFood;
            housing = nHousing;
            vehicle = nVehicle;
            utilities = nUtilities;
            entertainment = nEntertainment;
            maintaince = nMaintaince;
            childcare = nChildCare;
        }

        public decimal ExtraExpenses
        {
            get
            {
                return extraExpenses;
            }
            set
            {
                extraExpenses = value;
            }
        }
        public decimal Food
        {
            get
            {
                return food;
            }
            set
            {
                food = value;
            }
        }
        public decimal Housing
        {
            get
            {
                return housing;
            }
            set
            {
                housing = value;
            }
        }
        public decimal Utilities
        {
            get
            {
                return utilities;
            }
            set
            {
                utilities = value;
            }
        }
        public decimal Vehicles
        {
            get
            {
                return vehicle;
            }
            set
            {
                vehicle = value;
            }
        }
       public decimal Entertainment
        {
           get
            {
                return entertainment;
            }
           set
            {
                entertainment = value;
            }
        }
        public decimal Maintaince
       {
            get
           {
               return maintaince;
           }
            set
           {
               maintaince = value;
           }
       }
        public decimal ChildCare
        {
            get
            {
                return childcare;
            }
            set
            {
                childcare = value;
            }
        }
    }
}
