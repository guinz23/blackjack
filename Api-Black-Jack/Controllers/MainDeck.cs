using System;
using Api_Black_Jack.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api_Black_Jack.Controllers
{
    public class MainDeck : Controller
    {
        // GET: api/values
        [HttpGet]
        [Route("api/deck")]
        public Deck CreateDeck()
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
            deckTemp[0] = "https://deckofcardsapi.com/static/img/8C.png";
            deckTemp[1] = "https://deckofcardsapi.com/static/img/4C.png";
            deckTemp[2] = "https://deckofcardsapi.com/static/img/2S.png";
            deckTemp[3] = "https://deckofcardsapi.com/static/img/0H.png";
            deckTemp[4] = "https://deckofcardsapi.com/static/img/3S.png";//
            deckTemp[5] = "https://deckofcardsapi.com/static/img/AS.png";
            deckTemp[6] = "https://deckofcardsapi.com/static/img/9H.png";
            deckTemp[7] = "https://deckofcardsapi.com/static/img/5C.png";
            deckTemp[8] = "https://deckofcardsapi.com/static/img/KD.png";
            deckTemp[9] = "https://deckofcardsapi.com/static/img/QS.png";
            deckTemp[10] = "https://deckofcardsapi.com/static/img/QC.png";
            deckTemp[11] = "https://deckofcardsapi.com/static/img/3C.png";
            deckTemp[12] = "https://deckofcardsapi.com/static/img/QH.png";
            deckTemp[13] = "https://deckofcardsapi.com/static/img/9D.png";
            deckTemp[14] = "https://deckofcardsapi.com/static/img/QD.png";
            deckTemp[15] = "https://deckofcardsapi.com/static/img/JH.png";
            deckTemp[16] = "https://deckofcardsapi.com/static/img/9C.png";
            deckTemp[17] = "https://deckofcardsapi.com/static/img/4H.png";
            deckTemp[18] = "https://deckofcardsapi.com/static/img/3D.png";
            deckTemp[19] = "https://deckofcardsapi.com/static/img/KS.png";
            deckTemp[20] = "https://deckofcardsapi.com/static/img/5D.png";
            deckTemp[21] = "https://deckofcardsapi.com/static/img/6S.png";
            deckTemp[22] = "https://deckofcardsapi.com/static/img/JD.png";
            deckTemp[23] = "https://deckofcardsapi.com/static/img/7S.png";
            deckTemp[24] = "https://deckofcardsapi.com/static/img/9S.png";
            deckTemp[25] = "https://deckofcardsapi.com/static/img/5S.png";
            deckTemp[26] = "https://deckofcardsapi.com/static/img/7H.png";
            deckTemp[27] = "https://deckofcardsapi.com/static/img/5H.png";
            deckTemp[28] = "https://deckofcardsapi.com/static/img/AH.png";
            deckTemp[29] = "https://deckofcardsapi.com/static/img/6D.png";
            deckTemp[30] = "https://deckofcardsapi.com/static/img/KH.png";
            deckTemp[31] = "https://deckofcardsapi.com/static/img/JS.png";
            deckTemp[32] = "https://deckofcardsapi.com/static/img/6C.png";
            deckTemp[33] = "https://deckofcardsapi.com/static/img/8D.png";
            deckTemp[34] = "https://deckofcardsapi.com/static/img/7C.png";
            deckTemp[35] = "https://deckofcardsapi.com/static/img/2C.png";
            deckTemp[36] = "https://deckofcardsapi.com/static/img/KC.png";
            deckTemp[37] = "https://deckofcardsapi.com/static/img/0C.png";
            deckTemp[38] = "https://deckofcardsapi.com/static/img/AC.png";
            deckTemp[39] = "https://deckofcardsapi.com/static/img/4S.png";
            deckTemp[40] = "https://deckofcardsapi.com/static/img/3H.png";
            deckTemp[41] = "https://deckofcardsapi.com/static/img/JC.png";
            deckTemp[42] = "https://deckofcardsapi.com/static/img/8S.png";
            deckTemp[43] = "https://deckofcardsapi.com/static/img/0S.png";
            deckTemp[44] = "https://deckofcardsapi.com/static/img/4D.png";
            deckTemp[45] = "https://deckofcardsapi.com/static/img/7D.png";
            deckTemp[46] = "https://deckofcardsapi.com/static/img/8H.png";
            deckTemp[47] = "https://deckofcardsapi.com/static/img/aceDiamonds.png";
            deckTemp[48] = "https://deckofcardsapi.com/static/img/0D.png";
            deckTemp[49] = "https://deckofcardsapi.com/static/img/6H.png";
            deckTemp[50] = "https://deckofcardsapi.com/static/img/2D.png";
            deckTemp[51] = "https://deckofcardsapi.com/static/img/AC.png";
            deckTemp[52] = "https://deckofcardsapi.com/static/img/QC.png";
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
}
