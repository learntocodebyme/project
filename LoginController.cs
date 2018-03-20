using Login_MVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Login_MVC.Controllers
{
    public class LOGINController : Controller
    {
        // GET: LOGIN
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult LOGIN()
        {
            return View("LOGIN");
        }
        [HttpPost]
        public ActionResult LOGIN(G12 L)
        {
            if (ModelState.IsValid)
            {
                DB01TEST01Entities D = new DB01TEST01Entities();
                ObjectParameter obj = new ObjectParameter("Flag", 0);
                D.G123(L.UserName, L.Password, obj);
                int id = Convert.ToInt32(obj.Value);
                if (id == 1)
                {
                    Response.Write("<script>alert('Successfully Added')</script>");
                }
                else
                {
                    Response.Write("<script>alert('UnSuccessful')</script>");
                }
            }
         return View("Index");
        }
    }
}
