class Player
{
    public string Name {get;set;}
    public List<Card> Hand = new List<Card>();

    public Player(string name)
    {
        Name = name;
    }

    public Card Draw(Deck deck)
    {
        Card dealedCard = deck.Deal();
        Hand.Add(dealedCard);
        return dealedCard;
    }

    public Card RemoveCard(int card)
    {
        if (card < Hand.Count)
        {
            Card trashCard = Hand[card];
            Hand.RemoveAt(card);
            return trashCard;
        }
        return null!;
    }
}