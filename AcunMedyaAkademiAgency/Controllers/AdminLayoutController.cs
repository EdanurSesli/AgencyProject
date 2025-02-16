using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiAgency.Context;
using AcunMedyaAkademiAgency.Entities;

namespace AcunMedyaAkademiAgency.Controllers
{
    public class AdminLayoutController : Controller
    {
        AgencyContext context = new AgencyContext();
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult FooterPartial()
        {
            return PartialView();
        }
        public PartialViewResult ScriptsPartial()
        {
            return PartialView();
        }

        public PartialViewResult HeadPartial()
        {
            return PartialView();
        }
        public PartialViewResult SidebarPartial()
        {
            var username = Session["username"].ToString();

            var namesurname = context.Admins
                .Where(x => x.Username == username)
                .Select(x => x.Name + " " + x.SurName) 
                .FirstOrDefault();

            ViewBag.profile = namesurname ?? "Bilinmeyen Kullanıcı"; 
            return PartialView();
        }
        public PartialViewResult NavbarPartial()
        {
            var username = Session["username"].ToString();

            var namesurname = context.Admins
                .Where(x => x.Username == username)
                .Select(x => x.Name + " " + x.SurName) // Boşluk ekledim
                .FirstOrDefault();

            ViewBag.profile = namesurname ?? "Bilinmeyen Kullanıcı"; 
            return PartialView();
        }

        public PartialViewResult NotificationPartial()
        {
            var values = context.Notifications.ToList();
            return PartialView(values);
        }

    }
}