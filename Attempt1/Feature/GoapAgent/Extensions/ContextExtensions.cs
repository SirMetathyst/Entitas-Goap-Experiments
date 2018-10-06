using System;

public static partial class ContextExtensions
{
    public static AIEntity AddAgent (this AIContext context, IGoapState<string, object> worldState, IGoapState<string, object> goalState, IGoapPlanner<string, object> planner)
    {
        var entity = context.CreateEntity ();
        entity.AddGoapWorldState (worldState);
        entity.AddGoapGoalState (goalState);
        entity.AddGoapPlanner (planner);
        entity.isGoapAgent = true;
        return entity;
    }
}