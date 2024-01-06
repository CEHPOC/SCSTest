using Microsoft.EntityFrameworkCore;

namespace SCSTest.Controllers;
using Microsoft.AspNetCore.Mvc;
using SCSTest.Models;


[Route("up")]
public class SignUpController : Controller
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
        string sql = "SELECT * FROM Users WHERE Login = '" + login + "' AND Password = '" + password + "'";
        var users = db.Users.FromSqlRaw(sql).ToList();

        ViewBag.people = users;

        //ViewBag.message1 = "SELECT * FROM Users WHERE Login = " + login + " AND Password = " + password;
        //ViewBag.message2 = ($"SELECT * FROM Users WHERE Login = {login} AND Password = {password}");
        return View("Sign1");
    }
}