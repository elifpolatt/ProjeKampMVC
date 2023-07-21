﻿using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKamp.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        ContactManager contactManager = new ContactManager(new EfContactDal());
        ContactValidator contactvalidator = new ContactValidator();
        public ActionResult Index()
        {
            var contactvalues = contactManager.GetList();
            return View(contactvalues);
        }

        public ActionResult GetContactDetails(int id)
        {
            var contactvalues = contactManager.GetByID(id);
            return View(contactvalues);
        }
        public ActionResult ContactPartial()
        {
            return PartialView();
        }
    }
}