using H1Store.Catalogo.Application.Interfaces;
using H1Store.Catalogo.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace H1Store.Catalogo.API.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class CartaController : ControllerBase
	{
		private readonly ICartaService _cartaService;

		public CartaController(ICartaService cartaService)
		{
			_cartaService = cartaService;
		}

		[HttpPost(Name = "Adicionar")]
		public async Task<IActionResult> Post(NovaCartaViewModel novaCartaViewModel)
		{
			await _cartaService.Adicionar(novaCartaViewModel);

			return Ok();
		}


		[HttpGet(Name = "ObterTodos")]
		public async Task<IActionResult> Get()
		{
			var cartas = await _cartaService.ObterTodos();

            return Ok(cartas);
		}
	}
}
