using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class UserInterface
    {
        public static void GetContestantInformation(string message)
        {
            Console.WriteLine(message);
        }
    
        public static void EnterSweepstakesName()
        {
            Console.Write("Please enter the name of the sweepstakes:");

        }

        public static void EnterMaxNumberOfContestant()
        {
            Console.WriteLine("Please enter the max number of contestants for this sweepstakes:");
        }


    
    }
}

