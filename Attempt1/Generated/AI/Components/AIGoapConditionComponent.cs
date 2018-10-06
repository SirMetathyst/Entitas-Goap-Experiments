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
    public GoapConditionComponent goapCondition 
    { 
        get 
        { 
            return (GoapConditionComponent)GetComponent(AIComponentsLookup.GoapCondition); 
        } 
    }

    public bool hasGoapCondition 
    { 
        get 
        { 
            return HasComponent(AIComponentsLookup.GoapCondition); 
        } 
    }

    public void AddGoapCondition(IGoapState<string, object> newValue) 
    {
        var index = AIComponentsLookup.GoapCondition;
        var component = CreateComponent<GoapConditionComponent>(index);
		component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceGoapCondition(IGoapState<string, object> newValue)
    {
        var index = AIComponentsLookup.GoapCondition;
        var component = CreateComponent<GoapConditionComponent>(index);
		component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveGoapCondition()
    {
        RemoveComponent(AIComponentsLookup.GoapCondition);
    }
}

public sealed partial class AIMatcher
{
    static Entitas.IMatcher<AIEntity> _matcherGoapCondition;

    public static Entitas.IMatcher<AIEntity> GoapCondition 
    {
        get 
        {
            if (_matcherGoapCondition == null) 
            {
                var matcher = (Entitas.Matcher<AIEntity>)Entitas.Matcher<AIEntity>.AllOf(AIComponentsLookup.GoapCondition);
                matcher.componentNames = AIComponentsLookup.componentNames;
                _matcherGoapCondition = matcher;
            }

            return _matcherGoapCondition;
        }
    }
}