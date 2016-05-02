using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTracking
{
    class Income: Person 
    {
        //class to create the incoming income per person
        private int totalIncome;
        private int extraIncome;
        private int primaryIncome;
        
        public Income(int nTotalIncome, int nExtraIncome, int nPrimaryIncome,string nFirstName, string nLastName, string nJob): 
            base(nFirstName, nLastName, nJob)
        {
            totalIncome = nTotalIncome;
            extraIncome = nExtraIncome;
            primaryIncome = nPrimaryIncome;
        }
        public int TotalIncome
        {
            get
            {
                return totalIncome;
            }
            set
            {
                totalIncome = value;
            }
        }
        public int ExtraIncome
        {
            get
            {
                return extraIncome;
            }
            set
            {
                extraIncome = value;
            }
        }
        public int PrimaryIncome
        {
            get
            {
                return primaryIncome;
            }
            set
            {
                primaryIncome = value;
            }
        }
    }
}
