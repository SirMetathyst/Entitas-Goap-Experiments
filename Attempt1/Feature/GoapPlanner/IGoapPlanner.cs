using System.Collections.Generic;

public interface IGoapPlanner<K, V>
{
    IEnumerator<int> Plan (AIContext context, IGoapState<K, V> goalState);
}