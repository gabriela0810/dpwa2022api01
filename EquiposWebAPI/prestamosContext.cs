using EquiposWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EquiposWebAPI
{
    public class prestamosContext : DbContext
    {
        public prestamosContext(DbContextOptions<prestamosContext> options) : base(options)
        {

        }


        public DbSet<equipos> equipos { get; set; }

    }
}
