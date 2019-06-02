using ReactProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReactProject.Controllers
{
    public class HomeController : Controller
    {
        private static readonly IList<Comment> comments;

        static HomeController()
        {
            comments = new List<Comment>()
            {
                new Comment
                {
                    Id = 1,
                    Author = "Daniel Lo Nigro",
                    Text = "Hello ReactJS.NET World!"
                },
                new Comment
                {
                    Id = 2,
                    Author = "Pete Hunt",
                    Text = "This is one comment"
                },
                new Comment
                {
                    Id = 3,
                    Author = "Jordan Walke",
                    Text = "This is *another* comment"
                }
            };
        }

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddComment(Comment c)
        {
            c.Id = comments.Count + 1;
            comments.Add(c);
            return Content("Success :)");
        }

        public ActionResult Comments()
        {

            return Json(comments, JsonRequestBehavior.AllowGet);
        }
    }
}