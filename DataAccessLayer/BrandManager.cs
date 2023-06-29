using System;
using System.Linq;
using BusinessLayer;
using System.Collections.Generic;

namespace DataAccessLayer
{
    public class BrandManager : IDB<Brand, int>
    {
        public void Create(Brand item)
        {
            try
            {
                using (OnlineShopDBContext dBContext = new OnlineShopDBContext())
                {
                    dBContext.Brands.Add(item);
                    dBContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Brand Read(int key)
        {
            try
            {
                using (OnlineShopDBContext dBContext = new OnlineShopDBContext())
                {
                    return dBContext.Brands.Find(key);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Brand> ReadAll()
        {
            try
            {
                using (OnlineShopDBContext dBContext = new OnlineShopDBContext())
                {
                    return dBContext.Brands.ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(Brand item)
        {
            try
            {
                using (OnlineShopDBContext dBContext = new OnlineShopDBContext())
                {
                    Brand productFromDB = dBContext.Brands.Find(item.ID);
                    dBContext.Entry(productFromDB).GetDatabaseValues().SetValues(item);
                    dBContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(int key)
        {
            try
            {
                using (OnlineShopDBContext dBContext = new OnlineShopDBContext())
                {
                    Brand productFromDB = dBContext.Brands.Find(key);
                    dBContext.Brands.Remove(productFromDB);
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
