using System.Text;

public partial class GoapNodeChildrenComponent
{
    static StringBuilder b = new StringBuilder ();

    public override string ToString ()
    {
        b.Clear ();
        b.Append ("GoapNodeChildren[");

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