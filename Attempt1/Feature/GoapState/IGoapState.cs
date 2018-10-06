using System.Collections.Generic;

public interface IGoapState<K, V> : IDictionary<K, V>
{
    bool Contains (IGoapState<K, V> b);
}