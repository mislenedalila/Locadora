using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Locadora.Filmes.Web.ViewModels.Filme
{
    public class FilmeViewModel
    {
        [Required(ErrorMessage = "Id é obrigatório")]
        public int IdFilme { get; set; }

        [Required(ErrorMessage = "Nome é obrigatório")]
        [Display(Name = "Nome do Filme")]
        public string NomeFilme { get; set; }

        [Required(ErrorMessage = "Selecione um álbum válido")]
        [Display(Name = "Nome do Álbum")]
        public int IdAlbum { get; set; }
    }
}