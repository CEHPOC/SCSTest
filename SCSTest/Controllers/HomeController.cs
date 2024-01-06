using SCSTest.Models;
using Microsoft.AspNetCore.Mvc;

namespace CatPhotoApi.Controllers;

[Route("home")]
public class HomeController : Controller
{
    [HttpGet]
    [Route("index")]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    [Route("index")]
    public IActionResult Index(User user)
    {
        using var db = new UserContext();
        db.Add(user);
        db.SaveChanges();

        return Ok();
    }
}