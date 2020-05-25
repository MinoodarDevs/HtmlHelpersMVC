using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MinProjectMVC.Models.MetaData
{
    public class PeopleMetaData
    {
        [Key]
        public int PersonID { get; set; }

        [Display(Name = "نام شخص")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string PersonName { get; set; }

        [Display(Name = "سن شخص")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public int PersonAge { get; set; }

        [Display(Name = "وضعیت شغل")]
        public bool PersonIsEmployed { get; set; }
    }

    
   
}