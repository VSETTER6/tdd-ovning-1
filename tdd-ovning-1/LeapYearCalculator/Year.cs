using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYearCalculator
{
    public class Year
    {
        public bool IsChoosenYearLeapYear(int choosenYear)
        {
            if (choosenYear % 400 == 0)
            {
                return true;
            }
            if (choosenYear % 400 != 0)
            {
                return false;
            }
            else
            {
                return false;
            }
        }

        public bool IsChoosenYearDivisableBy100(int choosenYear)
        {
            if (choosenYear % 100  == 0 && choosenYear % 400 != 0)
            {
                return true;
            }
            if (choosenYear % 100 != 0) 
            {
                return false;
            }
            else
            {
                return false;
            }
        }


    }


}
