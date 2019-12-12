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
        string name;
        public int contestantCounter;
        public int maxContestants;
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

        }


        // member methods (can do)
        public void RegisterContestant(Contestant, contestant)
        {

        }

        public string PickWinner()
        {

        }

        public void PrintContestantInfo(Contestant, contestant)
        {

        }


    }
}
