using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace RegistrationEF.Models.Database
{
    public class RegistrationDbContext : DbContext
    {
        public RegistrationDbContext(DbContextOptions<RegistrationDbContext> options) : base(options) { }

        public DbSet<RegistrationModel> Registration { get; set; }

        public DbSet<CountryModel> Countries { get; set; }
        public DbSet<StateModel> States { get; set; }
        public DbSet<CityModel> Cities { get; set; }
    }
}

