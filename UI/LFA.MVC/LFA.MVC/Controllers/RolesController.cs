using LFA.Biz.Ado;
using LFA.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LFA.MVC.Controllers
{
    public class RolesController : Controller
    {
        private RoleRepository _repRole;
        //
        // GET: /Roles/
        public ActionResult Index()
        {
            //Role objRole = new Role();
            //objRole.RoleId = 10;
            //objRole.RoleName = "Administrator";
            //objRole.RoleDesc = "This is an administrator";
            //ViewBag.Role = objRole;

            _repRole = new RoleRepository();
            return View(_repRole.GetAll());
        }
	}
}