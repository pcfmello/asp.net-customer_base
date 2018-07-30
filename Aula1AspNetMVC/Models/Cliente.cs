using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Aula1AspNetMVC.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(150, ErrorMessage = "Máximo de caracteres excedido")]
        [MinLength(2, ErrorMessage = "Mínimo de 2 caracteres")]
        [Display(Name = "Nome do Cliente")]
        [Required(ErrorMessage = "Preencha o nome")]
        public string Nome { get; set; }

        [MaxLength(150, ErrorMessage = "Máximo de caracteres excedido")]
        [MinLength(2, ErrorMessage = "Mínimo de 2 caracteres")]
        [Display(Name = "Sobrenome do Cliente")]
        [Required(ErrorMessage = "Preencha o sobrenome")]
        public string Sobrenome { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        [MaxLength(150, ErrorMessage = "Máximo de caracteres excedido")]
        [MinLength(2, ErrorMessage = "Mínimo de 2 caracteres")]
        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "Preencha o e-mail")]
        [EmailAddress(ErrorMessage = "Preencha um e-mail com formato inválido")]
        public string Email { get; set; }

    }
}