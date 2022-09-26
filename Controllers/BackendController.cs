using Microsoft.AspNetCore.Mvc;

namespace NetcoreKerryInventory.Controllers;
public class BackendController : Controller
{
    public IActionResult Dashboard()
    {
        return View();
    }

    public IActionResult Product()
    {
        return View();
    }

}
