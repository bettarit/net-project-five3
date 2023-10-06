using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ContactForm.Models;

 namespace ContactForm.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {
            Contact contactUs = new Contact();
            return View(contactUs);
        }
        [HttpPost]
        public ActionResult Index(Contact contactUs)
        {
            using (ContactDBEntities db = new ContactDBEntities())
            {

                if (db.Contacts.Any(x => x.Email == contactUs.Email))
                {
                    ViewBag.DuplicateMessage = "EmailID Already Exists";
                    return View("Index", contactUs);
                }
                else
                {
                    db.Contacts.Add(contactUs);
                    db.SaveChanges();
                }
                ModelState.Clear();
                ViewBag.SuccessMessage = "Saved Successfully";
                return View("Index", new Contact());

            }
        }
    }
}