using System.Collections.Generic;
using System.Threading.Tasks;

namespace CardGame.Services
{
    public class CardService : ICardService
    {
        public async Task<List<string>> GetCards()
        {
            var specialCards = new List<string>() { "4T", "2T", "ST", "PT", "RT" };
            var cardNames = new List<string>() { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            var cardGroups = new List<string>() { "D", "S", "C", "H" };
            var list = new List<string>();
            list.AddRange(specialCards);
            foreach (var group in cardGroups)
            {
                foreach (var name in cardNames)
                {
                    list.Add($"{name}{group}");
                }
            }
            return list;
        }
    }
}
