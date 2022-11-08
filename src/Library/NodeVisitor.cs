using System.Threading;
using System.Text;
namespace Library;

public class NodeVisitor : Visitor
{    
    public int TotalAge = 0;
    public Person Oldest;
    public Person Longest;
    public override void Visit(Node node)
    {
        foreach (Node nodo in node.Children)
        {
            TotalAge += nodo.Persona.Age;
            nodo.AcceptVisit(this);
        }
    }

    public override void VisitOldest(Node node)
    {
        foreach (Node nodo in node.Children)
        {
            if (nodo.Persona.Age > this.Oldest.Age)
            {
                this.Oldest = nodo.Persona;
            }
            nodo.AcceptOldest(this);
        }
    }

    public override void VisitLongestName(Node node)
    {
        foreach (Node nodo in node.Children)
        {
            if (nodo.Persona.Name.Length > this.Longest.Name.Length)
            {
                this.Longest = nodo.Persona;
            }
            nodo.AcceptLongest(this);
        }
    }
}