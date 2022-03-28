using System;
using System.ComponentModel.DataAnnotations;

namespace NguyenVanCuong2022560
{
    public class PersonNVC2022560
    {
        [Key]
        public string PersonID { get; set; }
        public string PersonName { get; set; }
    }
}