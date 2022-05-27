using CardGame.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace CardGame.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CardController : ControllerBase
    {
        private readonly ICardService _cardService;

        public CardController(ICardService cardService)
        {
            _cardService = cardService;
        }

        [HttpGet]
        public async Task <IActionResult> GetAllCards()
        {
            return new JsonResult( await _cardService.GetCards());
        }

        [HttpPost]
        public async Task<IActionResult> Sort(string[] values)
        {
            var sortedCards = await _cardService.GetCards();
            var result = values.OrderBy(p => Array.IndexOf(sortedCards.ToArray(), p)).ToList();
            return new JsonResult(result);
        }
    }
}
