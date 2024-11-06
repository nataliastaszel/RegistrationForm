using Microsoft.AspNetCore.Mvc;
using RegistrationForm.Models;

namespace RegistrationForm.Controllers;

public class RegistrationController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Register()
    {
        return View(new RegistrationData());
    }

    [HttpPost]
    public IActionResult Register(RegistrationData registrationData)
    {
        if (ModelState.IsValid)
        {
            ViewBag.message = "Rejestracja zakończona pomyślnie";
            return View("Profile", registrationData);
        }
        return View();
    }

    public IActionResult Profile(RegistrationData registrationData)
    {
        return View();
    }
}