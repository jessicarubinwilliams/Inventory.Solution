using Inventory.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Inventory.Controllers
{
  public class CollectablesController : Controller
  {
    private readonly InventoryContext _db;

    public CollectablesController(InventoryContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Collectible> model = _db.Collectables.ToList();
      return View(model);
    }
  }
}