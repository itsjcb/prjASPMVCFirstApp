using prjASPMVCFirstApp.Models;
using prjASPMVCFirstApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Web.Mvc;
using System.Web.UI;

namespace prjASPMVCFirstApp.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        //Actions are the methods in controller class
        //which are responsible for returning the view or Json data
        //output
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek" };
            //var viewResult = new ViewResult();
            //viewResult.ViewData.Model
            //dont pass a data to the view like that
            //ViewData["RandomMovie"] = movie;
            //ViewBag.Movie = movie;
            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1"},
                new Customer { Name = "Customer 2"},
                new Customer { Name = "Customer 3"},
                new Customer { Name = "Customer 4"},
                new Customer { Name = "Customer 5"},
                new Customer { Name = "Customer 6"}
            };
            var viewModel = new RandomMovieViewModel()
            {
                Movie = movie,
                Customers = customers
            };
            return View(viewModel);
            //return Content("hello");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
        }
        //attributeRouting
        [Route("movies/released/{year}/{month:regex(\\d{4}):range(1, 12)}")]

        public ActionResult ByReleaseYear(int year, int month)
        {
            return Content(year + "/" + month);
        } 
        /*
        //input
        public ActionResult Edit(int id)
        {
            return Content ( "id=" +id);
        }
        //Called when we navigate through movies
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            //if pageIndex not specified
            if(!pageIndex.HasValue)
                pageIndex = 1;

            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "name";
            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }
        */
    }
}