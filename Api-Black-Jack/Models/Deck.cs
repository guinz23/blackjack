using System;
namespace Api_Black_Jack.Models
{
    public class Deck
    {
        public Deck()
        {

        }
        public Guid id { get; set; }
        public int numbercard { get; set; }
        public string[] Card { get; set; }
        public bool success { get; set; }
        public int remaining { get; set; }
    }
}
