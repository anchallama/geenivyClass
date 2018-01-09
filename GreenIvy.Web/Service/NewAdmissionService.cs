using GreenIvy.Web.Models;
using GreenIvy.Web.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GreenIvy.Web.Service
{
    public class NewAdmissionService
    {
        private Models.ViewModels.NewEntry _model;
        private Models.GreenivyDBEntities db = new Models.GreenivyDBEntities();
        private List<int> studentId=new List<int>();
        private List<int> ParentId = new List<int>();
        
        public NewAdmissionService(NewEntry model)
        {
            _model = model;
        }

        public bool NewEntry()
        {
            var res = false;
            


            return res;
        }

        private bool StudentEntry()
        {
            var res = false;
            try
            {
                foreach (var item in _model.Students)
                {

                }

                res = true;
            }
            catch (Exception)
            {
                res = false;   
            }
            return res;
        }

        private bool ParentEntry()
        {
            var res = false;


            return res;
        }

        private bool StudentParentEntry()
        {
            var res = false;
            try
            {
                foreach (var item in studentId)
                {
                    foreach (var items in ParentId)
                    {
                        var StudentParentModel = new StudentParent();
                        StudentParentModel.ParentId = items;
                        StudentParentModel.StudentId = item;
                        db.StudentParents.Add(StudentParentModel);
                        db.SaveChanges();
                    }
                }
                res = true;
            }
            catch (Exception)
            {
                res = false;
            }

            return res;
        }

    }
}