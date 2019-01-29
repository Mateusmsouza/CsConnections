using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CsConnections
{
    class FormatLineAll
    {
        public static String entry(String[] time)
        {
            int seconds = 0;

            if (time.Any())
            {
                foreach(string text in time)
                {
                    
                    String[] tempLine = text.Split(' ');
                    seconds = seconds + FormatLine.makeItSecond(Convert.ToInt32(tempLine[3].Split(':')[0]), Convert.ToInt32(tempLine[3].Split(':')[1]), Convert.ToInt32(tempLine[3].Split(':')[2]));

                }
  
            }
            return FormatLine.makeItHour(seconds);
        }
    }
}
