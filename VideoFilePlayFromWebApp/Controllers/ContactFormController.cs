using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VideoFilePlayFromWebApp.Models;


namespace VideoFilePlayFromWebApp.Controllers
{
    public class ContactFormController : Controller
    {
        // GET: ContactForm
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(MemberModel model)
        {
            string FileName = Path.GetFileNameWithoutExtension(model.ImageFile.FileName);
            string FileExtension = Path.GetExtension(model.ImageFile.FileName);

            FileName = DateTime.Now.ToString("yyyyMMdd") + "-" + FileName.Trim() + FileExtension;

            string UploadPath = ConfigurationManager.AppSettings["UserUploadPath"].ToString();

            model.ImagePath = UploadPath + FileName;

            model.ImageFile.SaveAs(model.ImagePath);

            tblMember member = new tblMember();
            
            member.ImagePath = model.ImagePath;
            member.MemberName = model.Name;
            member.PhoneNumber = model.PhoneNumber;

            using (MVCEntities entities = new MVCEntities())
            {             

                entities.tblMembers.Add(member);
                entities.SaveChanges();
            }

                return View();
        }

        public ActionResult ContactGrid()
        {
            return View();
        }
    }
}