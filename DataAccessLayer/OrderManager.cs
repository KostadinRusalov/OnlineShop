using System;
using System.Linq;
using BusinessLayer;
using System.Collections.Generic;

namespace DataAccessLayer
{
    public class OrderManager : IDB<Order, int>
    {
        public void Create(Order item)
        {
            try
            {
                using (OnlineShopDBContext dBContext = new OnlineShopDBContext())
                {
                    dBContext.Orders.Add(item);
                    dBContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Order Read(int key)
        {
            try
            {
                using (OnlineShopDBContext dBContext = new OnlineShopDBContext())
                {
                    return dBContext.Orders.Find(key);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Order> ReadAll()
        {
            try
            {
                using (OnlineShopDBContext dBContext = new OnlineShopDBContext())
                {
                    return dBContext.Orders.ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(Order item)
        {
            try
            {
                using (OnlineShopDBContext dBContext = new OnlineShopDBContext())
                {
                    Order productFromDB = dBContext.Orders.Find(item.ID);
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
                    Order productFromDB = dBContext.Orders.Find(key);
                    dBContext.Orders.Remove(productFromDB);
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
