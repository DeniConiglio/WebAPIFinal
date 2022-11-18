using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiFinalConiglioDenise.Models
{
    public class Doctor
    {
        public int DoctorId { get; set; }
        public int IdHospital{ get; set; }
        [ForeignKey("IdHospital")]
        
        [Column(TypeName ="varchar(50)")]
        public string Apellido { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Especialidad { get; set; }

        public Hospital Hospital { get; set; }
    }
}
