using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiFinalConiglioDenise.Models
{
    public class Hospital
    {
        public int HospitalId { get; set; }
       
        [Column(TypeName ="varchar(50)")]
        public string Nombre { get; set; }
       
        [Column(TypeName = "varchar(50)")]
        public string Direccion { get; set; }
   
        [Column(TypeName = "varchar(50)")]
        public string Telefono { get; set; }
       
        public int NumCama { get; set; }

        public List<Doctor> Doctores { get; set; }
    }
}
