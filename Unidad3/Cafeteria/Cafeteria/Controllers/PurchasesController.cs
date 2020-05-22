using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Cafeteria.Models;

namespace Cafeteria.Controllers
{
    public class PurchasesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Purchases
        public ActionResult Index()
        {
            var statspur = db.Purchases.ToList();
            var statspro = db.Products.ToList();
            var popular = new List<Purchase>();
            var cheap = new List<Purchase>();

            foreach (var item in statspur)
            {
                if (item.Quantity >= 5)
                {
                    popular.Add(item);
                }
            }

            ViewBag.Popular = popular;
            ViewBag.Cheap = cheap;
            var purchases = db.Purchases.Include(p => p.Product);
            return View(purchases.ToList());
        }

        // GET: Purchases/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Purchase purchase = db.Purchases.Find(id);
            if (purchase == null)
            {
                return HttpNotFound();
            }

            return View(purchase);
        }

        // GET: Purchases/Create
        public ActionResult Create()
        {
            
            ViewBag.Products = (from p in db.Products
                                select p).ToList();
            return View();
        }

        // POST: Purchases/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Purchase purchase)
        {
            if (ModelState.IsValid)
            {
                Product product = db.Products.Find(purchase.ProductId);
                decimal total = purchase.Quantity * product.Price;
                purchase.Total = total;
                db.Purchases.Add(purchase);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ProductId = new SelectList(db.Products, "Id", "ProductName", purchase.ProductId);
            return View(purchase);
        }

        // GET: Purchases/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Purchase purchase = db.Purchases.Find(id);
            if (purchase == null)
            {
                return HttpNotFound();
            }
            ViewBag.ProductId = new SelectList(db.Products, "Id", "ProductName", purchase.ProductId);
            return View(purchase);
        }

        // POST: Purchases/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,PurchaseId,ClientName,Quantity,Total,Comment,Status,ProductId")] Purchase purchase)
        {
            if (ModelState.IsValid)
            {
                db.Entry(purchase).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ProductId = new SelectList(db.Products, "Id", "ProductName", purchase.ProductId);
            return View(purchase);
        }

        // GET: Purchases/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Purchase purchase = db.Purchases.Find(id);
            if (purchase == null)
            {
                return HttpNotFound();
            }
            return View(purchase);
        }

        // POST: Purchases/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Purchase purchase = db.Purchases.Find(id);
            db.Purchases.Remove(purchase);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        /*public JsonResult GetPrice(int id)
        {
            if (!Request.IsAjaxRequest())
            {
                return null;
            }

            Product product = db.Products.Find(id);
            int precio = product.Price;
            return new JsonResult { Data = new { precio = precio } };
        }*/
    }
}
