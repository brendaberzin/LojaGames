using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LojaGames.Models
{
    public class Cliente
    {
        [Display(Name = "Nome:")]
        [Required(ErrorMessage = "Insira o nome")]
        public string CliNome { get; set; }

        [Display(Name = "CPF:")]
        [Required(ErrorMessage = "Insira o número do CPF")]
        public string CliCpf { get; set; }

        [Display(Name = "Data de Nascimento:")]
        [Required(ErrorMessage = "Insira a data de nascimento")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime CliDtNasc
        {
            get
            {
                return this.funcDtNasc.HasValue ? this.funcDtNasc.Value : DateTime.Now;
            }
            set
            {
                this.funcDtNasc = value;
            }
        }
        private DateTime? funcDtNasc = null;

        [Display(Name = "E-mail:")]
        [Required(ErrorMessage = "Insira o e-mail")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Email inválido")]
        public string CliEmail { get; set; }

        [Display(Name = "Número de Celular:")]
        [Required(ErrorMessage = "Insira o número de celular")]
        public string CliCel { get; set; }

        [Display(Name = "Endereço:")]
        [Required(ErrorMessage = "Insira o endereço")]
        public string CliEnd { get; set; }
    }
}