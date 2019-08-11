using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppFormPerson.Models
{
    public class PersonModel
    {
        public int Id { get; set; }

        [Display(Name = "Дата")]
        public DateTime Date { get; set; }
        //    get
        //    {
        //        return DateTime.Now;
        //    }
        //    set { }            
        //}
        [Required(ErrorMessage = "Обязательное поле")]
        [Display(Name = "Номер заявки")]
        public int Number { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        [Display(Name = "Наименование организации")]
        public string Organization { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        [Display(Name = "ФИО")]
        public string Full_name { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        [Display(Name = "Должность")]
        public string Position { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        [Display(Name = "Email")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}",ErrorMessage = "Некорректный e-mail")]
        public string Email { get; set; }
       
    }
}