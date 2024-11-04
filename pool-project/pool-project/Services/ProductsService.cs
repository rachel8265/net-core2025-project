namespace pool_project.Services
{
    public class ProductsService
    {
        List<Products> listProducts = new List<Products>();
        public List<Products> GetAll()
        {
            if (listProducts == null)
                return null;
            return listProducts;
        }
        public bool Post(Products e)
        {
            if (listProducts == null)
                return false;
            listProducts.Add(e);
            return true;
        }
        public bool Put(int id, Products e)
        {
            if (listProducts == null)
                return false;
            for (int i = 0; i < listProducts.Count; i++)
            {
                if (listProducts[i].Id == id)
                {
                    listProducts[i] = e;
                    return true;
                }
            }
            return false;
        }
        public bool Delete(int id)
        {
            if (listProducts == null)
                return false;
            for (int i = 0; i < listProducts.Count; i++)
            {
                if (listProducts[i].Id == id)
                {
                    listProducts.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }
        public Products GetById(int id)
        {
            if (listProducts == null)
                return null;
            for (int i = 0; i < listProducts.Count; i++)
            {
                if (listProducts[i].Id == id)
                    return listProducts[i];
            }
            return null;

        }
    }
}
