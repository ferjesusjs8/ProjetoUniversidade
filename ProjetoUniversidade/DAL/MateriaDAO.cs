using ProjetoUniversidade.Models;
using ProjetoUniversidade.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoUniversidade.DAL
{
    public class MateriaDAO
    {
        public IList<Materia> Listar()
        {
            using (var contexto = new UniversidadeContext())
            {
                return contexto.Materia.ToList();
            }
        }

        public static void CriarMaterias()
        {
            using (var contexto = new UniversidadeContext())
            {
                LeitorJSON<Materia>.LerJson("Materias.json").ForEach(m => contexto.Materia.Add(m));
                contexto.SaveChanges();
            }
        }

        public void AdicionaMateria(Materia materia)
        {
            using (var contexto = new UniversidadeContext())
            {
                contexto.Materia.Add(materia);
                contexto.SaveChanges();
            }
        }
    }
}