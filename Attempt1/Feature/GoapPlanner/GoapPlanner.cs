using System.Collections.Generic;
using System.Linq;

public class GoapPlanner : IGoapPlanner<string, object>
{
    List<AIEntity> entityList = new List<AIEntity> ();

    private IList<int> NextAction (AIContext context, AIEntity entity, IList<int> plan)
    {
        plan.Add (entity.iD.value);

        entityList.Clear ();

        if (entity.hasGoapNodeChildren)
        {
            foreach (var childID in entity.goapNodeChildren.value)
            {
                var childEntity = context.GetEntityWithID (childID);
                entityList.Add (childEntity);
            }
        }

        if (entityList.Count > 0)
        {
            var childrenByCost = entityList.OrderBy (x => x.cost.value).ToList ();
            NextAction (context, childrenByCost[0], plan);
        }

        return plan;
    }

    private IList<int> Search (AIContext context, IList<AIEntity> entities, IGoapState<string, object> goalState)
    {
        AIEntity startEntity = null;

        foreach (var currentEntity in entities)
            if (goalState.Contains (currentEntity.goapEffect.value))
                startEntity = currentEntity;

        if (startEntity == null)
            return null;

        return NextAction (context, startEntity, new List<int> ());
    }

    public IEnumerator<int> Plan (AIContext context, IGoapState<string, object> goalState)
    {
        var goapAction = context.GetGroup (AIMatcher.AllOf (AIMatcher.GoapNodeChildren, AIMatcher.GoapEffect, AIMatcher.GoapAction));

        var IDList = Search (context, goapAction.GetEntities (), goalState);
        if (IDList == null || IDList.Count == 0)
            return null;

        var RIDList = IDList.Reverse ().ToList ();

        return RIDList.GetEnumerator ();
    }
}