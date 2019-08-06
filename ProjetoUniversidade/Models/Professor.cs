using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoUniversidade.Models
{
    public class Professor
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome do produto é obrigatório."), MinLength(4, ErrorMessage = "Nome deve conter no mímino 4 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Nome do produto é obrigatório."), MinLength(4, ErrorMessage = "Sobrenome deve conter no mímino 4 caracteres.")]
        public string Sobrenome { get; set; }
        public string DtNascimento { get; set; }
        public string Telefone { get; set; }
        public string DataInicio { get; set; }
        public string Email { get; set; }
        public string Especialidade { get; set; }
        public string Hobbie { get; set; }
    }
}