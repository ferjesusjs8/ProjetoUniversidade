using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjetoUniversidade.Models
{
    public class Materia
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome é obrigatório."), MinLength(5, ErrorMessage = "Nome da disciplina deve conter no mímino 5 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Descrição é obrigatório."), MinLength(5, ErrorMessage = "Descrição deve conter no mímino 5 caracteres.")]
        public string Descricao { get; set; }
    }
}