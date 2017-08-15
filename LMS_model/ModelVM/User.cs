using LMS_model.ModelVM;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LMS_model
{
    public class User :IdentityUser
    {
        //[Key]
        //public int UserId { get; set; }
        ////[Required]
        //public string Userame { get; set; }
        ////[Required(ErrorMessage = "this field is not Required")]
        ////[DataType(DataType.Password)]
        //public string password { get; set; }
        //public int friendID { get; set; }


        //[ForeignKey("friendID")]
        //public virtual  Friend friends { get; set; }
      
    }
}