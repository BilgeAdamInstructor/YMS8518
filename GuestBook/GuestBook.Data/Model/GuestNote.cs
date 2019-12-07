using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GuestBook.Data.Model
{
    public class GuestNote
    {
        public int Id { get; set; }
        [Required,MinLength(2),MaxLength(50)]
        public string Name { get; set; }
        [Required, MinLength(2), MaxLength(50)]
        public string Surname { get; set; }
        [Required, MinLength(6), MaxLength(345)]
        public string Email { get; set; }
        [Required, MinLength(2), MaxLength(1024)]
        public string Message { get; set; }
        public DateTime CreateDate { get; set; }

        
    }
}
