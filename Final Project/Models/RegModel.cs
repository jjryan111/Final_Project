using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
namespace Final_Project.Models
{

    public class Registration
    {
        [Required]
        [Key]
        public string medium { get; set; }
        [Key]
        public string firstName { get; set; }

    }
    public class RegModel
    {
    }
}