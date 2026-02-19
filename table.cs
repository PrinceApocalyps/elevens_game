/*
+------------------------------+
|            Table             |
+------------------------------+
| - tableCards : List<Card>    |
+------------------------------+
| + addCard(c : Card)          |
| + removeCards(sel : List<Card>)|
| + replaceCards(d : Deck)     |
+------------------------------+
*/

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Table
{
    private List<Card> visible_cards;
    public static int max_Cards= 9;

    //Constructor
    public Table()
    {
        visible_cards = new List<Card>();
    }

    public int count()
    {
        return visible_cards.Count;
    }

    public bool isEmpty()
    {
        return count()==0;
    }

    //summery
    //adds card to the table form the deck
    public void addCard(Card mycard)
    {
        visible_cards.Add(mycard);
    } 

    public void printTable()
    {
        if (isEmpty())
        {
            Console.WriteLine("The table is empty.");
            return;
        }

        Console.WriteLine("Cards on the table:");

        for (int i = 0; i < visible_cards.Count; i++)
        {
            Console.WriteLine($"{i}: {visible_cards[i].ToString()}");
        }
    }


}