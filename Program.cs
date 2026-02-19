using System.ComponentModel.DataAnnotations.Schema;

Deck myDeck = new Deck();
Console.WriteLine(myDeck.remaining);

myDeck.shuffleDeck();
Console.WriteLine(myDeck.print(0));

Table game_table = new Table();
for (int i = 0; i<Table.max_Cards; i++)
{
    game_table.addCard(myDeck.deal_card());    
}

game_table.printTable();
