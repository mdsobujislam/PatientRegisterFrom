using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PatientRegisterFrom.Models
{
    public class Register
    {
        public int id { get; set; }
        [Required, Display(Name = "Visit Date"), Column(TypeName = "date"), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime visitDate { get; set; }
        [Required, Display(Name = "First Name")]
        public string firstName { get; set; }
        [Required, Display(Name = "SurName"), StringLength(10)]
        public string surName { get; set; }
        [Required, Display(Name = "Blood Group")]
        public string bloodGroup { get; set; }
        public string bodyWeight { get; set; }
        [Required, Display(Name = "Age")]
        public string age { get; set; }
        [Required, Display(Name = "Home Address"), StringLength(200)]
        public string homeAddress { get; set; }
        [Required, Display(Name = "Sex")]
        public string sex { get; set; }
        [Required, Display(Name = "Work Address"), StringLength(200)]
        public string workAddress { get; set; }
        [Required, Display(Name = "Marital Status")]
        public string maritalStatus { get; set; }
        [Required, Display(Name = "Name of Next of Kin"), StringLength(50)]
        public string kinName { get; set; }
        [Required, Display(Name = "Name of Kin Phone No"), StringLength(11)]
        public string kinPhoneNo { get; set; }
        [Required, Display(Name = "Address of Next of Kin"), StringLength(200)]
        public string kinAddress { get; set; }
        [Required, Display(Name = "Disability")]
        public string disability { get; set; }
    }
    public class RegisterDbContext:DbContext
    {
        public RegisterDbContext(DbContextOptions<RegisterDbContext> options) : base(options)
        {

        }
        public DbSet<Register> Registers { get; set; }
    }
}
