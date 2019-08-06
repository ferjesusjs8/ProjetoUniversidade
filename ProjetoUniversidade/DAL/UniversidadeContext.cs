using ProjetoUniversidade.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjetoUniversidade.DAL
{
    public class UniversidadeContext : DbContext
    {
        private static string conn = System.Configuration.ConfigurationManager.ConnectionStrings["ConexaoLocalDB"].ConnectionString;
        public UniversidadeContext() : base(conn) { }

        public DbSet<Professor> Professor { get; set; }

        public DbSet<Materia> Materia { get; set; }

        public DbSet<ProfessorMateria> ProfessorMateria { get; set; }
    }
}