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
    [Table("t_Penalidad")]
    
        public class Penalidades
        {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("Direccion")]
        public String Direccion { get; set; }

        [Column("Distrito")]
        public string Distrito { get; set; }

        [Column("Referencia")]
        public string Referecia { get; set; }

        [Column("Actividad")]
        public string Actividad { get; set; }

        [Column("Ocurrencia")]
        public string Ocurrencia { get; set; }

        [Column("Item")]
        public string Item { get; set; }

        [Column("Nom_Penalidad")]
        public string Nom_Penalidad { get; set; }

        [Column("Obs")]
        public string observacion { get; set; }

        [Column("Nom_sup_Pe")]
        public string Nom_sup_Pe { get; set; }

        [Column("Ape_Sup_pe")]
        public string Ape_Sup_pe { get; set; }

        [Column("DNI_Sup_pe")]
        public string DNI_Sup_pe { get; set; }

        [Column("Correo_Sup_pe")]
        public string Correo_Sup_pe { get; set; }

        [Column("Celular_Sup_pe")]
        public string Celular_Sup_pe { get; set; }

        [Column("obs_Penalidad")]
        public string obs_Penalidad { get; set; }

        [Column("Comentarios")]
        public string Comentarios { get; set; }

        [Column("Fecha")]
        public DateTime Fecha { get; set; }

        [Column("Hora")]
        public DateTime Hora { get; set; }


        [Column("Estado")]
        public string Estado { get; set; }

        [Column("Status")]
        public string Status { get; set; }

        [Column("Nom_Fis")]
        public string Nom_Fis{ get; set; }
        

        }
    
}