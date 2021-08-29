using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace demomvc.Models
{
    
     [Table("t_producto")]

    public class Registro
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        
        public int id {get; set;}

        public string producto {get; set;}

        public string nombre {get; set;}

        public string categoria{get;set;}

        public double precio{get; set;}
        
        public double descuento{get;set;}
        

    }
}