using Microsoft.AspNetCore.Mvc;
using Resume.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace Resume.Controllers
{
    public class HomeController : Controller
    {
        ApplicationContext db;
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AboutMe()
        {
            return View();
        }
        public IActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        public IActionResult GetDataFromField(string Name, string Adress, string Email, string Organization, string NumberPhone)
        {
            db = new ApplicationContext();            
            db.Applications.Add(new Application()
            { 
                    Name = Name,
                    Adress = Adress,
                    Email = Email,
                    Organization = Organization,
                    NumberPhone = NumberPhone,
                    Time = DateTime.Now
            });
            db.SaveChanges();
            List<Application> applications = db.Applications.ToList();
            var item = applications.LastOrDefault();
            string message = $"Bам прислали приглашения в компанию: {item.Organization} от {item.Name}\nРасположенное по адресу: {item.Adress}." +
                $"\nДанные отправителя: Номер телефона {item.NumberPhone}.\nEmail отправителя: {item.Email}.\nДата оставление заявки: {item.Time}";
            TelegramSendMessage.SendMessage(000000000, message); // sevret id


            return Redirect("~/Home/EndRegistration");
        }
        public IActionResult EndRegistration()
        {
            return View();
        }
    }
}
