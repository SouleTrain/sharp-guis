using System;
using System.Linq;
using System.Linq.Expressions;

class DailyTemps
{
    static void Main()
    {
        bool close = false;
        int tempSolution = 0;

        while (!close)
        {
            //characters here will break this program
            Console.Write("\nEnter daily high temps >> ");
            int intInput = Convert.ToInt32(Console.ReadLine());

            
            if (intInput > 130 || intInput < -20)
            {
                Console.WriteLine("\nLets use real temps here friend");
            }
            
            else
            {
                //sentinal value
                Console.WriteLine("Exit and sum temps? Y / N");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "y" or "Y":
                        tempSolution += intInput;
                        Console.WriteLine($"{tempSolution} is the total of all daily temps!");
                        close = true;
                        break;
                    case "n" or "N":
                        tempSolution += intInput;
                        continue;
                }

            }
        }
    }
}
        
            

        
    
