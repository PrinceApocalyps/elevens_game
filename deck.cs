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
}
