//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ContactForm.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class Contact
    {
        public int ID { get; set; }
        [DisplayName("First Name")]
        [Required(ErrorMessage="This Field is Required")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        [Required(ErrorMessage = "This Field is Required")]
        public string LastName { get; set; }
        [DisplayName("Telephone")]
        [Required(ErrorMessage = "This Field is Required")]
        public string Telephone { get; set; }
        [DisplayName("Email")]
        [Required(ErrorMessage = "This Field is Required")]
        [EmailAddress(ErrorMessage ="Invalid Email Address")]
        public string Email { get; set; }
    }
}
