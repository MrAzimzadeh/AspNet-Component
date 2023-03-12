using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models;
namespace WebApp.ViewComponents.Message
{
    public class MessageViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            List<Messagess> messages = new List<Messagess>
            {
                new Messagess { Id =1 , messages = "Salam"},
                new Messagess { Id =12 , messages = "Salam2"},
                new Messagess { Id =13 , messages = "Salam3"},
                new Messagess { Id =14 , messages = "Salam4"},
            };
           return View("Messages", messages);

        }
    }
}