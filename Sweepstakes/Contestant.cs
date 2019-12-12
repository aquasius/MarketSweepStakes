using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Contestant
    {
        //member variables (has a)
        public string firstName;
        public string lastName;
        public string emailAddress;
        public int registerNumber;

        //constructor


        //member methods (can do)
        public void GetContestantInfo()
        {
            UserInterface.GetContestantInformation("What is your first name:");
            firstName = Console.ReadLine();
            UserInterface.GetContestantInformation("Please enter your last name:");
            lastName = Console.ReadLine();
            UserInterface.GetContestantInformation("Please enter a valid e-mail address:");
            emailAddress = Console.ReadLine();
        }

    }
}
