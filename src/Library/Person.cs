using System;
namespace Library;

public class Person
{
    public int Age {get; set;}
    public string Name {get; set;}
    public Person(string name, int age)
    {
        this.Age = age;
        this.Name = name;
    }
}