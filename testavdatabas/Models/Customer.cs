using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace testavdatabas.Models
{
    public partial class Customer
    {
        public Customer(string fullName, string email, int phoneNr)
        {
            FullName = fullName;
            Email = email;
            PhoneNr = phoneNr;
        }

        public Customer()
        {

        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string FullName { get; set; }
        [Required]
        [StringLength(100)]
        public string Email { get; set; }
        public int PhoneNr { get; set; }
    }
}
