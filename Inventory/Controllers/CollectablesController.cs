using Inventory.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Collectible collectible)
    {
      _db.Collectables.Add(collectible);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Collectible thisCollectible = _db.Collectables.FirstOrDefault(collectible => collectible.CollectibleId == id);
      return View(thisCollectible);
    }

    public ActionResult Edit(int id)
    {
      var thisCollectible = _db.Collectables.FirstOrDefault(collectible => collectible.CollectibleId == id);
      return View(thisCollectible);
    }

    [HttpPost]
    public ActionResult Edit(Collectible collectible)
    {
      _db.Entry(collectible).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      var thisCollectible = _db.Collectables.FirstOrDefault(collectible => collectible.CollectibleId == id);
      return View(thisCollectible);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisCollectible = _db.Collectables.FirstOrDefault(collectible => collectible.CollectibleId == id);
      _db.Collectables.Remove(thisCollectible);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}