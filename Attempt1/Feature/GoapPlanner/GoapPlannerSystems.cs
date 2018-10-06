using System.Collections.Generic;

public class GoapPlannerSystems : CompositeSystem
{
    public GoapPlannerSystems (Contexts contexts) : base (contexts)
    {
        var AIContext = contexts.aI;

        /* INITIALIZE GRAPH. */
        AddInitialize (() =>
        {
            AIContext.BuildGraph ();
        });

        /* CREATE PLAN. */
        AddReactEach (AIMatcher.GoapPlanRequest, (e) => e.isGoapAgent && e.hasGoapPlanner && e.hasGoapWorldState && e.hasGoapGoalState && !e.hasGoapPlan, (e) =>
        {
            e.isGoapPlanRequest = false;
            var enumerator = e.goapPlanner.value.Plan (AIContext, e.goapGoalState.value);
            if (enumerator != null)
            {

#if DEBUG
                var list = (e.hasGoapPlanDebug) ? e.goapPlanDebug.value : new List<int> ();
                list.Clear ();
                while (enumerator.MoveNext ())
                list.Add (enumerator.Current);
                enumerator.Reset ();
                e.ReplaceGoapPlanDebug (list);
#endif

                enumerator.MoveNext ();
                e.AddGoapPlan (enumerator);
            }
        });

        var goapAgentWithPlan = contexts.aI.GetGroup (AIMatcher.AllOf (AIMatcher.GoapAgent, AIMatcher.GoapPlan));

        /* RUN PLAN. */
        AddExecute (() =>
        {
            foreach (var e in goapAgentWithPlan.GetEntities ())
            {
                var ID = e.goapPlan.value.Current;
                var AIEntity = AIContext.GetEntityWithID (ID);
                var actionState = AIEntity.goapAction.value ();
                if (actionState == GoapActionStatus.Active)
                {
                    continue;
                }
                else if (actionState == GoapActionStatus.Fail)
                {
                    e.RemoveGoapPlan ();
                    e.isGoapPlanRequest = true;
                    continue;
                }

                if (!e.goapPlan.value.MoveNext ())
                {
                    e.RemoveGoapPlan ();
                    e.isGoapPlanRequest = true;
                    continue;
                }
            }
        });
    }
}