using BusinessLayer.Concrete;
using DataAccessLayer.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeBlogProject.Controllers
{
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new BlogRepository());

        public IActionResult Index()
        {
            return View();
        }
    }
}
