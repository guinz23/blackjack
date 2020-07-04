using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Api_Black_Jack.Controllers
{
    [Route("api/[controller]")]
    public class MainDeck : Controller
    {
        // GET: api/values
        [HttpGet]
        public Deck Get()
        {
            var deck = new Deck();
            deck.id = Guid.NewGuid();
            deck.numbercard = 52;
            Card c = new Card();
            c.code = "KH";
            c.suit = "suit";
            c.image = "image";
            c.value = "KING";
            deck.Card=arrayCard();
            deck.remaining = 51;
            deck.success = true;
            return deck;
        }
        public string [] arrayCard()
        {
            string[] deckTemp = new string[52];
            deckTemp[0] = "https://www.pikpng.com/pngl/m/297-2971473_as-de-corazones-png-carta-1-de-corazones.png";
            deckTemp[1] = "https://e7.pngegg.com/pngimages/195/458/png-clipart-blackjack-playing-card-spades-suit-deck-of-cards-king-hearts.png";
            deckTemp[2] = "https://www.pikpng.com/pngl/m/297-2971473_as-de-corazones-png-carta-1-de-corazones.png";
            deckTemp[3] = "https://www.pikpng.com/pngl/m/297-2971473_as-de-corazones-png-carta-1-de-corazones.png";
            deckTemp[4] = "https://www.pikpng.com/pngl/m/297-2971473_as-de-corazones-png-carta-1-de-corazones.png";
            deckTemp[5] = "https://www.pikpng.com/pngl/m/297-2971473_as-de-corazones-png-carta-1-de-corazones.png";
            deckTemp[6] = "https://www.pikpng.com/pngl/m/297-2971473_as-de-corazones-png-carta-1-de-corazones.png";
            deckTemp[7] = "https://www.pikpng.com/pngl/m/297-2971473_as-de-corazones-png-carta-1-de-corazones.png";
            deckTemp[8] = "https://www.pikpng.com/pngl/m/297-2971473_as-de-corazones-png-carta-1-de-corazones.png";
            deckTemp[9] = "https://www.pikpng.com/pngl/m/297-2971473_as-de-corazones-png-carta-1-de-corazones.png";
            return  deckTemp;
        }

        [HttpGet("{id}")]
        public Deck GetById(string id)
        {
            if(id=="IG789L")
            {
                var deck = new Deck();
                deck.id =Guid.Parse("IG789L");
                deck.Card = findcards();
                deck.remaining = 50;
                deck.success = true;
                return deck;
            }
            return new Deck();
           
        }

        public string [] findcards()
        {
            string[] cards = new string[2];
              for(var index = 0; index < arrayCard().Length; index++)
            {
                cards[0] = arrayCard()[0];
                cards[1] = arrayCard()[1];
            }
            return cards;
        }
    }
   public class Deck {

        public Deck()
        {
        }
        public Guid id { get; set; }
        public int numbercard { get; set; }
        public string [] Card{ get;set;}
        public bool success { get; set; }
        public int remaining { get; set; }
    }

   public class Card
    {
        public string image { get; set; }
        public string value { get; set; }
        public string suit { get; set;}
        public string code { get; set; }
    }
}
