using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LojaGames.Models
{
    public class Funcionario
    {
        [Display(Name = "Código do Funcionário:")]
        [Required(ErrorMessage = "Insira um código")]
        public int FuncCod { get; set; }

        [Display(Name = "Nome:")]
        [Required(ErrorMessage = "Insira o nome")]
        public string FuncNome { get; set; }

        [Display(Name = "CPF:")]
        [Required(ErrorMessage = "Insira o número do CPF")]
        public string FuncCpf { get; set; }

        [Display(Name = "RG:")]
        [Required(ErrorMessage = "Insira o número do RG")]
        public string FuncRg { get; set; }

        [Display(Name = "Data de Nascimento:")]
        [Required(ErrorMessage = "Insira a data de nascimento")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FuncDtNasc
        {
            get
            {
                return this.funcDtNasc.HasValue ? this.funcDtNasc.Value : DateTime.Now;
            }
            set
            {
                this.FuncDtNasc = value;
            }
        }
        private DateTime? funcDtNasc = null;

        [Display(Name = "Endereço:")]
        [Required(ErrorMessage = "Insira o endereço")]
        public string FuncEnd { get; set; }

        [Display(Name = "Número de Celular:")]
        [Required(ErrorMessage = "Insira o número de celular")]
        public string FuncCel { get; set; }

        [Display(Name = "E-mail:")]
        [Required(ErrorMessage = "Insira o e-mail")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Email inválido")]
        public string FuncEmail { get; set; }

        [Display(Name = "Cargo:")]
        [Required(ErrorMessage = "Insira o cargo")]
        public string FuncCargo { get; set; }
    }
}