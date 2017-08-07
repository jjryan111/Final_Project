using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
namespace Final_Project.Models
{

    public class MedReg
    {
        [Required]
        [Key]
        public string medium { get; set; }
        [Key]
        public string firstName { get; set; }

        //public void Button1_Click(string medium)
        //{
        //    if (medium == "Photography")
        //    {
        //        Response.Redirect("/Home/Photo.cshtml");
        //        //                Server.Transfer("/Home/Photo.cshtml");
        //    }
        //    else
        //    {
        //        Server.Transfer("/Home/Index.cshtml");
        //    }
        //}

    }
    public class RegModel
    {
    }
}