using Personel.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personel.Entites.NewFolder
{
    [Table("Admin", Schema = "MainEntities")]
    public class Admin : User
    {
    }
}