using System;
using System.Collections.Generic;
using System.Text;

namespace Ghosts.Common
{
    public class Turn
    {
        /// <summary>
        /// Variable used to save the current 
        /// turn's
        /// event to happen in a list
        /// </summary>
        private IList<CellEventTypes> eventList;

        /// <summary>
        /// Property used to reference a cell 
        /// event
        /// </summary>
        private CellEvent cellEvent { get; }

        /// <summary>
        /// Property used to reference the 
        /// simulation's grid
        /// </summary>
        private Grid simGrid { get; }
        private Parameters parameters {get;}

        private Random rng;

        /// <summary>
        /// Variables used to represent the number
        /// of times each type of event is going to
        /// happen during the current turn
        /// </summary>
        private int numMovement, numFights, numReproduce;

        /// <summary>
        /// Variable used in the Poisson method
        /// </summary>
        private double lambda;

        /// <summary>
        /// Constructor for the Turn struct
        /// </summary>
        /// <param name="grid">Grid used in the 
        /// simulation</param>
        /// <param name="cEvent"></param>
        public Turn(Grid grid, Parameters parameters)
        {
            eventList = new List<CellEventTypes>();
            rng = new Random();

            simGrid = grid;
            cellEvent = new CellEvent(simGrid.CellGroup);

            lambda = (simGrid.MaxRows * 
                simGrid.MaxColumn / 3.0) * 
                Math.Pow(10, parameters.Move_rate_exp);

            numMovement = Poisson(lambda);

            lambda = (simGrid.MaxRows * 
                simGrid.MaxColumn / 3.0) * 
                Math.Pow(10, parameters.Fight_rate_exp);

            numFights = Poisson(lambda);

            lambda = (simGrid.MaxRows * 
                simGrid.MaxColumn / 3.0) * 
                Math.Pow(10, parameters.Rep_rate_exp);

            numReproduce = Poisson(lambda);

            AddEventToList();
        }

        /// <summary>
        /// Method used to randomly generate
        /// the number of times a specific event appears
        /// in a turn of the simulation
        /// </summary>
        /// <param name="lam">Value based of the event rate
        /// of an event tye.</param>
        /// <returns></returns>
        private int Poisson(double lam)
        {

            double lambdaLeft = lam;
            double step = 500;
            double p = 1;
            double u;
            int k = 0;

            do
            {
                k += 1;
                u = rng.NextDouble();
                p *= u;
                while (p < 1 && lambdaLeft > 0)
                {
                    if (lambdaLeft > step)
                    {
                        p *= Math.Pow(Math.E, step);
                        lambdaLeft -= step;
                    }
                    else
                    {
                        p = p * Math.Pow(Math.E, lambdaLeft);
                        lambdaLeft = 0;
                    }
                }
            } while (p > 1);
            return k - 1;
        }

        /// <summary>
        /// Method used to add a certain event too
        /// the connection based on the randomly
        /// generated numbers for each type
        /// </summary>
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

        /// <summary>
        /// Method used to run all the chosen
        /// events in the collection
        /// </summary>
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

        /// <summary>
        /// Method used to shuffle the collection
        /// contents
        /// </summary>
        private void EventListShuffler()
        {
            int r = eventList.Count;
            while (r > 1)
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
