using System;
using System.ComponentModel.DataAnnotations;
using system.collections.generic;

namespace TranQuocBao452.Models
{
    [table(“TQB452”)]
    public class TQB0452
    {
        [Key]
        public string TQB0452ID { get; set; }
        [Display(Name = "tên trường")]
         public string TQB0452name { get; set; }
         public string TQB0452Gender { get; set; }
       
    }
}
