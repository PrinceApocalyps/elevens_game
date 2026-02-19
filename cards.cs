/*
+------------------+
|       Card       |
+------------------+
| - value : int    |
| - suit  : string |
+------------------+
| + getValue()     |
| + getSuit()      |
| + toString()     |
+------------------+
*/

using System;

public class Card
{
    private string suit;
    private int value;

    public static string[] suits = { "Clubs", "Hearts", "Diamonds", "Spades" };
    public static int[] values = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
    public Card(string suit, int value)
    {
        this.suit = suit;
        this.value = value;
    }


    public int GetValue()
    {
        return value;
    }

    public string GetFaceName()
{
    switch (value)
    {
        case 1:
            return "Ace";
        case 11:
            return "Jack";
        case 12:
            return "Queen";
        case 13:
            return "King";
        default:
            return value.ToString();
    }
}


    //summery
    //Returns the value of the called card as string
    public override string ToString()
    {
        return $"{GetFaceName()} of {suit}";
    }
}
