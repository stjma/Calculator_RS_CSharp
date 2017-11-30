//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjetFinal.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class xp
    {
        public int id { get; set; }

        [Required]
        public Nullable<int> id_xpTable { get; set; }

        [Required, RegularExpression(pattern: "^[1-9][0-9]{0,2}$", ErrorMessage = "Niveau doit �tre des nombres"), DisplayName("Niveau")]
        public Nullable<int> lvl { get; set; }

        [Required, RegularExpression(pattern: "^[0-9]{1,9}$", ErrorMessage = "Exp�rience doit �tre des nombres"), DisplayName("Exp�rience")]
        public Nullable<int> xps { get; set; }

        [Required, RegularExpression(pattern: "^[1-9][0-9]{0,8}$", ErrorMessage = "Exp�rience doit �tre des nombres qui commence par 1"), DisplayName("Dif�rence")]
        public Nullable<int> dif { get; set; }
    
        public virtual xpTable xpTable { get; set; }
    }
}
