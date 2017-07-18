using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace TheRota.Models
{
    public class RotaContext : DbContext 
    {
        public IConfigurationRoot _config { get; private set; }

        public RotaContext(IConfigurationRoot config, DbContextOptions options) : base(options)
        {
            _config = config;
        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Fixture> Fixtures { get; set; }
        public DbSet<Rota> Rotas { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<PersonRole> PersonRoles { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(_config["ConnectionStrings:RotaContextConnection"]);
        }
    }
}
