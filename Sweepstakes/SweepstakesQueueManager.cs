using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        Queue<SweepstakesOne> sweepstakesQueue = new Queue<SweepstakesOne>();
        Queue<SweepstakesOne> tempSweepstakesQueue = new Queue<SweepstakesOne>();
        public SweepstakesOne GetSweepstakes(string name)
        {
            SweepstakesOne dequeuedSweepstakes;
            dequeuedSweepstakes = sweepstakesQueue.Dequeue();
           

        public SweepstakesOne GetSweepstakes()
        {
            throw new NotImplementedException();
        }


    }
}
