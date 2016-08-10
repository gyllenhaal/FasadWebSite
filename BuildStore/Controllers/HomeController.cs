using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BuildStore.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Menu_Filter(string link)
        {
            
            List<string> list_of_views = new List<string>{
            "Glass",
            "Fasad",
            "Vent",
            "Projecting",
            "Creating",
            "Instalation"
           };
           List<string> list_of_views_ukr = new List<string>();
            list_of_views_ukr.Add("СКЛЯНІ КОНСТРУКЦІЇ");
            list_of_views_ukr.Add("ФАСАДНІ КОНСТРУКЦІЇ");
            list_of_views_ukr.Add("ВЕНТИЛЬОВАНІ ФАСАДИ");
            list_of_views_ukr.Add("ПРОЕКТУВАННЯ");
            list_of_views_ukr.Add("ВИРОБНИЦТВО ТА ПОСТАЧАННЯ");
            list_of_views_ukr.Add("МОНТАЖ");
            int position = list_of_views_ukr.IndexOf(link);
            return View(list_of_views[position]);
        }
        public ActionResult Sub_Filter(string link)
        {
            List<string> list_of_views = new List<string>{
            "Alloy",
            "Metal",
            "Wood",
            };
            List<string> list_of_views_ukr = new List<string>{
            "АЛЮМІНІЄВІ",
            "МЕТАЛЕВІ",
            "ДЕРЕВ’ЯНІ",
           
            };
            int position = list_of_views_ukr.IndexOf(link);
            return View(list_of_views[position]);
        }
        public ActionResult WeAre()
        {
            return View();
        }
        public ActionResult WhyWe()
        {
            return View();
        }
        public ActionResult Contacts()
        {
            return View();
        }
        public ActionResult Galery()
        {
            return View("Galery");
        }


   
    }
}
