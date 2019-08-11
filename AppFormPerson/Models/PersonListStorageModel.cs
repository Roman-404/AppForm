using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppFormPerson.Models
{
    public class PersonListStorageModel
    {
       static public PersonListStorageModel storage = new PersonListStorageModel();

        List<PersonModel> personList = new List<PersonModel>();
        
        public List<PersonModel> GetAllperson()
        {
            return this.personList;
        }

        public void Create(PersonModel person)
        {
            if (personList.Exists(x => x.Full_name == person.Full_name))
            {
                throw new InvalidOperationException();
            }
            //person.Id = this.personList.Max(x => x.Id) + 1;
            //person.Number = this.personList.Max(x => x.Number) + 1;
            this.personList.Add(person);
        }

        public PersonModel GetId(int id)
        {
            return this.personList.Find(x => x.Id == id);
        }
        public void Update(PersonModel person)
        {
            var oldPerson = this.personList.Find(x => x.Id == person.Id);
            if (oldPerson == null) return;

            this.personList.Remove(oldPerson);
            this.personList.Add(person);
        }
        public void Delete(int id)
        {
            var person = this.personList.Find(x => x.Id == id);
            if (person == null) return;
            this.personList.Remove(person);
        }
        
    }
}