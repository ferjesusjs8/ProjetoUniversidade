using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoUniversidade.Models
{
    public class ProfessorMateria
    {
        [Key]
        public int Id { get; set; }
        public int IdProfessor { get; set; }
        public int IdMateria { get; set; }
    }
}