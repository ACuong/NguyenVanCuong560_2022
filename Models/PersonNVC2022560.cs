using System;
using System.ComponentModel.DataAnnotations;

namespace NguyenVanCuong2022560
{
    public class PersonNVC2022560
    {
        [Key]
        [DataType("NVARCHAR"), MaxLength(20)]
        public string PersonID { get; set; }

        [DataType("NVARCHAR"), MaxLength(50)]
        public string PersonName { get; set; }
    }
}