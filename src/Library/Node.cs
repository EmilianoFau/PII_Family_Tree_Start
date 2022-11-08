using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node
    {
        public void AcceptVisit(Visitor visitor)
        {
            visitor.Visit(this);
        }
        public void AcceptOldest(Visitor visitor)
        {
            visitor.VisitOldest(this);
        }
        public void AcceptLongest(Visitor visitor)
        {
            visitor.VisitLongestName(this);
        }
        public Person Persona;

        private List<Node> children = new List<Node>();

        public ReadOnlyCollection<Node> Children { 
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Node(string name, int age)
        {
            this.Persona = new Person(name, age);
        }

        public void AddChildren(Node n)
        {
            this.children.Add(n);
        }
        
    }
}
