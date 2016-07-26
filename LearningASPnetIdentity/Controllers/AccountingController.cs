using LearningASPnetIdentity.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LearningASPnetIdentity.Controllers
{
    [Authorize(Roles = "accounting, admin")]
    public class AccountingController : Controller
    {
        public ActionResult Index()
        {
            //var roles = UserManager.GetRolesAsync(User.Identity.GetUserId());

            if(User.IsInRole(SecurityRoles.Admin))
            {
                return Content("Welcome to Accounting, Admin");
            }
            else
            {
                return Content("Get back to work!");
            }
        }
    }
}