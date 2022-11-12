using System.Threading;
using System.Text;
using System;
namespace Library;

public class TotalAgeVisitor : Visitor
{    
    public override void Operations(NodeOperations op)
    {
        op.Accept(this);
    }
    public override void VisitPerson(Person person)
    {
        int total = person.TotalAge();
        Console.WriteLine($"La suma total de edades es {total}");
    }

    public override void VisitNode(Node node)
    {
        int total = node.TotalAge();
        Console.WriteLine($"La suma total de edades es {total}");
    }
}