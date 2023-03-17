using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.ViewComponents
{
    public class PersonellerViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Personel> datas = new List<Personel>{
        new Personel{ Id = 1 , Name = "Ad 1" , LastName = "Sagol1"},
        new Personel{ Id = 2 , Name = "Ad 2" , LastName = "Sagol2"},
        new Personel{ Id = 3 , Name = "Ad 3" , LastName = "Sagol3"},
        new Personel{ Id = 4 , Name = "Ad 4" , LastName = "Sagol4"},
        new Personel{ Id = 5 , Name = "Ad 5" , LastName = "Sagol5"},
    };

            var viewResult = View(viewName: "Default", model: datas);
            return await Task.FromResult<IViewComponentResult>(viewResult);
        }

    }
}