using HotelProject.WebUI.Models.Mail;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using MailKit.Net.Smtp;

namespace HotelProject.WebUI.Controllers
{
    public class AdminMailController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(AdminMailViewModel model)
        {
            MimeMessage mimeMessage = new MimeMessage();
            MailboxAddress mailboxAddressfrom = new MailboxAddress("HotelierAdmin", "kayamelihcan67@gmail.com");
            mimeMessage.From.Add(mailboxAddressfrom);
            MailboxAddress mailboxAddressTo = new MailboxAddress("User", model.ReceiverMail);
            mimeMessage.To.Add(mailboxAddressTo);
            var bodybuilder = new BodyBuilder();
            bodybuilder.TextBody = model.Body;
            mimeMessage.Body = bodybuilder.ToMessageBody();
            mimeMessage.Subject = model.Subject;
            SmtpClient client = new SmtpClient();
            client.Connect("smtp.gmail.com", 587, false);
            client.Authenticate("kayamelihcan67@gmail.com", "rpmx yimm dsmg spxl");
            client.Send(mimeMessage);
            client.Disconnect(true);
            return View();
        }
    }
}
