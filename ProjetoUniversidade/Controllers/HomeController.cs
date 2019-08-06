using ProjetoUniversidade.DAL;
using ProjetoUniversidade.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoUniversidade.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var professorDAO = new ProfessorDAO();
            var materiaDAO = new MateriaDAO();
            var professorMateriaDAO = new ProfessorMateriaDAO();
            var professores = professorDAO.Listar();
            var materias = materiaDAO.Listar();
            var professorMaterias = professorMateriaDAO.Listar();

            if (!professores.Any())
            {
                CriarDB();

                professores = professorDAO.Listar();
                materias = materiaDAO.Listar();
                professorMaterias = professorMateriaDAO.Listar();
            }

            ViewBag.Professores = professores;
            ViewBag.Materias = materias;
            ViewBag.ProfessoresMaterias = professorMaterias;

            return View();
        }

        public ActionResult Professores()
        {
            var professorDAO = new ProfessorDAO();
            var professores = professorDAO.Listar();

            ViewBag.Professores = professores;

            return View();
        }

        public ActionResult Materias()
        {
            var materiaDAO = new MateriaDAO();
            var materias = materiaDAO.Listar();

            ViewBag.Materias = materias;

            return View();
        }

        private void CriarDB()
        {
            ProfessorDAO.CriarProfessores();
            MateriaDAO.CriarMaterias();
            ProfessorMateriaDAO.CriarRelacionamentoInicial();
        }

        [HttpPost]
        public ActionResult AddProfessor(Professor professor)
        {
            professor.DataInicio = DateTime.Now.ToString("dd/MM/yyyy");
            DateTime.TryParse(professor.DtNascimento, out DateTime dataNascimento);
            professor.DtNascimento = dataNascimento.ToString("dd/MM/yyyy");
            ProfessorDAO professorDAO = new ProfessorDAO();
            professorDAO.AdicionaProfessor(professor);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult AddMateria(Materia materia)
        {
            MateriaDAO materiaDAO = new MateriaDAO();
            materiaDAO.AdicionaMateria(materia);
            return RedirectToAction("Index");
        }
    }
}