// Controllers/ClaimsController.cs
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ST10030780_Part2_Prog6212.Data; // Ensure this namespace matches your Data context
using ST10030780_Part2_Prog6212.Models; // Ensure this namespace matches your Claim model

namespace ST10030780_Part2_Prog6212.Controllers
{
    public class ClaimsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ClaimsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Other methods here...
    }
}
