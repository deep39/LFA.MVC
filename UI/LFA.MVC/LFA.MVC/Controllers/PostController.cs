using LFA.Biz.Ado;
using LFA.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LFA.MVC.Controllers
{
    public class PostController : Controller
    {
        private PostRepository _repPost = new PostRepository();
        //
        // GET: /Post/
        public ActionResult Index()
        {
            return View(_repPost.GetAll());
        }

        //
        // GET: /Post/Details/5
        public ActionResult Details(int id)
        {
            return View(_repPost.GetAll().FirstOrDefault(x => x.PostId == id));
        }

        //
        // GET: /Post/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Post/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                Post objPost = new Post();
                objPost.PostTitle = collection[1].ToString();
                objPost.PostCotent = collection[2].ToString();
                objPost.UserId = int.Parse(collection[3].ToString());
                // TODO: Add insert logic here
                _repPost.Add(objPost);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Post/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_repPost.GetAll().FirstOrDefault(x => x.PostId == id));
        }

        //
        // POST: /Post/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                Post objPost = new Post();
                objPost.PostId = int.Parse(collection[1].ToString());
                objPost.PostTitle = collection[2].ToString();
                objPost.PostCotent = collection[3].ToString();
                objPost.UserId = int.Parse(collection[4].ToString());
                // TODO: Add update logic here
                _repPost.Edit(objPost);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Post/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_repPost.GetAll().FirstOrDefault(x => x.PostId == id));
        }

        //
        // POST: /Post/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                _repPost.Delete(id);
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
