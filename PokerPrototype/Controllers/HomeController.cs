﻿using PokerPrototype.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PokerPrototype.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            int id = Convert.ToInt32(Session["id"]);
            if (id > 0 || 1 == 1)
            {
                UserModel model = new UserModel(id);
                return View("Lobby", model);
            }
            return View("Landing");
        }

        public ActionResult Logout()
        {
            Session["id"] = 0;
            ViewBag.MessageType = "info";
            ViewBag.Message = "you have logged out";
            return View("Landing");
        }
        public ActionResult PageNotFound()
        {
            ViewBag.MessageType = "warning";
            ViewBag.Message = "Page not found";
            return View("Landing");
        }

        public ActionResult About()
        {
            return View();
        }
    }
}