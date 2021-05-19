using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebBank.Models
{
    public partial class Deposit
    {
        public Deposit()
        {
            Depositors = new HashSet<Depositor>();
        }

        [Display(Name = "Код вклада")]
        public long DepId { get; set; }
        [Display(Name = "Наименование")]
        public string DepName { get; set; }
        [Display(Name = "Минимальный срок влада")]
        public long MinDepTern { get; set; }
        [Display(Name = "Минимальная сумма вклада")]
        public long MinDepAmount { get; set; }
        [Display(Name = "Процентная ставка")]
        public long AddCond { get; set; }
        [Display(Name = "Валюта")]
        public long CurId { get; set; }

        public virtual Currency Cur { get; set; }
        public virtual ICollection<Depositor> Depositors { get; set; }
    }
}
