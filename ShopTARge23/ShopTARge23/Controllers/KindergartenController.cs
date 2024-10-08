using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShopTARge23.Core.Domain;
using ShopTARge23.Data; // Muutke vastavalt teie projekti struktuurile
using System.Threading.Tasks;

namespace ShopTARge23.Controllers
{
	public class KindergartenController : Controller
	{
		private readonly ShopTARge23Context _context;

		public KindergartenController(ShopTARge23Context context)
		{
			_context = context;
		}

		public async Task<IActionResult> Index()
		{
			var Kindergarten = await _context.Kindergarten.ToListAsync();
			return View(Kindergarten);
		}
	}
}
