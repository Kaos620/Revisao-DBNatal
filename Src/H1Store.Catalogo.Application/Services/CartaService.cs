using AutoMapper;
using H1Store.Catalogo.Application.Interfaces;
using H1Store.Catalogo.Application.ViewModels;
using H1Store.Catalogo.Domain.Entities;
using H1Store.Catalogo.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1Store.Catalogo.Application.Services
{
	public class CartaService : ICartaService
	{
		#region - Construtores

		private readonly ICartaRepository _cartaRepository;
		private readonly IMapper _mapper;

        public CartaService(ICartaRepository cartaRepository, IMapper mapper)
        {
            _cartaRepository = cartaRepository;
            _mapper = mapper;
        }

        #endregion

        #region - Funções
        public async Task Adicionar(NovaCartaViewModel novaCartaViewModel)
		{
			var novaCarta = _mapper.Map<Carta>(novaCartaViewModel);
			await _cartaRepository.Adicionar(novaCarta);

		}

		public async Task<IEnumerable<CartaViewModel>> ObterTodos()
		{
			var cartas = await _cartaRepository.ObterTodos();

            return _mapper.Map<IEnumerable<CartaViewModel>>(cartas);
		}
		#endregion
	}
}
