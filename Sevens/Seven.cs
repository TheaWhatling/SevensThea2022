﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Sevens
{
    class Seven
    {
        public Table table;
        public Deck deck; 

        public Seven()
        {
            table = new Table();
            deck = new Deck(); 
        }

        public Table tab
        {
            get
            {
                return table;
            }
        }

        public void layCard(int x)
        {
            table.Update(new Card(x/13, x % 13));
        }


        public void shuffle()
        {
            deck.Shuffle(); 
        }

      
        public void deal()
        { 

        }
    }
}
