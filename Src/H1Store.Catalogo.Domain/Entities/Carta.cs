using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace H1Store.Catalogo.Domain.Entities
{
	public class Carta
	{

        #region 1 - Contrutores

        public Carta(string nomeCrianca, int idade, string rua, string bairro, string cidade, string estado, int numero, string textoCarta)
        {
            NomeCrianca = nomeCrianca;
            Idade = idade;
            Rua = rua;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Numero = numero;
            TextoCarta = textoCarta;
        }

        public Carta(int id, string nomeCrianca, int idade, string rua, string bairro, string cidade, string estado, int numero, string textoCarta)
        {
            Id = id;
            NomeCrianca = nomeCrianca;
            Idade = idade;
            Rua = rua;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Numero = numero;
            TextoCarta = textoCarta;
        }

        #endregion

        #region 2 - Propriedades

        public int Id { get; private set; }

        public string NomeCrianca { get; private set; }
        
		public int Idade { get; private set; }

        public string Rua { get; private set; }

        public string Bairro { get; private set; }

        public string Cidade { get; private set; }

        public string Estado { get; private set; }

        public int Numero { get; private set; }

        public string TextoCarta { get; private set; }

        #endregion

        #region 3 - Comportamentos

		#endregion
	}
}
