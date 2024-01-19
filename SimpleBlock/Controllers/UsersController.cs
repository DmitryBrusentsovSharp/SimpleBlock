using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleBlock.Models;

namespace SimpleBlock.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        public ActionResult Index()
        {
            UsersModel user = new UsersModel();
            int age = 10 / user.age;
            return View();
        }

        public ActionResult ListUsers() 
        {
            List<UsersModel> users = new List<UsersModel>();
            users.Add(new UsersModel("Tom", "Johnson", 56, false));
            users.Add(new UsersModel("Mickey", "Johnson", 22, true));
            users.Add(new UsersModel("Alex", "Johnson", 39, true));

            return View(users);
        }
    }
}