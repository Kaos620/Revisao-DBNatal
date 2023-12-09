using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1Store.Catalogo.Application.ViewModels
{
	public class CartaViewModel
	{

        public int CartaId { get; set; }

        public string NomeCrianca { get; set; }

        public string Rua { get; set; }

        public string Bairro { get; set; }


        public string Cidade { get; set; }


        public string Estado { get; set; }

        public int Numero { get; set; }


        public int Idade { get; set; }

        public string TextoCarta { get; set; }
    }
}
