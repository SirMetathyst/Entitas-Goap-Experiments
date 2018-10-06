//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Electron:ComponentEntityGenerator_C_1_4_2,ComponentMatcherGenerator_C_1_4_2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

public partial class AIEntity
{
    public GoapPlannerComponent goapPlanner 
    { 
        get 
        { 
            return (GoapPlannerComponent)GetComponent(AIComponentsLookup.GoapPlanner); 
        } 
    }

    public bool hasGoapPlanner 
    { 
        get 
        { 
            return HasComponent(AIComponentsLookup.GoapPlanner); 
        } 
    }

    public void AddGoapPlanner(IGoapPlanner<string, object> newValue) 
    {
        var index = AIComponentsLookup.GoapPlanner;
        var component = CreateComponent<GoapPlannerComponent>(index);
		component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceGoapPlanner(IGoapPlanner<string, object> newValue)
    {
        var index = AIComponentsLookup.GoapPlanner;
        var component = CreateComponent<GoapPlannerComponent>(index);
		component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveGoapPlanner()
    {
        RemoveComponent(AIComponentsLookup.GoapPlanner);
    }
}

public sealed partial class AIMatcher
{
    static Entitas.IMatcher<AIEntity> _matcherGoapPlanner;

    public static Entitas.IMatcher<AIEntity> GoapPlanner 
    {
        get 
        {
            if (_matcherGoapPlanner == null) 
            {
                var matcher = (Entitas.Matcher<AIEntity>)Entitas.Matcher<AIEntity>.AllOf(AIComponentsLookup.GoapPlanner);
                matcher.componentNames = AIComponentsLookup.componentNames;
                _matcherGoapPlanner = matcher;
            }

            return _matcherGoapPlanner;
        }
    }
}
