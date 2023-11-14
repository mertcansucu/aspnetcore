using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using basics.Models;

namespace basics.Controllers;

//localhost             =>home/index
//localhost/home        => home/index
//localhost/home/index  => home/index

public class HomeController : Controller
{
   /*
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
   */

/* önceki halini kapattım çünkü hazır bir yapı gelior Views içinden onu durdurdum şimdilik
public IActionResult Index()// dotnet watch run bu komutla direk burası çalıştı ve sayfaya gidiş sağlandı
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
*/
    public string Index()// dotnet watch run bu komutla direk burası çalıştı ve sayfaya gidiş sağlandı
    {
        return "home/index";
    }

    public string Contact()
    {
        return "home/contact";
    }

    /*
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
    */
}
