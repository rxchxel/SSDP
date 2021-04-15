﻿using DnD___Campaign_Dashboard_v._1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DnD___Campaign_Dashboard_v._1.Controllers
{
    public class ItemsController : Controller
    {
        private ApplicationDbContext _context;
        public ItemsController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Weapons
        [Authorize]
        public ActionResult Index()
        {
            var items = _context.MagicItems.ToList();
            return View(items);
        }
    }
}