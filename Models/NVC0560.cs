using System;
using System.ComponentModel.DataAnnotations;

namespace NguyenVanCuong2022560
{
    public class NVC0560
    {
        [Key]
        [DataType("NVARCHAR"), MaxLength(20)]
        [Display(Name ="ID")]
        public string NVCID { get; set; }

        [Required]
        [Display(Name ="Tên ")]
        [DataType("NVARCHAR"), MaxLength(50)]
        public string NVCName { get; set; }

        [Required]
        [Display(Name ="Giới tính")]
        public bool NVCGender {get; set;}
    }
}