using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node : NodeOperations
    {
        public void Accept(TotalAgeVisitor visitor)
        {
            visitor.VisitNode(this);
        }
        public void Accept(OldestVisitor visitor)
        {
            visitor.VisitNode(this);
        }
        private int Number;
        public int GetNumber
        {
            get
            {
                return this.Number;
            }
        }

        private List<Node> children = new List<Node>();

        public ReadOnlyCollection<Node> Children { 
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Node(int number)
        {
            this.Number = number;
        }

        public void AddChildren(Node n)
        {
            this.children.Add(n);
        }
        
        /*Calcular edades*/
        public int TotalAge()
        {
            int total = Number;
            foreach (Node node in Children)
            {
                total += node.Number;
            }
            return total;
        }

        /*Mayor*/
        public int Oldest()
        {
            int oldest = 0;
            foreach (Node node in Children)
            {
                if (node.Number > oldest)
                {
                    oldest = node.Number;
                }
            }
            return oldest;
        }
    }
}
