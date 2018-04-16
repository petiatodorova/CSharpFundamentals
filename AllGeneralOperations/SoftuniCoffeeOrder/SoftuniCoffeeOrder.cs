using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace SoftuniCoffeeOrder
{
    class SoftuniCoffeeOrder
    {
        static void Main(string[] args)
        {
            //price = (daysInMonth * capsulesCount) * pricePerCapsule

            int countOrders = int.Parse(Console.ReadLine());
            Decimal pricePerCapsule = 0.0M;
            DateTime orderDate = DateTime.MinValue;
            long capsulesCount = 0L;
            Decimal price = 0;
            int daysInMonth = 0;
            Decimal totalPrice = 0;

            for (int i = 0; i < countOrders; i++)
            {
                pricePerCapsule = Decimal.Parse(Console.ReadLine());
                orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                capsulesCount = long.Parse(Console.ReadLine());
                daysInMonth = DateTime.DaysInMonth(orderDate.Year, orderDate.Month);
                price = (daysInMonth * capsulesCount) * pricePerCapsule;
                totalPrice += price;
                Console.WriteLine($"The price for the coffee is: ${price:F2}");
            }
            Console.WriteLine($"Total: ${totalPrice:F2}");
        }
    }
}
