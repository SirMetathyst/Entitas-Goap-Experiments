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
    public GoapWorldStateComponent goapWorldState 
    { 
        get 
        { 
            return (GoapWorldStateComponent)GetComponent(AIComponentsLookup.GoapWorldState); 
        } 
    }

    public bool hasGoapWorldState 
    { 
        get 
        { 
            return HasComponent(AIComponentsLookup.GoapWorldState); 
        } 
    }

    public void AddGoapWorldState(IGoapState<string, object> newValue) 
    {
        var index = AIComponentsLookup.GoapWorldState;
        var component = CreateComponent<GoapWorldStateComponent>(index);
		component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceGoapWorldState(IGoapState<string, object> newValue)
    {
        var index = AIComponentsLookup.GoapWorldState;
        var component = CreateComponent<GoapWorldStateComponent>(index);
		component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveGoapWorldState()
    {
        RemoveComponent(AIComponentsLookup.GoapWorldState);
    }
}

public sealed partial class AIMatcher
{
    static Entitas.IMatcher<AIEntity> _matcherGoapWorldState;

    public static Entitas.IMatcher<AIEntity> GoapWorldState 
    {
        get 
        {
            if (_matcherGoapWorldState == null) 
            {
                var matcher = (Entitas.Matcher<AIEntity>)Entitas.Matcher<AIEntity>.AllOf(AIComponentsLookup.GoapWorldState);
                matcher.componentNames = AIComponentsLookup.componentNames;
                _matcherGoapWorldState = matcher;
            }

            return _matcherGoapWorldState;
        }
    }
}
