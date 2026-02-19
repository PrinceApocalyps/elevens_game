/*
+------------------------------+
|            Deck              |
+------------------------------+
| - cards : List<Card>         |
| - remaining : int            |
+------------------------------+
| + shuffleDeck()              |
| + dealCard() : Card          |
| + isEmpty() : bool           |
+------------------------------+
*/


using System;
using System.Collections.Generic;
using System.Linq;

public class Deck
{
    private List<Card> cards = new List<Card>();
    public int remaining;

    public Deck()
    {
        foreach (string suit in Card.suits)
        {
            foreach (int value in Card.values)
            {
                cards.Add(new Card(suit, value));
            }
        }

        remaining = cards.Count;
    }

    //summery
    //use fisher-yates shuffling algoritm for a uniform shuffle
    public void shuffleDeck()
{
    Random rand = new Random();

    for (int i = cards.Count - 1; i > 0; i--)
    {
        int j = rand.Next(0, i + 1);

        // swap cards[i] and cards[j]
        Card temp = cards[i];
        cards[i] = cards[j];
        cards[j] = temp;
    }
}


    public string print(int index)
    {
        return cards[index].ToString();
    }
}
