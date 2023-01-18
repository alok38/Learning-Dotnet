using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace User_Page_With_Authentication_Authorization
{
    public class User
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }
    }
}