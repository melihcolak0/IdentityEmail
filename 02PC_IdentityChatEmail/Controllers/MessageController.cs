using _02PC_IdentityChatEmail.Context;
using _02PC_IdentityChatEmail.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace _02PC_IdentityChatEmail.Controllers
{
    public class MessageController : Controller
    {
        private readonly EmailContext _context;
        private readonly UserManager<AppUser> _userManager;

        public MessageController(EmailContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> InBox(string search)
        {
            ViewBag.page = "Gelen Mesajlar";                     

            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var userMail = user.Email;

            ViewBag.email = user.Email;
            ViewBag.name = user.Name + " " + user.Surname;

            var messages = _context.Messages
                .Where(x => x.ReceiverMail == userMail);

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

        public async Task<IActionResult> SendBox(string search)
        {
            ViewBag.page = "Gönderilen Mesajlar";           

            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var userMail = user.Email;

            var messages = _context.Messages
                .Where(x => x.SenderMail == userMail);

            if (!string.IsNullOrEmpty(search))
            {
                messages = messages.Where(x =>
                    x.Subject.Contains(search) ||
                    x.ReceiverMail.Contains(search) ||
                    x.MessageDetail.Contains(search));
            }

            var messageList = await messages.OrderByDescending(x => x.SendDate).ToListAsync();

            return View(messageList);
        }

        [HttpGet]
        public IActionResult CreateMessage()
        {
            ViewBag.page = "Yeni Mesaj Oluştur";
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateMessage(Message message)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            string senderMail = user.Email;

            message.SenderMail = senderMail;
            message.IsRead = false;
            message.SendDate = DateTime.Now;
            _context.Messages.Add(message);
            _context.SaveChanges();
            return RedirectToAction("SendBox");
        }

        public async Task<IActionResult> MessageDetailInBox(int id)
        {
            ViewBag.page = "Gelen Mesaj Detayı";

            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.nameSurname = user.Name + " " + user.Surname;
            ViewBag.email = user.Email;
            ViewBag.userImage = user.ProfileImageUrl;

            var message = _context.Messages.Find(id);            
            return View(message);
        }

        public async Task<IActionResult> MessageDetailSendBox(int id)
        {
            ViewBag.page = "Gönderilen Mesaj Detayı";

            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.nameSurname = user.Name + " " + user.Surname;
            ViewBag.email = user.Email;
            ViewBag.userImage = user.ProfileImageUrl;

            var message = _context.Messages.Find(id);
            return View(message);
        }
    }
}
