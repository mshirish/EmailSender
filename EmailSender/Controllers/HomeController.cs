using EmailSender.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EmailSender.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmailSender _emailSender;
    
        public HomeController(IEmailSender emailSender)
        {
            _emailSender = emailSender;
        }

        public async Task<IActionResult> Index()
        {
            var receiver = "manishstha44@gmail.com";
            var subject = "Email testing";
            var message = "Hello World";

            await _emailSender.SendEmailAsync(receiver, subject, message);

            return View();

        }
    }

}
