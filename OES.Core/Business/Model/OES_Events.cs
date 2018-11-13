using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnEstEnsemble.Core.Business.Model
{
    [Table("Events")]
    public class OES_Events
    {
    [Key]
     public int ID { get; set; }
    [Column("Name")]
      public string Name { get; set; }
      [Column("Date")]
      public DateTime Date { get; set; }
      [Column("Description")]
      public string Description { get; set; }
      [Column("ImageUrl")]
      public string ImageUrl { get; set; }
    }
}
