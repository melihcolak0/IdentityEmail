using _02PC_IdentityChatEmail.Context;
using _02PC_IdentityChatEmail.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _02PC_IdentityChatEmail.ViewComponents
{
    public class _SearchComponent : ViewComponent
    {
        private readonly EmailContext _context;
        private readonly UserManager<AppUser> _userManager;

        public _SearchComponent(EmailContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync(string search)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var userMail = user.Email;

            var messages = _context.Messages.Where(x => x.ReceiverMail == userMail);

            if (!string.IsNullOrEmpty(search))
            {
                messages = messages.Where(x =>
                    x.Subject.Contains(search) ||
                    x.SenderMail.Contains(search) ||
                    x.MessageDetail.Contains(search));
            }

            var messageList = await messages.OrderByDescending(x => x.SendDate).ToListAsync();
            return View(messageList);
        }
    }
}
