using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC11.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //内置对象  Request  Response  Session   Cookie      Application     server
            //           请求      响应      会话   客户端数据   当前网站对象  服务器对象

            //Request 服务器接收客户端数据的
            //Request.QueryString  get请求！
            //Request.Form    post请求!
            //Request.MapPath()将虚拟路径转换成物理路径
            //Requset.Files  post请求的文件（文件上传）

            return Content($"{ Request.QueryString["name"]}-{ Request.QueryString["age"]}-{ Request.QueryString["id"]}");
        }

        //post请求！
        public ActionResult PostData()
        {
            return Content(Request.Form["loginname"]);
        }
        public ActionResult FileData()
        {
            //SaveAs方法需要物理路径
            Request.Files["file"].SaveAs(Request.MapPath("~/uploads/"+Request.Files["file"].FileName));
            return Content("ok");
        }
        public ActionResult ResponseData()
        {
            //Response.Write 向客户端输出内容
            // Response.Redirect重定向

            //Response.Write("hello world");
            //Response.Redirect("http://www.baidu.com");
            return Content("");
        }

        public ActionResult SessionData()
        {
            //Session 会话 数据保存在服务器中 存储少量重要数据
            //Session 是一个键值对
            //Session 的存活时间是20min
            
            Session["user"] = Request.Form["user"];
           return Content("会话中的数据：" + Session["user"]);

        }
        public ActionResult GETSession()
        {
            //Session 会话 数据保存在服务器中 存储少量重要数据
        
            return Content("当前会话中的数据：" + Session["user"]);

        }
        //Cookie
        public ActionResult CookieSava()
        {
            //时效性
            Request.Cookies.Add(new HttpCookie("token")
            {
                Value="abc123321cba",
                //Expires=DateTime.Now.AddDays(7)
                Expires = DateTime.Now.AddHours(5)
            });

            return Content("ok");
        }

        public ActionResult GetCookie()
        {
            return Content(Request.Cookies["token"].Value);
        }
        public ActionResult ClearCookie()
        {
            //清除cookie的特定值，使用过期的方式
            Request.Cookies.Add(new HttpCookie("token")
            {
                Expires = DateTime.Now.AddDays(-1)
            });

            return Content("ok");
        }
        public ActionResult ApplicationData()
        {
            HttpContext.Application["user"] = "123";
            return Content("");
        }
        public ActionResult GetApplicationData()
        {
           
            return Content(HttpContext.Application["user"].ToString());
        }
        public ActionResult ServerDemo()
        {
            //路径不变，内容发生变化
            Server.Transfer("~/Home/ShowDemo.aspx");
            return Content("");
        }
       
    }
}