using Entitas;

/// <summary>
/// GOAP SYSTEM(S).
/// </summary>
public class GoapSystems : Systems
{
    public GoapSystems (Contexts contexts)
    {
        Add (new GoapPlannerSystems (contexts));
    }
}