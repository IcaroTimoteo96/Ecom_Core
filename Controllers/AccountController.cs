using Api.Rest.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api.Rest.Controllers
{
    [ApiController]
    public class AccountController : Controller
    {
        [HttpPost]
        [Route("/CreateAccount")]
        public IActionResult CreateAccount(Account account)
        {
            if(account.Address == null) {
                return BadRequest(account);
            }
            var accountResult = new { Message = "Account created!" };

            return Ok(accountResult);
        }
    }
}
