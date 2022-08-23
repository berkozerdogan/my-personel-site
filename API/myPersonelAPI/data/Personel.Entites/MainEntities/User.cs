using Personel.Common;
using Personel.Common.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personel.Entites
{
    [Table("Users", Schema = "MainEntities")]
    public class User : EntityBase
    {
        [Required]
        [MaxLength(105)] //World's Longest FirstName
        public string FirstName { get; set; }

        [Required]
        [MaxLength(37)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(64)]
        public string Email { get; set; }

        [Required]
        [MaxLength(64)]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string PasswordHash { get; set; }

        public int Age { get; set; }
        public Gender Gender { get; set; }
    }
}