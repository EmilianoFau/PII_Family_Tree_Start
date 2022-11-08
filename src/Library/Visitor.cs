using System.Text;
namespace Library;
public abstract class Visitor
{  
    public abstract void Visit(Node node);
    public abstract void VisitLongestName(Node node);
    public abstract void VisitOldest(Node node);
}