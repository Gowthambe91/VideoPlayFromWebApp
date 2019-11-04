using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VideoFilePlayFromWebApp.Controllers
{
    public class LocalVideosController : Controller
    {
        // GET: LocalVideos
        public ActionResult Index()
        {
            return View();
        }
    }
}