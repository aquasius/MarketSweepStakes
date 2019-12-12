using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class MarketingFirm
    {
        //member variables(has a)
        ISweepstakesManager sweepStakesManager;
        Sweepstakes sweepstakes;
        string sweepstakesName;
        int maxContestants;

        //constructor
        public MarketingFirm(ISweepstakesManager sweepstakesManager)
        {
            this.sweepStakesManager = sweepstakesManager;
            sweepstakes = new Sweepstakes(SweepStakesName, PromptMaxContestant);

        }

        //member methods (can do)
        public void SweepStakesName()
        {
            UserInterface.EnterSweepstakesName();
            sweepstakesName = Console.ReadLine();
        }

        public void PromptMaxContestant()
        {
            UserInterface.EnterMaxNumberOfContestant();
            maxContestants = Convert.ToInt32(Console.ReadLine());
        }


    }
}
