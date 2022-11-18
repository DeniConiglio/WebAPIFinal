using Microsoft.EntityFrameworkCore;
using WebApiFinalConiglioDenise.Models;
using WebApiFinalConiglioDenise.Data;

namespace WebApiFinalConiglioDenise.Data
{
    public class DBHospitalApiContext:DbContext
    {

        public DBHospitalApiContext(DbContextOptions<DBHospitalApiContext> options) : base(options) { }

        //DBSET
        public DbSet<Doctor> Doctores { get; set; }
        public DbSet<Hospital> Hospitales { get; set; }
       

    }
}
