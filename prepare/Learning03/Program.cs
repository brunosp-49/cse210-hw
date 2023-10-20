using System;

class Person
{
    private int _age;
    private string _firstName;
    private string _lastName;

    public string GetFirstName()
    {
        return _firstName;
    }

    public void SetFirstName(string firstName)
    {
        _firstName = firstName;
    }

    public string GetLastName()
    {
        return _lastName;
    }

    public void SetLastName(string lastName)
    {
        _lastName = lastName;
    }

    public int GetAge()
    {
        return _age;
    }

    public void SetAge(int age)
    {
        _age = age;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person p1 = new Person();
        p1.SetFirstName("Bruno");
        p1.SetLastName("de Paulo");
        p1.SetAge(26);

        Person p2 = new Person();
        p2.SetFirstName("Oriana");
        p2.SetLastName("Carmona");
        p2.SetAge(23);
        Console.WriteLine($"Hello, {p1.GetFirstName()} {p1.GetLastName()} are getting marriage with {p2.GetFirstName()} {p2.GetLastName()}, his age is {p1.GetAge()} and hers {p2.GetAge()} ");
    }
}