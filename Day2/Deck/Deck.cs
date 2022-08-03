class Deck
{
    public List<Card> cards = new List<Card>();
    
    public List<Card> New()
    {
        cards.Clear();
        string[] suits = {
            "Clubs",
            "Spades",
            "Diamonds",
            "Hearts"
        };
        foreach (string suit in suits)
        {
            for (int i = 1; i <= 13; i++)
            {
                cards.Add(new Card(i, suit));
            }
        }
        return cards;
    }

    public Deck()
    {
        New();
    }

    public Card Deal()
    {
        Card dealedCard = cards[0];
        cards.RemoveAt(0);
        return dealedCard;
    }

    public void ShuffleDeck()
    {   
        List<Card> newDeck = this.cards;
        List<Card> shuffled = new List<Card>();
        Random random = new Random();
        for (int i = 0; i < shuffled.Count; i++)
        {
            int randomIndex = random.Next(shuffled.Count);
            shuffled.Add(newDeck[randomIndex]);
            newDeck.RemoveAt(randomIndex);
        }
        this.cards = shuffled;
    }

}