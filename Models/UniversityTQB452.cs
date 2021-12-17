using System;
using System.ComponentModel.DataAnnotations;

namespace TranQuocBao452.Models
{
    public class UniversityTQB452
    {
        [Key]
        [Display(Name = "ID trường")]
        [column(TypeName = "nvarchar(50)”)]  
        public int PersonId { get; set; }
        [Display(Name = "tên trường")]
        [column(TypeName = "nvarchar(50)”)]  
         public int Personname { get; set; }
       
    }
}
