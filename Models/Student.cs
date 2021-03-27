using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab6.Models
{
    public class Student : StudentBase
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name ="Student ID")]
        public Guid ID
        {
            get;
            set;
        }
    }
}
