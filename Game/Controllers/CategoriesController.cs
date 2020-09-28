using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Game.Models;
using Microsoft.AspNetCore.Mvc;

namespace Game.Controllers
{
    public class CategoriesController : Controller
    //derived from controller
    {
        public IActionResult Index()
        {
            //using Category model create 10 fake categories and display them via View

            // 1.create an empty list of categories
            var categories = new List<Category>();


            //2. using loop create 10 fake Category
            for(var i=1;i<=10;i++)
            {
                categories.Add(new Category
                {
                    Id = i,
                    Name = "Category" + i.ToString()
                });
            }

            //pass the final list to view for display
            return View(categories);
        }

        public IActionResult Browse(string categoryName)
        {
            //Store the categoryName and link in the ViewBag for display

            ViewBag.categoryName = categoryName;

            //load the view /Views/Categories/Browse
            return View();
        }

        public IActionResult AddCategory()
        {
            //display an empty form where user could add new Category

            return View();
        }
    }
}
