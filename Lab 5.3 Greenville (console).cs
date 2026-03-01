using System;

class Greenville
{
    static void Main()
    {
        bool loop = true;
        while (loop)
        {
            // last year
            Console.Write("Enter last years revenue >> ");
            int lastYearContestants = Convert.ToInt32(Console.ReadLine());
            if (lastYearContestants < 0 || lastYearContestants > 30)
            {
                Console.WriteLine("invalid input");
                continue;
            }          
            int lastYearRevenue = lastYearContestants * 25;
            string formatLastYear = lastYearRevenue.ToString("c");

            // this year
            Console.Write("Enter this years revenue >> ");
            int thisYearContestants = Convert.ToInt32(Console.ReadLine());

            if ((thisYearContestants < 0) || (thisYearContestants > 30))
            {
                Console.WriteLine("invalid input");
                continue;
            }
            int thisYearRevenue = thisYearContestants * 25;
            string formatThisYear = thisYearRevenue.ToString("c");

            //output
            Console.WriteLine($"\nThere were {thisYearContestants} and {formatThisYear} this year.\n" +
                              $"Along with {lastYearContestants} and {formatLastYear} last year.");
            
            if (thisYearContestants >  lastYearContestants)
            {
                Console.WriteLine("\nThere were more contestants this year!");
            }
            else if (thisYearContestants < lastYearContestants)
            {
                Console.WriteLine("\nThere were more contestants last year, whoops!");
            }
            else
            {
                Console.WriteLine("\nThere were the same amount of contestants this year\n" +
                                   "as last year. I refuse to believe this!");
            }
            loop = false;
        }   
    }
}
