using System;
using System.ComponentModel.DataAnnotations;

namespace NguyenVanCuong2022560
{
    public class NVC0560
    {
        [Key]
        [Display(Name ="ID")]
        public string NVCID { get; set; }

        [Required]
        [Display(Name ="Tên ")]
        public string NVCName { get; set; }

        [Required]
        [Display(Name ="Giới tính")]
        public bool NVCGender {get; set;}
    }
}