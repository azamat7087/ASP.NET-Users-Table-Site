using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TEST.Models;

namespace TEST.Controllers
{
    public class HomeController : Controller
    {
        UserContext db = new UserContext();
        public ActionResult Index()
        {

            IEnumerable<User> users = db.Users;
            ViewBag.Users = users;
            
           
            return View();
        }

        //Create block
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();

            return RedirectToAction("Index");
        }



        //Update block
        [HttpGet]
        public ActionResult Update(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            User user = db.Users.Find(id);

            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        [HttpPost]
        public ActionResult Update(User user)
        {
            db.Entry(user).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }




        //Delete block
        [HttpGet]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            User u = db.Users.Find(id);
            if (u == null)
            {
                return HttpNotFound();
            }
            return View(u);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int? id) {

            User u = db.Users.Find(id);
            if (u != null)
            {
                db.Users.Remove(u);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
      
    }
}