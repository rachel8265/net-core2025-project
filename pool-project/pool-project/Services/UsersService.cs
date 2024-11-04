using pool_project.Entities;

namespace pool_project.Services
{
    public class UsersService
    {

        List<Users> listUsers = new List<Users>();
        public List<Users> GetAll()
        {
            if (listUsers == null)
                return null;
            return listUsers;
        }
        public bool Post(Users e)
        {

            if (listUsers == null)
                return false;
            listUsers.Add(e);
            return true;
        }
        public bool Put(int id, Users e)
        {

            if (listUsers == null)
                return false;
            for (int i = 0; i < listUsers.Count; i++)
            {
                if (listUsers[i].Id == id)
                {
                    listUsers[i] = e;
                    return true;
                }
            }
            return false;
        }
        public bool Delete(int id)
        {

            if (listUsers == null)
                return false;
            for (int i = 0; i < listUsers.Count; i++)
            {
                if (listUsers[i].Id == id)
                {
                    listUsers.RemoveAt(i);
                    return true;
                }
            }
            return false;

        }
        public Users GetById(int id)
        {

            if (listUsers == null)
                return null;
            for (int i = 0; i < listUsers.Count; i++)
            {
                if (listUsers[i].Id == id)
                    return listUsers[i];
            }
            return null;

        }
    }
}
