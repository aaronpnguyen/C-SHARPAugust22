class Card
{
    public string name;
    public string suit;
    public int val;

    public Card(int value, string suitParam)
    {
        if (value == 1) name = "Ace";
        else if (value == 11) name = "Jack";
        else if (value == 12) name = "Queen";
        else if (value == 13) name = "King";
        else name = $"{value}";

        suit = suitParam;
        val = value;
    }

    public void ShowCard()
    {
        Console.WriteLine($"{name} of {suit}\nValue: {val}");
    }
}