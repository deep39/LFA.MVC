using LFA.Biz;
using LFA.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LFA.MVC.Controllers
{
    public class UsersController : Controller
    {
        private UserRepository _repUser = new UserRepository();
        // GET: Users
        public ActionResult Index()
        {
            
            return View(_repUser.GetAll());
        }

        // GET: Users/Details/5
        public ActionResult Details(int id)
        {
            return View(_repUser.GetAll().FirstOrDefault(x => x.UserId == id));
        }

        // GET: Users/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Users/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                string userName = collection[1].ToString();
                string password = collection[2].ToString();
                string email = collection[3].ToString();
                int  roleId =int.Parse(collection[4].ToString());
                User objUser= new User();
                objUser.UserName=userName;
                objUser.Password=password;
                objUser.Email=email;
                objUser.RoleId=roleId;

                // TODO: Add insert logic here
                var newUserName = _repUser.GetAll().FirstOrDefault(x => x.UserName == userName);
                if(newUserName!=null)
                {
                    ViewBag.ErrorMsg = "UserName already exist !!";
                    return View();
                }
                _repUser.Add(objUser);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Users/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_repUser.GetAll().FirstOrDefault(x => x.UserId == id));
        }

        // POST: Users/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                User objUser=new User();
                objUser.UserId = int.Parse(collection[1].ToString());
                objUser.UserName = collection[2].ToString();
                objUser.Password = collection[3].ToString();
                objUser.Email = collection[4].ToString();
                objUser.RoleId = int.Parse(collection[5].ToString());

                _repUser.Edit(objUser);

                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Users/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_repUser.GetAll().FirstOrDefault(x => x.UserId == id));
        }

        // POST: Users/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                _repUser.Delete(id);
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
	}
}