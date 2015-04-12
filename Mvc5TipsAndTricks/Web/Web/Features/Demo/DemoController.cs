using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebDemo.Features.Demo
{
    public class DemoController : Controller
    {

        public ActionResult Metadata()
        {
            return View(new MetadataForm
            {
                Id = Guid.NewGuid()
            });

        }

        public ActionResult Dropdown()
        {
            return View(new DropdownForm
            {

            });
        }

        [HttpGet]
        public ActionResult AutoValidation() {
            return View(new AutoValidationForm());
        }


        [HttpPost]
        public ActionResult AutoValidation(AutoValidationForm form)
        {
            
            return Redirect("/");
        }

        public ActionResult Links() {
            return View(new[]
            {
                    new LinkModel { Url = Url.Action("Dropdown"),Text = "Dropdowns" },
                    new LinkModel { Url = Url.Action("AutoValidation"), Text = "Auto Validate" },
                    new LinkModel { Url = Url.Action("Metadata"), Text = "Metadata" }

            });
        }

    }

    public class DropdownForm
    {
        public int UserId { get; set; }
    }


    public class MetadataForm
    {
        public Guid Id { get; set; }
        public string NormalString { get; set; }
    }


    public class AutoValidationForm
    {
        [Required]
        public string Required { get; set; }
    }
}