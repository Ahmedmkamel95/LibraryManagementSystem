using LMS_model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using LMS_model;
namespace LMS_Core.Business
{
    public class UserBL
    {
        private LibarayDB db = new LibarayDB();

        public User r = new User();

        public List<User> GetAll()
        {
            var listOfuser = db.Users.ToList();
            return listOfuser;
        }
        public User Login(int? id)
        {

            var User = db.Users.Find(id);
            return User;
        }
        public void Registration(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
        }

        public void Edit(User user)
        {


            db.Entry(user).State = EntityState.Modified;
            db.SaveChanges();
        }
        public void Delete(int? id)
        {
            User user = db.Users.Find(id);
            db.Users.Remove(user);
            db.SaveChanges();
        }
    }
}
