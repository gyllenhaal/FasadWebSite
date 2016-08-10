using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using System.Web.Mvc;

namespace BuildStore.Controllers
{
    public class NavController : Controller
    {
        //
        // GET: /Nav/
        public PartialViewResult Menu(string link = null)
        {
            Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>();
            List<string> arr = new List<string>();
            dic.Add("СКЛЯНІ КОНСТРУКЦІЇ", arr);
            arr = new List<string>();
            arr.Add("АЛЮМІНІЄВІ");
            arr.Add("МЕТАЛЕВІ");
            arr.Add("ДЕРЕВ’ЯНІ");
            dic.Add("ФАСАДНІ КОНСТРУКЦІЇ", arr);
            arr = new List<string>();
            dic.Add("ВЕНТИЛЬОВАНІ ФАСАДИ",arr);
            dic.Add("ПРОЕКТУВАННЯ", arr);
            dic.Add("ВИРОБНИЦТВО ТА ПОСТАЧАННЯ", arr);
            dic.Add("МОНТАЖ", arr);
            ViewBag.Subcategories = dic;
            ViewBag.SelectedCategory = link;
            IEnumerable<string> categories = new string[] { "СКЛЯНІ КОНСТРУКЦІЇ", "ФАСАДНІ КОНСТРУКЦІЇ", "ВЕНТИЛЬОВАНІ ФАСАДИ","ПРОЕКТУВАННЯ","ВИРОБНИЦТВО ТА ПОСТАЧАННЯ", "МОНТАЖ"};
            return PartialView(categories);
        }
        public PartialViewResult TopMenu()
        {
            return PartialView();
        }

    }
}
