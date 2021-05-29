using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //使用ViewData 从控制器传递文本数据到视图
            ViewData["Message"] = "使用ViewData传递文本数据!";

            //使用ViewBag对象从控制器传递文本数据到视图
            ViewBag.Name = "张三";

            //ViewData属性和ViewBag属性无法跨Action()方法传递数据,需要在Action()方法传递数据时，可采用TemData属性
            TempData["Message"] = "使用TempData传递数据";

            //2.1.4学生实践练习
            ViewBag.Message= "Welcome to ASP.NET MVC!";
            TempData["myAge"] = "I'm 20 year old";
            ViewData["myName"] = "My name is Tom";
            TempData["myNationality"] = "I'm from the U.S.A";
            string name = Request["username"];
            string pwd = Request["pwd"];
            //将值传递至下个视图页面
            ViewBag.name = name;
            ViewBag.pwd = pwd;
            return View();

            
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
    }
}