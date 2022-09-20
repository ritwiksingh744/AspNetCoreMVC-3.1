using Microsoft.AspNetCore.Mvc;

namespace Asp.NetCore.BookStore.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Hello form controller"; 
        }
    }
}
