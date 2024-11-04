using pool_project.Entities;

namespace pool_project.Services
{
    public class WorkersService
    {

        List<Workers> listWorkers = new List<Workers>();
        public List<Workers> GetAll()
        {
            if (listWorkers == null)
                return null;
            return listWorkers;
        }
        public bool Post(Workers e)
        {
            if (listWorkers == null)
                return false;
            listWorkers.Add(e);
            return true;
        }
        public bool Put(int id, Workers e)
        {
            if (listWorkers == null)
                return false;
            for (int i = 0; i < listWorkers.Count; i++)
            {
                if (listWorkers[i].Id == id)
                {
                    listWorkers[i] = e;
                    return true;
                }
            }
            return false;
        }
        public bool Delete(int id)
        {
            if (listWorkers == null)
                return false;
            for (int i = 0; i < listWorkers.Count; i++)
            {
                if (listWorkers[i].Id == id)
                {
                    listWorkers.RemoveAt(i);
                    return true;
                }
            }
            return false;

        }
        public Workers GetById(int id)
        {
            if (listWorkers == null)
                return null;
            for (int i = 0; i < listWorkers.Count; i++)
            {
                if (listWorkers[i].Id == id)
                    return listWorkers[i];
            }
            return null;

        }
    }
}
