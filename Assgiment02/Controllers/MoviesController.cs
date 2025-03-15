using System.Xml.Linq;
using Assgiment02.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assgiment02.Controllers
{
    public class MoviesController : Controller
    {
        public string Index()
        {
            return " Hello from Index Axtion";
        }

        // route path ==> /BaseUrl/ControlerName / ActionName

        //  / BaseUrl/Movie/GetMovie/10

        #region Example1
        //public ContentResult GetMovie(int? id, string name)
        //{
        //    ContentResult result = new ContentResult();

        //    result.Content = $"Name is {name} and id = {id}";
        //    result.ContentType = "text/html";

        //    return result;

        //} 
        #endregion
        #region Example2
        //public  IActionResult GetMovie(int? id, string name)
        //{
        //    if (id == 0)
        //        return BadRequest();
        //    else if (id < 10)
        //        return NotFound();
        //    else
        //        return Content($"Name is {name} and id = {id}");

        //}
        #endregion


        public IActionResult TestRedirectAction()
        {
            return Redirect("https://eqraatech.com/");
        }

        #region Model Binding


        [HttpPost]
        public IActionResult TestModelBinding(int id ,string name) {
            return Content($"Name is {name} and id = {id}");
        }

        [HttpPost]
        public IActionResult AddMovie([FromBody] Movie movie)
        {
            if (movie is null)
                return BadRequest();
            else
                return Content($"Movie title is {movie.Title} and its Id = {movie.Id}");

        }

        #endregion
    }
}
