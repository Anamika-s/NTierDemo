using BOLayer;
using DALLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BALLayer
{
    public class Class1 : IInventory
    {
         BOLayer.Inventory inventory =new BOLayer.Inventory();
       // Inventory inventory = new DALLayer.Inventory();
        //public void Insert(Inventory inventory)
        //{
        //    dal.InsertInventory(inventory);
        //}
        public void DeleteInventory(int id)
        {
            DALLayer.InventoryDbContext db = new InventoryDbContext();
        //   db.Inventories.Remove(id);
        }

        public List<Inventory> GetInventories()
        {
            DALLayer.InventoryDbContext db = new InventoryDbContext();

            return db.Inventories.ToList();
        }
        public int AddInventory(BOLayer.Inventory inventory)
        {
            DALLayer.InventoryDbContext db = new InventoryDbContext();

            db.Inventories.Add(inventory);
            db.SaveChanges();
            return 1;
        }

        public void InsertInventory(Inventory obj)
        {
            DALLayer.InventoryDbContext db = new InventoryDbContext();

            db.Inventories.Add(obj);
            db.SaveChanges();
        
    }
    }
}
