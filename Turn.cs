using System;
using System.Collections.Generic;
using System.Text;

namespace MVC_Conway.Common
{
    public struct Turn
    {
        private IList<CellEventTypes> eventList;
        private CellEvent cellEvent {get;}

        private Grid simGrid { get; }

        private int numMovement, numFights, numReproduce;

        private int mov_rate_exp, fight_rate_exp,
                    rep_rate_exp;

        private double lambda;
        public Turn(Grid grid, CellEvent cEvent, int x = 0, int y = 0, int z = 0)
        {
            cellEvent = cEvent;
            simGrid = grid;
            
            mov_rate_exp = x;
            lambda = (simGrid.MaxRows * simGrid.MaxColumn / 3.0) * Math.Pow(10, mov_rate_exp);
           /* numMovement = Poisson(lambda);*/


            fight_rate_exp = y;
            lambda = (simGrid.MaxRows * simGrid.MaxColumn / 3.0) * Math.Pow(10, fight_rate_exp);
            numFights = Poisson(lambda);

            rep_rate_exp = z;
            lambda = (simGrid.MaxRows * simGrid.MaxColumn / 3.0) * Math.Pow(10, rep_rate_exp);
            numReproduce = Poisson(lambda);
        }

        private int Poisson(double lambda)
        {

        }

        private void AddEventToList()
        {
            for (int i = 0; i < numMovement; i++)
            {
                eventList.Add(CellEventTypes.Movement);
            }

            for (int i = 0; i < numFights; i++)
            {
                eventList.Add(CellEventTypes.Fight);
            }

            for (int i = 0; i < numReproduce; i++)
            {
                eventList.Add(CellEventTypes.Reproduction);
            }
            EventListShuffler();
        }

        public void PlayEvents()
        {
           
            foreach (CellEventTypes eventTypes in eventList)
            {
                if (eventTypes == CellEventTypes.Movement)
                {
                    cellEvent.Movement();
                }
                else if (eventTypes == CellEventTypes.Fight)
                {
                    cellEvent.Fight();
                }
                else
                    cellEvent.Reproduce();
            }
        }

        private void EventListShuffler()
        {
            Random rng = new Random();
            int r = eventList.Count;
            while (r >1)
            {
                r--;
                int k = rng.Next(r + 1);
                CellEventTypes value = eventList[k];
                eventList[k] = eventList[r];
                eventList[r] = value;

            }
        }
    }
}
