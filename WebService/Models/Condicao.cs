using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebService.Models
{
    [Table("Condicoes")]
    public class Condicao
    {
        [Key]
        public int CondicaoId { get; set; }
        public int Temperature { get; set; }
        public int Wind_Velocity { get; set; }
        public int Humidity { get; set; }        

    }
}
