using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zirpl.MusicChecker.Web.Models;

namespace Zirpl.MusicChecker.Web.Controllers
{
    public class MusicController : Controller
    {
        public ActionResult Index()
        {
            return View(MusicCatalog.Instance);
        }
    }
}