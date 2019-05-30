using System;

namespace CMS.Utilities
{
    public static class DateTimeExtensions
    {
        public static bool IsSameDay(this DateTime dt, DateTime dateCompare)
        {
            if ((dateCompare.Day != dt.Day) || (dateCompare.Month != dt.Month) || (dateCompare.Year != dt.Year))
            {
                return false;
            }

            return true;
        }


        public static bool IsInDateRange(DateTime dateToCompare, DateTime startDate, DateTime endDate)
        {
            if ((dateToCompare.Date < startDate.Date)
                || (dateToCompare.Date > endDate.Date))
            {
                return false;
            }

            return true;
        }

        public static int DateTimeMonth(this DateTime dt, DateTime dateCompare)
        {
            int difference = dateCompare.Month - dt.Month;
            if (difference < 0)
            {
                difference += 12;
            }
            return difference;
        }
    }
}
