public class Person
{
    private string name;
    private int age;

    public void SetName(string newName)
    {
        name = newName;
    }

    public string GetName()
    {
        return name;
    }

    public void SetAge(int newAge)
    {
        if (newAge >= 0)
        {
            age = newAge;
        }
    }

    public int GetAge()
    {
        return age;
    }
}
