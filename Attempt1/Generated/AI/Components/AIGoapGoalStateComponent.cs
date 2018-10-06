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
    public GoapGoalStateComponent goapGoalState 
    { 
        get 
        { 
            return (GoapGoalStateComponent)GetComponent(AIComponentsLookup.GoapGoalState); 
        } 
    }

    public bool hasGoapGoalState 
    { 
        get 
        { 
            return HasComponent(AIComponentsLookup.GoapGoalState); 
        } 
    }

    public void AddGoapGoalState(IGoapState<string, object> newValue) 
    {
        var index = AIComponentsLookup.GoapGoalState;
        var component = CreateComponent<GoapGoalStateComponent>(index);
		component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceGoapGoalState(IGoapState<string, object> newValue)
    {
        var index = AIComponentsLookup.GoapGoalState;
        var component = CreateComponent<GoapGoalStateComponent>(index);
		component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveGoapGoalState()
    {
        RemoveComponent(AIComponentsLookup.GoapGoalState);
    }
}

public sealed partial class AIMatcher
{
    static Entitas.IMatcher<AIEntity> _matcherGoapGoalState;

    public static Entitas.IMatcher<AIEntity> GoapGoalState 
    {
        get 
        {
            if (_matcherGoapGoalState == null) 
            {
                var matcher = (Entitas.Matcher<AIEntity>)Entitas.Matcher<AIEntity>.AllOf(AIComponentsLookup.GoapGoalState);
                matcher.componentNames = AIComponentsLookup.componentNames;
                _matcherGoapGoalState = matcher;
            }

            return _matcherGoapGoalState;
        }
    }
}