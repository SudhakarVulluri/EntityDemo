﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CognineSales.Models
{
    public class Userdata :PersonalDetails
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int? ManagerId { get; set; }
    }
}
