using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using class3.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace class3.Controllers
{
    public class ArticleController : Controller
    {
        // GET: /<controller>/
        /*public IActionResult Index()
        {
           /* var articles = new[]
            {
             new Article
            {
                Author = "Alisha",
                Title = "My first Article",
                Body = "These the first time I am Using MVC",
                Datecreated = DateTime.Now
            }
            };
            return View(articles);*/
            [HttpGet]
            public IActionResult Create()
            {
                return View();
            }
        [HttpPost]
        public IActionResult Create(Article article)
        {
            return View(article);
        }
    }
    }


