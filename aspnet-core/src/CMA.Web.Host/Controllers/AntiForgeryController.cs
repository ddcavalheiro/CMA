using Microsoft.AspNetCore.Antiforgery;
using CMA.Controllers;

namespace CMA.Web.Host.Controllers
{
    public class AntiForgeryController : CMAControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
