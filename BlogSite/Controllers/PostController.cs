using BlogSite.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlogSite.Controllers
{
    public class PostController : Controller
    {
        private readonly DatabaseContext _context;
        public PostController(DatabaseContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> IndexAsync()
        {
            var model = await _context.Posts.ToListAsync();
            return View(model);
        }
        public async Task<IActionResult> SearchAsync(string word)
        {
            var model = await _context.Posts.Where(p => p.PostName.Contains(word)).ToListAsync();
            return View(model);
        }
        public async Task<IActionResult> Details(int id)
        {
            var model = await _context.Posts.FindAsync(id);
            return View(model);
        }
    }
}
