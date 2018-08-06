using System;

namespace Lab2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int years1, months1, days1, years2, months2, days2, newYears, newMonths, newDays, ansD, ansH, ansM;

            Console.WriteLine("Enter first date years");
            years1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter first date months");
            months1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Frist date day");
            days1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second date years");
            years2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second date months");
            months2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second date day");
            days2 = int.Parse(Console.ReadLine());

            if ((years1 > 2018 || years1 < 0) || (years2 > 2018 || years2 < 0))
            
                {
                     Console.WriteLine("Years must be less then 2018 and more then 0");
                }

            else if ((months1 > 12 || months1 < 0) || (months2 > 12 || months2 < 0))
                {
                    Console.WriteLine("Months must be less then 12 but more then 0");
                }

            else if ((days1 > 365 || days1 < 0) || (days2 > 365 || days2 < 0))
                {
                    Console.WriteLine("Months must be less then 365 but more then 0");
                }

                else
                {
                    newYears = years1 - years2;

                    ansD = newYears * 365;

                    newMonths = months1 - months2;

                    ansH = newMonths * 730;

                    newDays = days1 - days2;

                    ansM = newDays * 1440;

                    Console.WriteLine("The diffrence of the two dates in days " + ansD + " hours " + ansH + "and minutes " + ansM);

                }

                        

        }

    }
}

