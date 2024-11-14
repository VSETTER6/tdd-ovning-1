using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYearCalculator
{
    public class Year
    {
        public bool IsChoosenYearLeapYear(bool isYearLeapYear, int choosenYear)
        {
            if (choosenYear % 400 == 0)
            {
                return isYearLeapYear == true;
            }
            if (choosenYear % 400 != 0)
            {
                return isYearLeapYear == false;
            }
            else
            {
                return false;
            }
        }
    }
}
