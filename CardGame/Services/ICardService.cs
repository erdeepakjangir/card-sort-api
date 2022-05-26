using System.Collections.Generic;
using System.Threading.Tasks;

namespace CardGame.Services
{
   public interface ICardService
    {
        Task<List<string>> GetCards();
    }
}
