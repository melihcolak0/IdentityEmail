using _02PC_IdentityChatEmail.Context;
using _02PC_IdentityChatEmail.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace _02PC_IdentityChatEmail.Controllers
{
    public class LayoutController : Controller
    {
        private readonly EmailContext _context;
        private readonly UserManager<AppUser> _userManager;

        public LayoutController(EmailContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            string userMail = user.Email;            

            ViewBag.inboxCount = _context.Messages.Where(x => x.ReceiverMail == userMail).Count();
            ViewBag.sendboxCount = _context.Messages.Where(x => x.SenderMail == userMail).Count();
            return View();
        }
    }
}
