using System.Globalization;
using System.Collections.ObjectModel;
using System;
using System.Collections.Generic;
namespace Library;

public class Person : PersonOperations
{
    private int Age {get; set;}
    private string Name {get; set;}
    private List<Person> Children = new List<Person>();

    /*Getters*/
    public ReadOnlyCollection<Person> GetChildren 
    {
        get
        {
            return this.Children.AsReadOnly();
        }
    }
    public string GetName
    {
        get
        {
            return this.Name;
        }
    }

    public int GetAge
    {
        get
        {
            return this.Age;
        }
    }

    /*Constructor*/
    public Person(string name, int age)
    {
        this.Age = age;
        this.Name = name;
    }

    public void AddChildren(Person person)
    {
        this.Children.Add(person);
    }

    /*Calcular edades*/
    public int TotalAge()
    {
        int total = Age;
        foreach (Person person in Children)
        {
            total += person.Age;
        }
        return total;
    }

    /*Mayor*/
    public string Oldest()
    {
        int oldest = 0;
        string name = null;
        foreach (Person person in Children)
        {
            if (person.Age > oldest)
            {
                oldest = person.Age;
                name = person.Name;
            }
        }
        return name;
    }

    /*Nombre más largo*/
    public string Largest()
    {
        int largest = Name.Length;
        string largestName = Name;
        foreach (Person person in Children)
        {
            if (person.Name.Length > largest)
            {
                largest = person.Name.Length;
                largestName = person.Name;
            }
        }
        return largestName;
    }

    /*Visitors*/
    public void Accept (TotalAgeVisitor visitor)
    {
        visitor.VisitPerson(this);
    }
    public void Accept (OldestVisitor visitor)
    {
        visitor.VisitPerson(this);
    }
    public void Accept (LargestVisitor visitor)
    {
        visitor.VisitPerson(this);
    }
}