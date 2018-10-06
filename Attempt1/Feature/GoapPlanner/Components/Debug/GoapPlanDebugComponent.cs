using System.Text;

#if DEBUG

public partial class GoapPlanDebugComponent
{
    static StringBuilder b = new StringBuilder ();

    public override string ToString ()
    {
        b.Clear ();
        b.Append ("GoapPlanDebug[");

        foreach (var i in value)
        {
            b.Append ("{");
            b.Append (i);
            b.Append ("}");
        }

        b.Append ("]");
        return b.ToString ();
    }
}

#endif