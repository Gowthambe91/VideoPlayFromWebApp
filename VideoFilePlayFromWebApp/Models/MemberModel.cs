using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace VideoFilePlayFromWebApp.Models
{
    public class MemberModel
    {
        [Display(Name = "Member Name")]
        public string Name { get; set; }

        [Display(Name = "Telephone/Mobile No.")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Upload File")]
        public string ImagePath { get; set; }
                
        public HttpPostedFileBase ImageFile { get; set; }
    }
}