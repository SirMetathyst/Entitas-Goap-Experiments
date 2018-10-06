using System.Collections.Generic;

public static partial class ContextExtensions
{
    public static void BuildGraphBranch (this AIContext context, AIEntity currentEntity, IList<AIEntity> entities, IGoapState<string, object> targetEffect)
    {
        foreach (var e in entities)
        {
            if (targetEffect.Contains (e.goapEffect.value))
            {
                if (currentEntity != null)
                {
                    if (!currentEntity.hasGoapNodeChildren)
                        currentEntity.AddGoapNodeChildren (new List<int> ());
                    if (!currentEntity.goapNodeChildren.value.Contains (e.iD.value))
                        currentEntity.goapNodeChildren.value.Add (e.iD.value);
                }
                context.BuildGraphBranch (e, entities, e.goapCondition.value);
            }
        }
    }

    public static void BuildGraph (this AIContext context)
    {
        var goapAction = context.GetGroup (AIMatcher.AllOf (AIMatcher.GoapCondition, AIMatcher.GoapEffect, AIMatcher.GoapAction));
        var entities = goapAction.GetEntities ();

        foreach (var e in entities)
            context.BuildGraphBranch (null, entities, e.goapEffect.value);
    }
}