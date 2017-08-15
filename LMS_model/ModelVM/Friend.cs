using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_model.ModelVM
{
   public  class Friend
    {
      public  List<User> x;
       public Friend()
    {
         x = new List<User>();
    }
        
        public int FriendsId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<User> user { get; set; }
    }
}
