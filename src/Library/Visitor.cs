using System.Text;
namespace Library;
public abstract class Visitor
{  
    public abstract void Operations(NodeOperations op);
    public abstract void VisitNode(Node node);
    public abstract void VisitPerson(Person person);
}