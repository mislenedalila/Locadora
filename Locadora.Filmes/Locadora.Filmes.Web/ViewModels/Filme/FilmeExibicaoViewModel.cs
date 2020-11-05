using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Locadora.Filmes.Web.ViewModels.Filme
{
    public class FilmeExibicaoViewModel
    {
        public int IdFilme { get; set; }
        [Display(Name = "Nome do Filme")]
        public string NomeFilme { get; set; }
        [Display(Name = "Nome do álbum")]
        public string NomeAlbum { get; set; }
    }
}