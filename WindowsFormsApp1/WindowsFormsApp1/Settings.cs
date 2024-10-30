using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Settings
    {
            public static int SalaryCycle(DateTime EndDate, DateTime StartDate)
            {
                TimeSpan dateDifference = EndDate - StartDate;
                int cyclerange = dateDifference.Days;
                return cyclerange;

            }
 
    }
}
