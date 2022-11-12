using System;
using System.Collections.Generic;
namespace Library;

public class LargestVisitor
{
    public void Operations(PersonOperations op)
    {
        op.Accept(this);
    }
    public void VisitPerson(Person person)
    {
        string largest = person.Largest();
        Console.WriteLine($"El nombre más largo es: {largest}");
    }
}