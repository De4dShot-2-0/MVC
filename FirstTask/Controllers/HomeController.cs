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
            var articles = new Article().CreateTestList();

            return View(articles);
        }
        public ActionResult Guest(string Name, string Text)
        {
            if (Request.HttpMethod == "GET")
            {
                return View(Comments.comments);
            }
            else
            {
                Comments.comments.Add(new Article(Name, Text));
                return View(Comments.comments);
            }
        }
        public ActionResult Blank()
        {
            return View();
        }
        public ActionResult Result(FormCollection answers)
        {
            int score = 0;
            if (answers["Radio"] == "One")
                score++;
            if (answers["Text"].ToUpper() == "BALL")
                score++;
            if (Convert.ToBoolean(answers["Check1"].Split(',')[0]) == true &&
                Convert.ToBoolean(answers["Check2"].Split(',')[0]) == true &&
                Convert.ToBoolean(answers["Check3"].Split(',')[0]) == false)
                score++;
            return View(score);
        }  
    }
}