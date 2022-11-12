using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Node n1 = new Node(1);
            Node n2 = new Node(2);
            Node n3 = new Node(3);
            Node n4 = new Node(4);
            Node n5 = new Node(5);
            Node n6 = new Node(6);
            Node n7 = new Node(7);

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);

            // visitar el árbol aquí
            Person p1 = new Person("Mauricio", 22);
            Person p2 = new Person ("Pepito", 12);
            Person p3 = new Person("Agustina", 16);
            Person p4 = new Person ("Lucia", 34);     
            Person p5 = new Person ("Lucas", 11);            
            Person p6 = new Person ("Emiliano", 19);
            Person p7 = new Person("Sofia", 20);
            Person p8 = new Person ("Catalina", 21);

            p1.AddChildren(p2);
            p1.AddChildren(p3);

            p4.AddChildren(p5);
            p4.AddChildren(p6);

            p7.AddChildren(p8);

            TotalAgeVisitor ageVisitor = new TotalAgeVisitor();
            LargestVisitor largestVisitor = new LargestVisitor();
            OldestVisitor oldestVisitor = new OldestVisitor();

            Console.WriteLine("Total de edades:");
            ageVisitor.Operations(p7);

            Console.WriteLine("Personas:");
            ageVisitor.Operations(p4);
            largestVisitor.Operations(p4);
            oldestVisitor.Operations(p4);

            Console.WriteLine("Nodos:");
            ageVisitor.Operations(n3);
            oldestVisitor.Operations(n3);

        }
    }
}
