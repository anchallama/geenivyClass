﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GreenIvy.Web.Models
{
    public class Student
    {
        public int id { get; set; }
        [Display(Name ="First Name")]
        [Required(ErrorMessage ="First Name is required.")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
    }
}