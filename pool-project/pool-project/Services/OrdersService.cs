using pool_project.Entities;

namespace pool_project.Services
{
    public class OrdersService
    {
        List<Orders> listOrders = new List<Orders>();
        public List<Orders> GetAll()
        {
            if (listOrders == null)
                return null;
            return listOrders;
        }
        public bool Post(Orders e)
        {
            if (listOrders == null)
                return false;
            listOrders.Add(e);
            return true;
        }
        public bool Put(int id, Orders e)
        {
            if (listOrders == null)
                return false;
            for (int i = 0; i < listOrders.Count; i++)
            {
                if (listOrders[i].Id == id)
                {
                    listOrders[i] = e;
                    return true;
                }
            }
            return false;
        }
        public bool Delete(int id)
        {
            if (listOrders == null)
                return false;
            for (int i = 0; i < listOrders.Count; i++)
            {
                if (listOrders[i].Id == id)
                {
                    listOrders.RemoveAt(i);
                    return true;
                }
            }
            return false;

        }
        public Orders GetById(int id)
        {
            if (listOrders == null)
                return null;
            for (int i = 0; i < listOrders.Count; i++)
            {
                if (listOrders[i].Id == id)
                    return listOrders[i];
            }
            return null;

        }
    }
}
