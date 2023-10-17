using Bookstore.Data;
using Microsoft.AspNetCore.Mvc;
using LoanModel = Bookstore.Models.LoanModel;

namespace Bookstore.Controllers
{
    public class LoanController : Controller
    {
        private readonly AppDbContext _context;
        public LoanController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var loan = _context.Loan;

            return View(loan);
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(LoanModel loan)
        {
            if (ModelState.IsValid)
            {
                _context.Loan.Add(loan);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]
        public IActionResult Update(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loan = _context.Loan.FirstOrDefault(l => l.Id == id);

            if (loan == null)
            {
                return NotFound();
            }

            return View(loan);
        }

        [HttpPost]
        public IActionResult Update(LoanModel loan)
        {
            if (ModelState.IsValid)
            {
                _context.Loan.Update(loan);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(loan);
        }
    }
}
