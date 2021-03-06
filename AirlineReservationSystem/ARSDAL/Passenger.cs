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

    public partial class Passenger
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Passenger()
        {
            this.Bookings = new HashSet<Booking>();
        }
    
        public int PsID { get; set; }
        [Required]
      //  [RegularExpression("[a-zA-Z]", ErrorMessage = "Please enter character Only.")]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
      // [Range(18, 56, ErrorMessage = "Age Must be between 18 to 56")]
        public int Age { get; set; }
        [Required]
        public string Nationality { get; set; }
       // [RegularExpression("^(?=[^\\d].*?\\d)\\w(\\w|[!@#$%]){7,20}", ErrorMessage = "8 to 20 aplhanumeric characters and select special characters.")]
       
        [DataType(DataType.Password)]
        [Required]
        public string Password { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
