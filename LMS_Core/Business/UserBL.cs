using LMS_model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using LMS_model;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;
namespace LMS_Core.Business
{
    public class UserBL
    {
        private LibarayDBContext db = new LibarayDBContext();

        public User r = new User();

        UserStore<User> us;
        UserManager<User> u;
        private LibarayDBContext _context;

        
        public List<User> GetAll()
        {
            var listOfuser = db.Users.ToList();
            return listOfuser;
        }
        public bool Login(User  user)
        {
            bool x = false;
            string username = user.UserName;
            string password = user.PasswordHash;
            var check = u.FindByName(username);
            if (check != null)
            {
                if (!u.CheckPassword(check, password))
                {
                 x=false;
                }
            }
            else
                x= true;
            return x;
        }
        public void Registration(User user)
        {
            IdentityResult iuser = u.Create(user, user.PasswordHash);
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
