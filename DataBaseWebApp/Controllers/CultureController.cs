using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;

namespace DataBaseWebApp.Controllers;

[Route("[controller]/[action]")]

public class CultureController : Controller
{
    public IActionResult Set(string? culture, string redirectUri)
    {
        if (culture != null)
        {
            var requestCulture = new RequestCulture(culture, culture);
            var cookieName = CookieRequestCultureProvider.DefaultCookieName;
            var cookieValue = CookieRequestCultureProvider.MakeCookieValue(requestCulture);
            var cookieOption = new CookieOptions { IsEssential = true };
            HttpContext.Response.Cookies.Append(cookieName, cookieValue, cookieOption);
        }

        return LocalRedirect(redirectUri);
    }
}
