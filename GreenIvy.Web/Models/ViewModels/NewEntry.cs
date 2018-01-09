using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GreenIvy.Web.Models.ViewModels
{
    public class NewEntry
    {
        public List<Student> Students { get; set; }
        public List<Parent> Parents { get; set; }
    }
}