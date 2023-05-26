using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using Web_MSI.Models;
namespace Web_MSI.Models
{
    
        [Table("t_parques")]
    
        public class Parques
        {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }
        [Column("Nom_Par")]
        public String Nom_Par { get; set; }
    
        }
}