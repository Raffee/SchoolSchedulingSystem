using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using SchoolSchedulingSystem.Models;
using SchoolSchedulingSystem.ViewModels;

namespace SchoolSchedulingSystem.Controllers
{
    public class TeachersController : Controller
    {
        private ApplicationDbContext _context;

        public TeachersController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Teachers
        public async Task<IActionResult> Index()
        {
            return View(await _context.Teachers.ToListAsync());
        }

        // GET: Teachers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Teacher teacher = await _context.Teachers.SingleAsync(m => m.ID == id);
            if (teacher == null)
            {
                return HttpNotFound();
            }

            return View(teacher);
        }

        // GET: Teachers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Teachers/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TeachersViewModel teacherUser)
        {
            if (ModelState.IsValid)
            {
                Teacher teacher = new Teacher();
                teacher.AvailabilityType = teacherUser.AvailabilityType;
                teacher.RegistrationDate = teacherUser.RegistrationDate;
                _context.Teachers.Add(teacher);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(teacherUser);
        }

        // GET: Teachers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Teacher teacher = await _context.Teachers.SingleAsync(m => m.ID == id);
            if (teacher == null)
            {
                return HttpNotFound();
            }
            return View(teacher);
        }

        // POST: Teachers/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Teacher teacher)
        {
            if (ModelState.IsValid)
            {
                _context.Update(teacher);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(teacher);
        }

        // GET: Teachers/Delete/5
        [ActionName("Delete")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Teacher teacher = await _context.Teachers.SingleAsync(m => m.ID == id);
            if (teacher == null)
            {
                return HttpNotFound();
            }

            return View(teacher);
        }

        // POST: Teachers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            Teacher teacher = await _context.Teachers.SingleAsync(m => m.ID == id);
            _context.Teachers.Remove(teacher);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
