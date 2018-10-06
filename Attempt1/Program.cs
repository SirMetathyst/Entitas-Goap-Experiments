using System;
using System.Diagnostics;
using System.Threading;
using Entitas;

namespace Attempt1
{
    class Program
    {
        const int AGENT_COUNT = 1;

        static void Main (string[] args)
        {
            var contexts = Contexts.sharedInstance;
            var AI = contexts.aI;
            AI.OnEntityCreated += (IContext context, IEntity entity) =>
            {
                var AIEntity = (AIEntity) entity;
                AIEntity.AddID (entity.creationIndex);
            };

            var systems = new GoapSystems (contexts);

            AI.AddTestActions ();
            GenerateAgents (AI, AGENT_COUNT);

            systems.Initialize ();
            Stopwatch sw = new Stopwatch ();

            while (true)
            {
                sw.Reset ();
                sw.Start ();
                systems.Execute ();
                systems.Cleanup ();
                sw.Stop ();

                Console.WriteLine ("Execution Time: {0}ms", sw.ElapsedMilliseconds);

                foreach (var e in AI.GetEntities ())
                    Console.WriteLine (e);

                Console.Read ();
            }
        }

        private static void GenerateAgents (AIContext Context, int Count)
        {
            var Planner = new GoapPlanner ();

            for (int i = 0; i < Count; i++)
            {
                var WorldState = new GoapState<string, object> () { };
                var Rand = new Random (i);
                var GoalState = new GoapState<string, object> ()
                    {
                        ["HasAction" + Rand.Next (1, 5).ToString ()] = true
                    };

                var Agent = Context.AddAgent (WorldState, GoalState, Planner);
                Agent.isGoapPlanRequest = true;
            }
        }
    }
}