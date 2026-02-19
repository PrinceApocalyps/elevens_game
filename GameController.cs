using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
public class GameController
{
    private Deck _deck;
    private Table _table;
    private MoveValidator _validator;

    public Deck game_deck => _deck;
    public Table game_table => _table;

    public GameController()
    {
        _deck = new Deck();
        _table = new Table();
    }



}