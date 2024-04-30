using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ActivitySystem.PL.Models;
using ActivitySystem.BLL.Interface;
using ActivitySystem.PL.Resources;
using System.Resources;
using System.Globalization;
using Microsoft.AspNetCore.Localization;

namespace ActivitySystem.PL.Controllers;

public class HomeController : Controller
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IConfiguration _configuration;

    public HomeController(IUnitOfWork uniteOfWork , IConfiguration configuration)
    {
        _unitOfWork = uniteOfWork;
        _configuration = configuration;
    }

    public IActionResult Index()
    {
        ViewBag.CurrentCultureName = CultureInfo.CurrentCulture.Name;
        return View() ;
    }

    [HttpGet("Language/SwitchLanguage")]
    public IActionResult SwitchLanguage(string culture, string returnUrl)
    {
        Response.Cookies.Append(
            CookieRequestCultureProvider.DefaultCookieName,
            CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
            new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1), IsEssential = true , Path="/" }
        );

        return LocalRedirect(returnUrl);
    }

    
    public IActionResult Groups()
    {
        var groups = _unitOfWork.groupsRepository.GetAll();
        return View(groups);
    }
}

    


