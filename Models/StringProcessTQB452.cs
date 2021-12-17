using System;
using System.ComponentModel.DataAnnotations;

namespace TranQuocBao452.Models
{
    public class StringProcessTQB452 : TQB0452
    {
        [Key]
        public string TQB0452ID { get; set; }
        [Display(Name = "tên trường")]
         public int TQB0452name { get; set; }
         public int TQB0452Gender { get; set; }
       
    }
}
