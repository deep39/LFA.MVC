using LFA.Biz.Ado;
using LFA.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LFA.MVC.Controllers
{
    public class CommentController : Controller
    {
        private CommentsRepository repComments = new CommentsRepository(); 
        // GET: /Comment/
        public ActionResult Index()
        {
            return View(repComments.GetAll());
        }

        //
        // GET: /Comment/Details/5
        public ActionResult Details(int id)
        {
            return View(repComments.GetAll().FirstOrDefault(x=>x.CommentId==id));
        }

        //
        // GET: /Comment/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Comment/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                Comment objComment = new Comment();
                objComment.CommentContent = collection[1].ToString();
                objComment.PostId = int.Parse(collection[2].ToString());
                objComment.UserId = int.Parse(collection[3].ToString());
                // TODO: Add insert logic here
                repComments.Add(objComment);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Comment/Edit/5
        public ActionResult Edit(int id)
        {
            return View(repComments.GetAll().FirstOrDefault(x => x.CommentId == id));
        }

        //
        // POST: /Comment/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                Comment objComment = new Comment();
                objComment.CommentId = int.Parse(collection[1].ToString());
                objComment.CommentContent = collection[2].ToString();
                objComment.PostId = int.Parse(collection[3].ToString());
                objComment.UserId = int.Parse(collection[4].ToString());

                
                // TODO: Add update logic here
                repComments.Edit(objComment);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Comment/Delete/5
        public ActionResult Delete(int id)
        {
            return View(repComments.GetAll().FirstOrDefault(x => x.CommentId == id));
        }

        //
        // POST: /Comment/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                repComments.Delete(id);
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
