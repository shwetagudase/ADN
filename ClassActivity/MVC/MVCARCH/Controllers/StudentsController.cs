using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures.Buffers;

public class StudentsController : Controller{
    public IActionResult Index()
    {
        return View();
    }
}