using System;
using System.Collections.Generic;
using System.Text;

namespace WorkTimeManager
{
    public static class Tools
    {
        const string TIMESTAMP_FORMAT = "yyyyMMdd";
        public static string convertToTimestamp(DateTime dateTime)
        {
            return dateTime.ToString("yyyyMMdd");
        }
        public static DateTime convertToDatetime(string timeStamp)
        {
            return DateTime.ParseExact(timeStamp, TIMESTAMP_FORMAT, System.Globalization.CultureInfo.InvariantCulture);
        }
        public static DateTime nextWorkingDay(DateTime date)
        {
            date = date.AddDays(1);
            return new DateTime(date.Year, date.Month, date.Day,
                    Settings.StartTime.Value.Hour, Settings.StartTime.Value.Minute, Settings.StartTime.Value.Second);
        }

    }
}
