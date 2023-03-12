using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace FristApp.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="กรุณาป้อนชื่อ")]
        [DisplayName("ชื่อ-สกุล")]
        public string? Name { get; set; }

        
        [DisplayName("คะแนนสอบ")]
        [Range(0,100,ErrorMessage ="ป้อนคะแนนได้แค่ 0-100 เท่านั้น")]
        public int Score { get; set; }

    }
}

