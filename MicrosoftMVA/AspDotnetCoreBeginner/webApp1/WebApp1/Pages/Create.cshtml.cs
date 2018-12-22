using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp1.Pages
{
    public class CreateModel : PageModel
    {
        // Readonly so that whomever has access to this class cannot change the database
        private readonly AppDbContext _db;
        // Create constructor that asks for access to the database
        public CreateModel(AppDbContext db)
        {
            _db = db;
        }
        public Customer customer { get; set; }

        // save information from the html form
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _db.Customers.Add(customer);
            await _db.SaveChangesAsync();
            return RedirectToPage("/");
        }
    }
}
