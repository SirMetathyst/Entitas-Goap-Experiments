using System.Text;

public partial class GoapWorldStateComponent
{
    static StringBuilder b = new StringBuilder ();

    public override string ToString ()
    {
        b.Clear ();
        b.Append ("GoapWorldState[");

        foreach (var i in this.value)
        {
            b.Append ("{");
            b.Append (i.Key);
            b.Append ("=");
            b.Append (i.Value);
            b.Append ("}");
        }

        b.Append ("]");
        return b.ToString ();
    }
}