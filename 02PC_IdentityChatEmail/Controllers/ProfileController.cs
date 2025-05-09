using _02PC_IdentityChatEmail.Context;
using _02PC_IdentityChatEmail.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace _02PC_IdentityChatEmail.Controllers
{
    public class ProfileController : Controller
    {
        private readonly EmailContext _context;
        private readonly UserManager<AppUser> _userManager;

        public ProfileController(EmailContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> ProfileDetail()
        {
            ViewBag.page = "Profilim";

            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.username = user.UserName;
            ViewBag.name = user.Name;
            ViewBag.surname = user.Surname;
            ViewBag.email = user.Email;
            ViewBag.phonenumber = user.PhoneNumber;
            ViewBag.city = user.City;
            ViewBag.profileimage = user.ProfileImageUrl;
            return View();
        }
    }
}
