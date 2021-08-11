using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timetable.DataAccessLayer;
using Timetable.Domains.Headteacher;

namespace Timetable.Controllers
{
    public class InformerController : Controller
    {
        private IDirectorRepository _repository;
        private ApplicationDbContext _context;

        private static string className;
        private static string dayName;

        public InformerController(ApplicationDbContext context, IDirectorRepository repository)
        {
            _context = context;
            _repository = repository;
        }

        public IActionResult Index()
        {
            IEnumerable<TimetableHead> timetable= _context.Timetables.ToList();
            return View(timetable);
        }

        public async Task<IActionResult> Day(int id)
        {
            TimetableHead time = await _context.Timetables.FindAsync(id);
            className = time.Class;
            IEnumerable<TimetableHead> timetable = _context.Timetables.ToList();

            ViewData["className"] = className;
            return View(timetable);
        }

        public async Task<IActionResult> TimetableFinal(int id)
        {
            TimetableHead time = await _context.Timetables.FindAsync(id);
            dayName = time.Day;
            IEnumerable<TimetableHead> timetablee = _context.Timetables
                .Where(clas => clas.Class == className)
                .Where(day => day.Day == dayName)
                .OrderBy(num => num.Id == id);

            ViewData["dayName"] = dayName;
            return View(timetablee);
        }
    }
}
