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
    public GoapActionComponent goapAction 
    { 
        get 
        { 
            return (GoapActionComponent)GetComponent(AIComponentsLookup.GoapAction); 
        } 
    }

    public bool hasGoapAction 
    { 
        get 
        { 
            return HasComponent(AIComponentsLookup.GoapAction); 
        } 
    }

    public void AddGoapAction(System.Func<GoapActionStatus> newValue) 
    {
        var index = AIComponentsLookup.GoapAction;
        var component = CreateComponent<GoapActionComponent>(index);
		component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceGoapAction(System.Func<GoapActionStatus> newValue)
    {
        var index = AIComponentsLookup.GoapAction;
        var component = CreateComponent<GoapActionComponent>(index);
		component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveGoapAction()
    {
        RemoveComponent(AIComponentsLookup.GoapAction);
    }
}

public sealed partial class AIMatcher
{
    static Entitas.IMatcher<AIEntity> _matcherGoapAction;

    public static Entitas.IMatcher<AIEntity> GoapAction 
    {
        get 
        {
            if (_matcherGoapAction == null) 
            {
                var matcher = (Entitas.Matcher<AIEntity>)Entitas.Matcher<AIEntity>.AllOf(AIComponentsLookup.GoapAction);
                matcher.componentNames = AIComponentsLookup.componentNames;
                _matcherGoapAction = matcher;
            }

            return _matcherGoapAction;
        }
    }
}
