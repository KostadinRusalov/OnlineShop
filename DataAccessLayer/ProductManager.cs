using System;
using System.Linq;
using BusinessLayer;
using System.Collections.Generic;

namespace DataAccessLayer
{
    public class ProductManager : IDB<Product, string>
    {
        public void Create(Product item)
        {
            try
            {
                using(OnlineShopDBContext dBContext = new OnlineShopDBContext())
                {
                    dBContext.Products.Add(item);
                    dBContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Product Read(string key)
        {
            try
            {
                using(OnlineShopDBContext dBContext = new OnlineShopDBContext())
                {
                    return dBContext.Products.Find(key);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Product> ReadAll()
        {
            try
            {
                using (OnlineShopDBContext dBContext = new OnlineShopDBContext())
                {
                    return dBContext.Products.ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(Product item)
        {
            try
            {
                using (OnlineShopDBContext dBContext = new OnlineShopDBContext())
                {
                    Product productFromDB = dBContext.Products.Find(item.Barcode);
                    dBContext.Entry(productFromDB).GetDatabaseValues().SetValues(item);
                    dBContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(string key)
        {
            try
            {
                using (OnlineShopDBContext dBContext = new OnlineShopDBContext())
                {
                    Product productFromDB = dBContext.Products.Find(key);
                    dBContext.Products.Remove(productFromDB);
                    dBContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
