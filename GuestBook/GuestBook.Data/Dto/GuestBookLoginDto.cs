using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GuestBook.Data.Dto
{
    public class GuestBookLoginDto
    {
        [Required,MinLength(5),MaxLength(32)]
        public string Username { get; set; }
        [Required, MinLength(8), MaxLength(32)]
        public string Password { get; set; }
    }
}
