using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    internal class timeConversion
    {
        public static string time_Conversion(string s)
        {
            var strHour = s.Substring(0, 2);
            var hour = Convert.ToInt16(s.Substring(0, 2));
            var minute = s.Substring(3, 2);
            var second = s.Substring(6, 2);
            string lastTwochar = s.Substring(8, 2);
            if (lastTwochar == "AM")
            {
                if (hour == 12)
                {
                    string timestr = "";

                    timestr = string.Format("0{0}:{1}:{2}", hour - 12, minute, second);


                    return timestr;

                }
                else
                {
                    return s.Substring(0, 8);

                }
            }
            else
            {

                if (hour == 12)
                {
                    return string.Format("{0}:{1}:{2}", Convert.ToInt16(hour), minute, second);

                }
                else
                {
                    return string.Format("{0}:{1}:{2}", Convert.ToInt16(hour) + 12, minute, second);

                }
            }
            //*****************************
            //var sDateTime= Convert.ToDateTime(s);
            //return sDateTime.ToString("HH:mm:ss", CultureInfo.InvariantCulture);


        }
    }
}
