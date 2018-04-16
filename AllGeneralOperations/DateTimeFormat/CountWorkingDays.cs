using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace DateTimeFormat
{
    class CountWorkingDays
    {
        static void Main(string[] args)
        {
            DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            int countWorkingDays = 0;
            bool isHoliday = false;

            DateTime[] holidays = new DateTime[]
            {
                DateTime.ParseExact("01-01-1980", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("03-03-1980", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("01-05-1980", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("06-05-1980", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("24-05-1980", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("06-09-1980", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("22-09-1980", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("01-11-1980", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("24-12-1980", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("25-12-1980", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("26-12-1980", "dd-MM-yyyy", CultureInfo.InvariantCulture)
            };

            for (DateTime i = startDate; i <= endDate; i = i.AddDays(1))
            {
                if (i.DayOfWeek == DayOfWeek.Saturday || i.DayOfWeek == DayOfWeek.Sunday)
                {
                    isHoliday = true;
                }

                for (int j = 0; j < holidays.Length; j++)
                {
                    if (holidays[j].Day == i.Day && holidays[j].Month == i.Month)
                    {
                        isHoliday = true;
                    }
                }
                if (!isHoliday)
                {
                    countWorkingDays++;
                }

                isHoliday = false;

            }
            Console.WriteLine($"{countWorkingDays}");
        }
    }
}
