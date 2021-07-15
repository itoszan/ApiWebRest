using FBLogIn.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FBLogIn
{
  public class AplicationDbContext:DbContext
  { 
  public DbSet<Informacion> Informacion { get; set; }
    public AplicationDbContext(DbContextOptions<AplicationDbContext> options):base(options){  }
        public DbSet<Informacion> ContactoItems { get; set; }
  }

}
