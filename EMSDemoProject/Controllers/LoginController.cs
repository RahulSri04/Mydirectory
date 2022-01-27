using EMSDemoProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMSDemoProject.Controllers
{
    public class LoginController : Controller

    {
        private ApplicationDbContext _dbContext;
        public LoginController(ApplicationDbContext context)
        {
            _dbContext = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public class Gender
        {
            public string Text;
            public string Value;
        }
        public IActionResult Signup()
        {
            List<Gender> gender = new List<Gender>();
            gender.Insert(0, new Gender { Text = "Male", Value = "Male" });
            gender.Insert(0, new Gender { Text = "Female", Value = "Female" });
            gender.Insert(0, new Gender { Text = "Other", Value = "Other" });

            ViewBag.Gender = gender;
            return View();
        }

        public IActionResult Register(Signup signup)
        {
            bool result = false;
            if (ModelState.IsValid)
            {
                _dbContext.Add(signup);
                result = _dbContext.SaveChanges() > 0;
            }
            if (result)
            {
                return RedirectToAction("Index", "Login");
            }
            else
            {
                return View();
            }
        }
        public IActionResult LoginConfirm( Signup signup)
        {
            bool result = false;
            result= _dbContext.Signup.Where(x => x.Email == signup.Email && x.Password == signup.Password).Count() > 0;

            if (result)
            {
                return RedirectToAction("DashBoard", "Login");
            }
            else {
                return RedirectToAction("Index", "Login");
            }          
        }

        public IActionResult DashBoard() {

            return View();
        }
    }
}
