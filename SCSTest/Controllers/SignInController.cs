
namespace SCSTest.Controllers;
using Microsoft.AspNetCore.Mvc;
using SCSTest.Models;

[Route("in")]
public class SignInController : Controller
{
    [HttpGet]
    [Route("sign")]
    public IActionResult Sign()
    {
        return View();
    }

    [HttpPost]
    [Route("sign")]
    public IActionResult Sign(string login, string password)
    {
        using var db = new UserContext();
        User u = new User(login, password);
        db.Add(u);
        db.SaveChanges();

        return Ok();
    }
}