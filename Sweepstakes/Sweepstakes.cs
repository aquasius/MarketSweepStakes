using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Sweepstakes
    {
        //member variables (has a)
        Dictionary<int, Contestant> sweepstakesContestants = new Dictionary<int, Contestant>();
        Dictionary<int, Contestant> contestants;
        Random random = new Random();
        int Drawing;
        int regNumber;
        int contestantCount;
        string name;
        Contestant winner;
        
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }


        //constructor
        public Sweepstakes(string name)
        {
            contestantCount = 0;
           Dictionary<int, Contestant> sweepstakesContestants = new Dictionary<int, Contestant>();
            random = new Random();
        }


        // member methods (can do)
        public void RegisterContestant(Contestant contestant)
        {

            regNumber = contestants.Count() + 1;
            contestants.Add(regNumber, contestant);
        }

        public string PickWinner()
        {
            Contestant winner = contestants[random.Next(0, contestantCount)];
            PrintContestantInfo(winner);
            string winnerEmail = winner.emailAddress;
            return winner.firstName;


        }

        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine("Name: " + contestant.firstName + contestant.lastName + " Email: " + contestant.emailAddress + " Registration Number: " + contestant.registerNumber);
        }


    }
}
