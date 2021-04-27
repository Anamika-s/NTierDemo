using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCClient.Controllers
{
    public class InventoryController : Controller
    {
        // GET: Inventory
        public ActionResult Index()
        {
            BALLayer.Class1 bal = new BALLayer.Class1();
            // BOLayer.Inventory Listinventory
            List<BOLayer.Inventory> inventories = new List<BOLayer.Inventory>();
            inventories = bal.GetInventories();
            return View(inventories);
        }

        // GET: Inventory/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Inventory/Create
        public ActionResult Create()
        {
            BOLayer.Inventory inventory = new BOLayer.Inventory();
            return View(inventory);
        }

        // POST: Inventory/Create
        [HttpPost]
        [HandleError]
        public ActionResult Create(BOLayer.Inventory inventory)
        {
            try
            {
                BALLayer.Class1 x = new BALLayer.Class1();
                x.InsertInventory(inventory);
                // TODO: Add insert logic here
                return RedirectToAction("Index");
            }
            catch (DbEntityValidationException dbError)
            {
                foreach (DbEntityValidationResult entityErr in
dbError.EntityValidationErrors)
                {
                    foreach (DbValidationError error in entityErr.ValidationErrors)
                    {
                        string str = "";
                        str = "Error Property Name " +
                        error.PropertyName + " Error: " + error.ErrorMessage;

                        return View("error");
                    }
                }
            }
            return View();
        }

        // GET: Inventory/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Inventory/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Inventory/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Inventory/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
