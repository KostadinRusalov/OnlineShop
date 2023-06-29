using System;
using System.Linq;
using BusinessLayer;
using System.Collections.Generic;

namespace DataAccessLayer
{
    public class CustomerManager : IDB<Customer, int>
    {
        public void Create(Customer item)
        {
            try
            {
                using (OnlineShopDBContext dBContext = new OnlineShopDBContext())
                {
                    dBContext.Customers.Add(item);
                    dBContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Customer Read(int key)
        {
            try
            {
                using (OnlineShopDBContext dBContext = new OnlineShopDBContext())
                {
                    return dBContext.Customers.Find(key);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Customer> ReadAll()
        {
            try
            {
                using (OnlineShopDBContext dBContext = new OnlineShopDBContext())
                {
                    return dBContext.Customers.ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(Customer item)
        {
            try
            {
                using (OnlineShopDBContext dBContext = new OnlineShopDBContext())
                {
                    Customer productFromDB = dBContext.Customers.Find(item.ID);
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
                    Customer productFromDB = dBContext.Customers.Find(key);
                    dBContext.Customers.Remove(productFromDB);
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
