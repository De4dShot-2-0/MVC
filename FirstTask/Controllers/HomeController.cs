using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstTask.Models;


namespace FirstTask.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(new ArticleService().ShowArticles());
        }
        public ActionResult WatchArticlePage(int id)
        {
            return View(new ArticleService().ShowArticles()[id-1]);
        }
        public ActionResult Guest(string Name, string Text)
        {
            if (Request.HttpMethod == "GET")
            {
                return View(new CommentService().ShowComments());
            }
            else
            {
                new CommentService().AddComment(Name, Text);
                return View(new CommentService().ShowComments());
            }
        }
        public ActionResult Blank()
        {
            return View();
        }
        public ActionResult Result(FormCollection answers)
        {
            return View(Functions.Result(answers));
        }  
    }
}