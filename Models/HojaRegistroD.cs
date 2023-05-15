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
    [Table("t_HojaRegistroD")]
    
        public class HojaRegistroD
        {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }
        [Column("Hora")]
        public DateTime PaymentDate { get; set; }
        [Column("Tiera/Papeles")]
        public string tierra { get; set; }
        [Column("Embolsado")]
        public string embolsado { get; set; }
        [Column("Nivel Ejecucion")]
        public string nivel { get; set; }
        [Column("Uniforme")]
        public string uniforme { get; set; }
        [Column("Herramientas")]
        public string herramientas { get; set; }
        [Column("Personal Comp")]
        public string Completo { get; set; }
        [Column("Personal Idn")]
        public string identificado { get; set; }
        [Column("EPP")]
        public string epp { get; set; }
        }
    
}