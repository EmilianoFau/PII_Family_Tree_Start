using System;
using System.Collections.Generic;
namespace Library;

public class OldestVisitor : Visitor
{
    public override void Operations(NodeOperations op)
    {
        op.Accept(this);
    }
    public override void VisitPerson(Person person)
    {
        string oldest = person.Oldest();
        Console.WriteLine($"El mayor es {oldest}");
    }

    public override void VisitNode(Node node)
    {
        int oldest = node.Oldest();
        Console.WriteLine($"El mayor tiene {oldest} años");
    }
}