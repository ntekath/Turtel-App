using Microsoft.AspNetCore.Mvc;

namespace Turtel_App.ServerApp.User.Application
{
    public class UserController : Controller
    {


        [HttpPost("/api/user/createValidateEmailRequest")]
        public IActionResult CreateValidateEmailRequest([FromBody]string email)
        {
            bool ok = false;

            string awaitResponseKey = "";
            if (ok)
            {
                return this.Created($"/api/user/isEvaluatedOrPending/{awaitResponseKey}", new JsonResult(email));
            } else
            {
                return this.BadRequest();
            }
        }
    }
}
