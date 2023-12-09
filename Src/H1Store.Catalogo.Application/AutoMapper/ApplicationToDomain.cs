using AutoMapper;
using H1Store.Catalogo.Application.ViewModels;
using H1Store.Catalogo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1Store.Catalogo.Application.AutoMapper
{
	public class ApplicationToDomain : Profile
	{
		public ApplicationToDomain()
		{

			CreateMap<CartaViewModel, Carta>()
			   .ConstructUsing
			   (q => new Carta(
				q.CartaId,
				q.NomeCrianca, 
				q.Idade, 
				q.Rua, 
				q.Bairro, 
				q.Cidade, 
				q.Estado, 
				q.Numero, 
				q.TextoCarta));

            CreateMap<NovaCartaViewModel, Carta>()
               .ConstructUsing
               (q => new Carta(
                q.NomeCrianca,
                q.Idade,
                q.Rua,
                q.Bairro,
                q.Cidade,
                q.Estado,
                q.Numero,
                q.TextoCarta));

        }
	}
}
