using Microsoft.AspNetCore.Mvc;
using FirstMVCApp.Models;


namespace FirstMVCApp.Controllers
{
    public class HelloWorldController : Controller

       
    {
        public IActionResult Index()
             
        {
            DogViewModel Doggo = new DogViewModel()
            { Name = "Laika", Age = 15 };
            return View(Doggo);
        }
        public IActionResult Hello()
        {
            return View();
        }

    }
}
