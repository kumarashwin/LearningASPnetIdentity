using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Threading.Tasks;
using System.Web.Mvc;
using LearningASPnetIdentity.Models;
using Microsoft.AspNet.Identity.Owin;
using System.Web;

namespace LearningASPnetIdentity.Controllers
{
    public class HomeController : BaseController
    {
        // GET: Home
        public async Task<ActionResult> Index()
        {
            var email = "foo@bar.com";
            var password = "Passw0rd";
            var user = await UserManager.FindByEmailAsync(email);

            if (user == null)
            {
                user = new CustomUser {
                    UserName = email,
                    Email = email,
                    FirstName = "Ash",
                    LastName = "Kumar"};

                await UserManager.CreateAsync(user, password);
            }
            else
            {
                //user.FirstName = "Ash";
                //user.LastName = "Kumar";

                //await manager.UpdateAsync(user);

                var results = await SignInManager.PasswordSignInAsync(user.Email, password, true, false);

                if (results == SignInStatus.Success)
                {
                    return Content($"Hello, {user.FirstName} {user.LastName}");
                }

            }

            return Content("Hello, Index");
        }
    }
}