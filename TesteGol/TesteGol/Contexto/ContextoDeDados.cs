using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using TesteGol.Models;

namespace TesteGol.Contexto
{
    public class ContextoDeDados : DbContext
    {
        public DbSet<Airplane> Airplanes { get; set; }
    }
}