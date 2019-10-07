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

    [Route("/#result")]
    public ActionResult Triangle()
    {

    return View();  

    }
    //TriangleVariable newTriangle = new TriangleVariable(sideOne, sideTwo, sideThree);
  }
}