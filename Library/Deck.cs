using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Deck
    {
        // --------------------------------------------------------------------
        // Fields
        // --------------------------------------------------------------------
        private Random generator;
        //private Card[] cardCollection;        // Comment out! Don't delete!
        private List<Card> cardCollection;


        public Deck()
        {
            // Initialize fields of the class
            generator = new Random();
            //cardCollection = new Card[52];        // Switching from array...
            cardCollection = new List<Card>();      // ... to a List

            // Insert Cards into the Deck

            int value = 2;
            string suit = "Hearts";
            int i = 4;

            Card newCard = new Card(value, suit);
            //cardCollection[i] = newCard;          // Switching from array...
            cardCollection.Add(newCard);            // ... to a List

            //cardCollection[i] = new Card(value, suit);      // Switching from array...
            cardCollection.Add(new Card(i, suit));            // ... to a List



        }
    }
}
