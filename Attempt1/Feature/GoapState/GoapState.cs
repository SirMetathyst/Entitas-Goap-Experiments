using System.Collections.Generic;
using System.Linq;
using System.Text;

public class GoapState<K, V> : Dictionary<K, V>, IGoapState<K, V>
{
    public GoapState () { }
    public GoapState (IDictionary<K, V> state) : base (state) { }

    public bool Contains (IGoapState<K, V> b)
    {
        return b.Keys.All (k => ContainsKey (k) && Equals (b[k], this [k]));
    }
}