using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Library_managment_Systems.Models
{
    public class User
    {
        [Key]
        public int Id{ get; set; }
      [Required]
        public  string  Username  { get; set; }
    [Required(ErrorMessage = "this field is not Required")]
       [DataType(DataType.Password)]
        public string password { get; set; }


    }
}