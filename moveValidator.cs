using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;
using Microsoft.VisualBasic;

public class MoveValidator{

    private bool isValidPair(Card a, Card b)
    {
         int sum = a.GetValue() + b.GetValue();
         return sum == 11;
    }

    private bool isValidTriple(IReadOnlyList<Card> selectedCards)
    {
        bool hasJack = false;
        bool hasQueen = false;
        bool hasKing = false;

        foreach (Card card in selectedCards)
        {

        if (card.GetValue() == 11) hasJack = true;
        else if (card.GetValue() == 12) hasQueen = true;
        else if (card.GetValue() == 13) hasKing = true;
                    
        }

        return hasJack && hasQueen && hasKing;
    }
    public bool IsValidSelection(IReadOnlyList<Card> selectedCards)
    {
        //Two cards in the list and they add to 11
        if (selectedCards.Count == 2)
        {
           return isValidPair(selectedCards[0], selectedCards[1]);
        }

        //Three cards that are j, Q, K
        if (selectedCards.Count == 3)
        {
            return isValidTriple(selectedCards);
        }

        return false;
    
    }


    
}

