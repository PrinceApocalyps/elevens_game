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
using System.ComponentModel.DataAnnotations;
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

    //summery
    //If no cards in deck return true
    public bool isEmpty()
    {
        return remaining == 0;
    }


    //summery
    //deal the top card of the deck if any cards remaining
    public Card? deal_card()
    {
        //check if any cards in deck
        if (isEmpty()) return null;

        //deal one card
        Card top = cards[remaining - 1];
        remaining --;
        return top;
    }


    //print the suit and value of the card at index
    public string print(int index)
    {
        return cards[index].ToString();
    }

    
}
