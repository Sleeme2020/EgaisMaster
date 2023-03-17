using Models.DBO;
using DBOConfing;
using Microsoft.EntityFrameworkCore;

namespace Behavior
{
    public static class UserBehavior
    {
        public static User? GetUser(int  id)
        {
            using(AppDBContext appDB = new AppDBContext()) 
            {
                return appDB.Users.FirstOrDefault(x => x.Id == id);
            }
        }

        public static User? GetUser(string Login)
        {
            using (AppDBContext appDB = new AppDBContext())
            {
                return appDB.Users.FirstOrDefault(x => x.Login == Login);
            }
        }

        public static List<User> GetUser()
        {
            using (AppDBContext appDB = new AppDBContext())
            {
                appDB.Users.Load();
                return appDB.Users.ToList();
            }
        }

        public static void Post(User user) 
        {
            using (AppDBContext appDB = new AppDBContext())
            {
                appDB.Users.Add(user);
                appDB.SaveChanges();
            }
        }
        public static void Delete(int id) 
        {
            using (AppDBContext appDB = new AppDBContext())
            {
                var user = appDB.Users.FirstOrDefault(u=>u.Id==id);
                if(user != null)
                {
                    appDB.Users.Remove(user);
                    appDB.SaveChanges();
                }
                else
                {
                    throw new Exception("Not implement DB enty");
                }
            }
        }
        public static void update(User us)
        {
            using (AppDBContext appDB = new AppDBContext())
            {
                var user = appDB.Users.FirstOrDefault(u => u.Login == us.Login);
                if (user != null)
                {
                    appDB.Update(user.Copy(us));
                    appDB.SaveChanges();
                }
                else
                {
                    throw new Exception("Not implement DB enty");
                }
            }
        }
    }
}
