using Microsoft.AspNetCore.Mvc;
using Triangle.Models;


namespace Triangle.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Triangle() 
    {   
        return View();        
    }

    [Route("/result")]
    public ActionResult TriangleResult(int sideOne, int sideTwo, int sideThree)
    {
        TriangleVariable newTriangle = new TriangleVariable(sideOne, sideTwo, sideThree);
        return View("Triangle", newTriangle);  
    }
  }
}