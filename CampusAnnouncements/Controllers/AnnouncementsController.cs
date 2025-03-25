using Microsoft.AspNetCore.Mvc;
using CampusAnnouncements.Models;
using CampusAnnouncements.Repositories;

namespace CampusAnnouncements.Controllers
{
    public class AnnouncementsController : Controller
    {
        private readonly AnnouncementRepository repository = new AnnouncementRepository();

        public ViewResult Index()
        {
            var announcements = repository.GetAllMyPost();
            return View(announcements);
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Announcement announcement)
        {
            repository.Add(announcement);
            return RedirectToAction("Index");
        }
    }
}
