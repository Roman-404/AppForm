using AppFormPerson.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppFormPerson.Controllers
{
    public class FormController : Controller
    {
       
        public ActionResult Index()
        {          
            return View(PersonListStorageModel.storage.GetAllperson().OrderBy(x => x.Id));          
        }        

        public ActionResult Create()
        {
            return View(new PersonModel());
        }

        [HttpPost]
        public ActionResult Create(PersonModel person)
        {
            if (!TryUpdateModel(person))
            {
                return View(person);
            }
            person.Date = DateTime.Now;
            PersonListStorageModel.storage.Create(person);
            return View(person);
        }

        public ActionResult Edit(int id)
        {
            return View(PersonListStorageModel.storage.GetId(id));
        }
        [HttpPost]
        public ActionResult Edit(int id, PersonModel person)
        {
            if (!TryUpdateModel(person))
            {
                return View();
            }
            PersonListStorageModel.storage.Update(person);
            return View(person);
        }
        public ActionResult Delete(int id)
        {
            return View(PersonListStorageModel.storage.GetId(id));
        }
        [HttpPost]
        public ActionResult Delete(int id, FormCollection form)
        {
            PersonListStorageModel.storage.Delete(id);
            return RedirectToAction("Index");           
        }

    }
}