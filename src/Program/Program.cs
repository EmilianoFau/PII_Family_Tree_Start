using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Node n1 = new Node("Emiliano", 20);
            Node n2 = new Node("Joaquín", 20);
            Node n3 = new Node("Catalina", 18);
            Node n4 = new Node("Luciano", 23);
            Node n5 = new Node("Lucía", 32);
            Node n6 = new Node("Lola", 5);
            Node n7 = new Node("Pepito", 13);
            Node n8 = new Node("Mauricio", 27);

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);
            n3.AddChildren(n8);

            // visitar el árbol aquí
            NodeVisitor visitAge = new NodeVisitor();
            NodeVisitor visitOldest = new NodeVisitor();
            NodeVisitor visitLongest = new NodeVisitor();

            n1.AcceptVisit(visitAge);
            n1.AcceptOldest(visitOldest);
            n1.AcceptLongest(visitLongest);

            Console.WriteLine($"La suma de todas las edades es: {visitAge.TotalAge}");
            Console.WriteLine($"El hijo mayor es {visitOldest.Oldest.Name}, y tiene {visitOldest.Oldest.Age} años");
            Console.WriteLine($"El nombre más largo es: {visitLongest.Longest.Name}");
        }
    }
}
