using ProjetoUniversidade.Models;
using ProjetoUniversidade.Resources;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace ProjetoUniversidade.DAL
{
    public class ProfessorDAO
    {
        public IList<Professor> Listar()
        {
            using (var contexto = new UniversidadeContext())
            {
                return contexto.Professor.ToList();
            }
        }

        public static void CriarProfessores()
        {
            using (var contexto = new UniversidadeContext())
            {
                LeitorJSON<Professor>.LerJson("Professores.json").ForEach(p => contexto.Professor.Add(p));
                contexto.SaveChanges();
            }
        }

        public void AdicionaProfessor(Professor professor)
        {
            using (var contexto = new UniversidadeContext())
            {
                contexto.Professor.Add(professor);
                contexto.SaveChanges();
            }
        }
    }
}