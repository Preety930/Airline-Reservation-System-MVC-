//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ARSDAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Contact_Details
    {
        public int CnID { get; set; }
        [Required]

       // [RegularExpression("^ ([a - zA - Z0 - 9_\\-\\.] +)@([a - zA - Z0 - 9_\\-\\.] +)\\.([a - zA - Z]{2, 5})$", ErrorMessage = "Enter Valid Email")]
       // [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        public string Email { get; set; }
        [Required]
        

        //[DataType(DataType.PhoneNumber)]
        //[RegularExpression(@"^\\(?([0-9]{3})\\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid Phone number")]
       // [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
                  // ErrorMessage = "Entered phone format is not valid.")]
        public string Cell { get; set; }
        
        public string Tel { get; set; }
        [Required]
        public string Street { get; set; }
        [Required]
        public int State { get; set; }
    
        public virtual State State1 { get; set; }
    }
}