using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;

namespace MvcProjeKamp.Controllers
{
    public class MessageController : Controller
    {
        // GET: Message
        MessageManager messageManager = new MessageManager(new EfMessageDal());
        MessageValidator messageValidator = new MessageValidator();
        public ActionResult Inbox()
        {
            var messagevalues = messageManager.GetListInbox();
            return View(messagevalues);
        }
        public ActionResult SendBox()
        {
            var messagelist = messageManager.GetSendbox();
            return View(messagelist);
        }
        public ActionResult GetInboxMessageDetails(int id)
        {
            var inboxvalues = messageManager.GetById(id);
            return View(inboxvalues);
        }
        public ActionResult GetSendboxMessageDetails(int id)
        {
            var sendboxvalues = messageManager.GetById(id);
            return View(sendboxvalues);

        }
        [HttpGet]

        public ActionResult NewMessage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewMessage(Message p)
        {
            //ValidationResult results = messageValidator.Validate(p);
            //if (results.IsValid)
            //{
            //    messageManager.MessageAdd(p);
            //    return RedirectToAction("Sendbox");
            //}
            //else
            //{
            //    foreach(var item in results.Errors)
            //    {
            //        ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
            //    }
            //}
            return View();
        }
    }
}