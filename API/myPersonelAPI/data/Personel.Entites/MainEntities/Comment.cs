using Personel.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personel.Entites.MainEntities
{
    public class Comment : EntityBase
    {
        public int PostId { get; set; }
        public User UserId { get; set; }
        public string Post { get; set; }
        public DateTime SendDate { get; set; }
    }
}