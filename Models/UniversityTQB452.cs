using System;
using System.ComponentModel.DataAnnotations;

namespace TranQuocBao452.Models
{
    public class UniversityTQB452
    {
        [Key]
        [Display(Name = "ID trường")]
        public int PersonId { get; set; }
        [Display(Name = "tên trường")]
         public int Personname { get; set; }
       
    }
}
