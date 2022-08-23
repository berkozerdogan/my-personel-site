using Personel.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personel.Entites.MainEntities
{
    [Table("Comments", Schema = "MainEntities")]
    public class Comment : EntityBase
    {
        [Required]
        public Guid PostId { get; set; }

        [Required]
        public Guid UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public User User { get; set; }

        [Required]
        [MaxLength(250)]
        public string Post { get; set; }

        [Required]
        public DateTime SendDate { get; set; }

        public string Deneme { get; set; }
    }
}