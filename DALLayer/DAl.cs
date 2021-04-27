using BOLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.ModelBinding;

namespace DALLayer
{
    public interface IInventory
    {
        List<Inventory> GetInventories();
        void InsertInventory(Inventory obj);
        void DeleteInventory(int id);

    }
    //public class DAl
    //{
    //    InventoryDbContext db = new InventoryDbContext();

    //    public List<Inventory> GetInventories()
    //    {

    //        return db.Inventories.ToList();

    //    }


    //    public void InsertInventory(Inventory obj)
    //    {
    //        try
    //        {

    //            db.Inventories.Add(obj);
    //            db.SaveChanges();
    //        }
    //        catch(Exception ex)
    //        {
    //            throw ex;
    //        }
    //        // Save();
    //    }

    //    public void UpdateInventory(int id, Inventory obj)
    //    {
    //        Inventory temp = db.Inventories.Find(id);
    //        if (temp != null)
    //        {
    //            foreach (Inventory tempObj in db.Inventories.ToList())
    //            {
    //                if (tempObj.id == temp.id)
    //                {

    //                    tempObj.vendor = temp.vendor;
    //                    tempObj.qty_stock = temp.qty_stock;

    //                }

    //            }//
    //            //Save();
    //        }


    //    }

    //    public void DeleteInventory(int id)
    //    {
    //        Inventory temp = db.Inventories.Find(id);
    //        if (temp != null)
    //        {

    //            db.Inventories.Remove(temp);
    //        }
    //        // Save();
    //    }

    //    public void Save()
    //    {
    //        db.SaveChanges();

    //    }
    //}

}
