using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebBank.Models
{
    public partial class Depositor
    {
        [Display(Name = "ФИО")]
        public string FullName { get; set; }
        [Display(Name = "Адрес")]
        public string Adress { get; set; }
        [Display(Name = "Телефон")]
        public string PhoneNum { get; set; }
        [Display(Name = "Паспортные данные")]
        public string PassData { get; set; }
        [Display(Name = "Дата вклада")]
        public DateTime DeposDate { get; set; }
        [Display(Name = "Дата возврата")]
        public DateTime RefundDate { get; set; }
        [Display(Name = "Сумма вклада")]
        public long SummAm { get; set; }
        [Display(Name = "Сумма возврата")]
        public long SummRef { get; set; }
        [Display(Name = "Отметка о возврате")]
        public long DepRafMark { get; set; }
        [Display(Name = "Сотрудник")]
        public long EmId { get; set; }
        [Display(Name = "Вклад")]
        public long DepId { get; set; }

        public virtual Deposit Dep { get; set; }
        public virtual Employee Em { get; set; }
    }
}
