using Microsoft.AspNetCore.Mvc;

namespace PizzaOrderApp.Controllers
{
    /// <summary>
    /// The Controller base class provides the functionality for handling HTTP requests and responses
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// Index action for home page
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Owner login view
        /// </summary>
        /// <returns></returns>
        public IActionResult OwnerLogin()
        {
            return View();
        }

        /// <summary>
        /// Chef login view
        /// </summary>
        /// <returns></returns>
        public IActionResult ChefLogin() 
        {
            return View();        
        }
    }
}
