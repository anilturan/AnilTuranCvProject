using AnilTuran.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace AnilTuran.Controllers
{
    public class HomeController : Controller
    {
        BlogDbContext db = new BlogDbContext();

        public object LoginHelper { get; private set; }

        public ActionResult Anasayfa(UserInformation model)
        {
            model = db.UserInformations.FirstOrDefault();
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpPost]
        //public ActionResult MailPost(string name, string email, string message)
        //{

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            var body = new StringBuilder();
        //            body.AppendLine("İsim: " + name);
        //            body.AppendLine("Gönderen " + email);
        //            body.AppendLine("Mesaj: " + message);

        //            EmailHelper.MailSender(body.ToString(), name);

        //        }
        //        catch (Exception ex)
        //        {
        //            ViewData.ModelState.AddModelError("_HATA", ex.Message);
        //        }

        //    }
        //    return RedirectToAction("Index");
        //}
        public ActionResult MailPost(string name, string email, string message)
        {

            GmailService.GmailUsername = "teamd.iletisim@gmail.com";
            GmailService.GmailPassword = "TeamD12345";
            GmailService mailer = new GmailService();
            mailer.ToEmail = "teamd.iletisim@gmail.com";
            mailer.Subject = name;
            mailer.Body = "Gönderen: " + email + " \n\n İçerik: \n " + message;
            mailer.IsHtml = false;
            mailer.Send();
            return RedirectToAction("Anasayfa");
        }
    }
}