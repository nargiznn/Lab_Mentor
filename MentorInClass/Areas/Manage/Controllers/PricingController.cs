using Humanizer.Localisation;
using MentorInClass.Areas.ViewModels;
using MentorInClass.DAL;
using MentorInClass.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MentorInClass.Areas.Manage.Controllers
{
    [Area("manage")]
    public class PricingController : Controller
    {
        private AppDbContext _context;

        public PricingController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(int page = 1)
        {
            var cards = _context.Cards.Include(x=>x.CardFeatures).ToList();
            return View(cards);
        }
    }
}
