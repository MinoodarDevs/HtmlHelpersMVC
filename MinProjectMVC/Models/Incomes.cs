//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MinProjectMVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Incomes
    {
        public int IncomeID { get; set; }
        public int PersonID { get; set; }
        public int IncomeAmount { get; set; }
        public System.DateTime IncomeDate { get; set; }
    
        public virtual People People { get; set; }
    }
}
