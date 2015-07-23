using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; //Mapeamento

namespace Site.Models
{
    public class ClienteModel
    {
        //Propriedades para cada campo do Formulário:
        [Required(ErrorMessage = "Por favor, informe o seu nome.")]
        [Display(Name = "Nome:")]
        public string Nome { get; set; }

        [Required(ErrorMessage="Por favor, informe o seu email")]
        [Display(Name= "Email:")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Por favor, informe sexo.")]
        [Display(Name = "Sexo:")]
        public string Sexo { get; set; }

        [Required(ErrorMessage = "Por favor, informe sua Data de Nascimento")]
        [Display(Name = "Data de Nascimento:")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage="Por favor, informe o Logradouro")]
        [Display(Name="Logradouro:")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "Por favor, informe a Cidade")]
        [Display(Name = "Cidade:")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Por favor, informe o Estado")]
        [Display(Name = "Estado:")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "Por favor informe o Tipo da Residencia")]
        [Display(Name = "Tipo de Endereco:")]
        public string Tipo { get; set; }

    }
}