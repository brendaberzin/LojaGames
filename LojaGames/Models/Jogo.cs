using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LojaGames.Models
{
    public class Jogo
    {
        [Display(Name = "Código do Jogo:")]
        [Required(ErrorMessage = "Insira um código")]
        public int JogoCod { get; set; }

        [Display(Name = "Nome:")]
        [Required(ErrorMessage = "Insira o nome")]
        public string JogoNome { get; set; }

        [Display(Name = "Versão:")]
        public string JogoVersao { get; set; }

        [Display(Name = "Desenvolvedor:")]
        [Required(ErrorMessage = "Insira o desenvolvedor")]
        public string JogoDev { get; set; }

        [Display(Name = "Gênero:")]
        [Required(ErrorMessage = "Insira o gênero do jogo")]
        public string JogoGen { get; set; }

        [Display(Name = "Faixa Etária:")]
        [Required(ErrorMessage = "Insira a faixa etária")]
        public string JogoFxEt { get; set; }

        [Display(Name = "Plataforma:")]
        [Required(ErrorMessage = "Insira a plataforma")]
        public string JogoPlat { get; set; }

        [Display(Name = "Ano de Lançamento:")]
        [Required(ErrorMessage = "Insira o ano")]
        public string JogoAnoLanc { get; set; }

        [Display(Name = "Sinopse:")]
        [Required(ErrorMessage = "Insira a sinopse")]
        public string JogoSin { get; set; }
    }
}