//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Electron:ContextGenerator_C_1_4_2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

public sealed partial class AIContext : Entitas.Context<AIEntity> 
{
    public AIContext()
        : base(
            AIComponentsLookup.TotalComponents,
            0,
            new Entitas.ContextInfo(
                "AI",
                AIComponentsLookup.componentNames,
                AIComponentsLookup.componentTypes
            ),
            (entity) =>
#if (ENTITAS_FAST_AND_UNSAFE)
            new Entitas.UnsafeAERC()
#else
            new Entitas.SafeAERC(entity)
#endif
        ) 
    {
    }
}
