using ProjetoUniversidade.Models;
using ProjetoUniversidade.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoUniversidade.DAL
{
    public class ProfessorMateriaDAO
    {
        public static void CriarRelacionamentoInicial()
        {
            using (var contexto = new UniversidadeContext())
            {
                LeitorJSON<ProfessorMateria>.LerJson("ProfessorMaterias.json").ForEach(a => contexto.ProfessorMateria.Add(a));
                contexto.SaveChanges();
            }
        }

        public object Listar()
        {
            using (var contexto = new UniversidadeContext())
            {
                return contexto.ProfessorMateria.ToList();
            }
        }
    }
}