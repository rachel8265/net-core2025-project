
using pool_project;
using pool_project.Entities;
namespace pool_project.Services
{
    public class CardsService
    {
       List<Cards> listCards=new List<Cards>();
        public List<Cards> GetAll()
        {
            if (listCards == null)
                return null;
            return listCards;
        }
        public bool Post(Cards e)
        {
            if (listCards == null)
                return false;
            listCards.Add(e);
            return true;
        }
        public bool Put(int id, Cards e)
        {
            if (listCards == null)
                return false;
            for (int i = 0; i < listCards.Count; i++)
            {
                if (listCards[i].Id == id)
                {
                    listCards[i] = e;
                    return true;
                }
            }
            return false;
        }
        public bool Delete(int id)
        {
            if (listCards == null)
                return false;
            for (int i = 0; i < listCards.Count; i++)
            {
                if (listCards[i].Id == id)
                {
                    listCards.RemoveAt(i);
                    return true;
                }
            }
            return false;

        }
        public Cards GetById(int id) 
        {
            if (listCards == null)
                return null;
            for (int i = 0; i < listCards.Count; i++)
            {
                if (listCards[i].Id == id)
                return listCards[i];
            }
            return null;
           
        }
    }
}
