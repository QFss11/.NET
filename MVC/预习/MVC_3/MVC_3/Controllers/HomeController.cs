using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_3.Models;

namespace MVC_3.Controllers
{
    public class HomeController : Controller
    {
        #region 3.2手动绑定
        
        //public ActionResult Index()
        //{

        //    person p = new person();
        //    if (request.form.count > 0)
        //    {
        //        p.id = request.form["id"];
        //        p.firstname = request.form["firstname"];
        //        p.lastname = request.form["lastname"];
        //        viewbag.statusmessage = "欢迎您！" + p.firstname + p.lastname + "您的证件号是" + p.id + "!";
        //    }

        //    return View();

        //}
        #endregion


            //3.3
        //Get访问 /HOME/Index
        public ActionResult Index()
        {
            //var defaultEmails = new[] { "admin@test.com", "", "", "", "" };
            //ViewBag.Emails = defaultEmails;

            var defaultEmails = new[] { new info("admin@test.com", "admin"), new info(), new info(), new info(), new info() };
            ViewBag.info = defaultEmails;
            return View();
        }
        [HttpPost]
        public ActionResult Register(IList<info> info)
        {
            ViewBag.RegisterEmails = info;
            return View();
        }
        //3.4文件上传
        //GET访问 /Home/Upload
        public ActionResult Upload()
        {
            return View();
        }
        //文件上传
        [HttpPost]
        public ActionResult Upload(HttpPostedFileBase file)
        {
            if(file!=null)
            {
                if(file.ContentLength == 0)
                {
                    return View();
                }
                else
                {
                    file.SaveAs(Server.MapPath("~/UploadFile/" + file.FileName));
                }
            }
            return View();
        }
        //3.2模型绑定
        //[HttpPost]
        //public ActionResult Index(person p)
        //{
        //    ViewBag.statusmessage = "欢迎您！" + p.FirstName + p.LastName + "您的证件号是" + p.Id + "!";
        //    return View();
        //}
        //public ActionResult Index(string uname,int?uage)
        //{
        //    ViewBag.Info = "您输入的名称是:" + uname + ",年龄是:" + uage;
        //    return View();
        //}


    }
}