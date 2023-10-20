

class Reference
{
    public string Verse { get; private set; }

    public Reference(string verse)
    {
        Verse = verse;
    }

    public override string ToString()
    {
        return Verse;
    }
}