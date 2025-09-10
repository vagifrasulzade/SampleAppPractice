using Microsoft.AspNetCore.Mvc;
using SampleAppPractice.Models;

namespace SampleAppPractice.Controllers;

public class HomeController : Controller
{
    // Messenger class-ı MessageFactory və SmtpClient class-larından asılıdır,
    // eyni zamanda SmtpClient class-ı SmtpSettings class-ından asılıdır

    // Bu kodun bir neçə problemi var:
    // 1) Single Responsibility prinsiplərinə riayət etmir -
    // bu kod həm Messenger-in yaradılması, həm də onun istifadəsi ilə məşğuldur.
    // 2) Biznes məsələlərini həll etməyən çox sayda kod var, yalnız kodun son iki sətiri faydalıdır.
    // 3) Messenger class-ını refaktoring edərkən, bu class-ı istifadə edən
    // bütün kod sahələrində dəyişikliklər etmək lazım olacaq.

    // Tapşırıq: DI (Dependency Injection) prinsipi ilə asılılıqları elə bir şəkildə qurmaq lazımdır ki,
    // asılılıqlar class tərəfindən istifadə edilmədən əvvəl xaricdə yaradılacaq.
    // DI container - asılılıqları yaratmaq və onları konstruktor vasitəsilə class-a ötürmək üçün məsul olan komponentdir.
    private readonly IMessanger _messanger;
    public HomeController(IMessanger messanger)
    {
        _messanger = messanger;
    }
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(string message)
    {
        _messanger.SendMessage(message, "admin@example.com");
        return View();
    }
}
