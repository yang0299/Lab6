﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Lab6.Models
{
    public class StudentBase
    {
       [Required]
       [StringLength(50,MinimumLength =1)]
        [Display(Name = "FirstName")]
        public string FirstName
        {
            get;
            set;
        }
        [Required]
        [StringLength(50,MinimumLength =1)]
        [Display(Name = "LastName")]
        public string LastName
        {
            get;
            set;
        }
        [Required]
        [StringLength(50,MinimumLength =1)]
        [Display(Name = "Program")]
        public string Program
        {
            get;
            set;
        }

    }
}
