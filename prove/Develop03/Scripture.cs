

class Scripture
{
    private string text;
    private List<Word> words;
    private Reference reference;

    public Scripture(string reference, string text)
    {
        this.reference = new Reference(reference);
        this.text = text;
        this.words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void Display()
    {
        Console.Clear();
        Console.WriteLine(reference);
        Console.WriteLine(string.Join(" ", words));
    }

    public bool AllWordsHidden()
    {
        return words.All(word => word.Hidden);
    }

    public void HideRandomWords(int count)
    {
        Random random = new Random();
        for (int i = 0; i < count; i++)
        {
            int index = random.Next(words.Count);
            if (!words[index].Hidden)
            {
                words[index].Hide();
            }
            else
            {
                i--;
            }
        }
    }
}