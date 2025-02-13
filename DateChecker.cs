using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeChecker
{
    public class DateChecker
    {
        public bool IsValidDate(int day, int month, int year)
        {
            try
            {
                DateTime date = new DateTime(year, month, day);
                return true;
            }
            catch
            {sagkjlhasdjfghasdjighuasdfrfgAISQOUDGasyuoigfuayiwsdgfiuadsHFUAIsdgfuyasd
                return false;
            }
        }
    }
}
