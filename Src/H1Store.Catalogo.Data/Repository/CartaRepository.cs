using H1Store.Catalogo.Data.EntityFramework;
using H1Store.Catalogo.Domain.Entities;
using H1Store.Catalogo.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1Store.Catalogo.Data.Repository
{
	public class CartaRepository : ICartaRepository
	{
		private readonly Context _context;

		#region - Construtores
		public CartaRepository(Context context)
        {
            _context = context;
        }



        #endregion

        #region - Funções

        public async Task Adicionar(Carta carta)
        {
            try
            {
                await _context.Carta.AddAsync(carta);
                await _context.SaveChangesAsync();
            }

            catch (Exception ex)
            {
                throw new Exception($"Erro ao inserir a carta: {ex.Message}");
            }
        }

        public async Task<IEnumerable<Carta>> ObterTodos()
        {
            try
            {
                return await _context.Carta.ToListAsync();
            }

            catch (Exception ex)
            {
                throw new Exception($"Erro ao inserir a carta: {ex.Message}");
            }
        }

        #endregion

        #region - Métodos arquivo
        //private List<Carta> LerCartasDoArquivo()
        //{
        //	if (!System.IO.File.Exists(_cartaCaminhoArquivo))
        //		return new List<Carta>();
        //	string json = System.IO.File.ReadAllText(_cartaCaminhoArquivo);
        //	return JsonConvert.DeserializeObject<List<Carta>>(json);
        //}

        //private void EscreverCartaNoArquivo(List<Carta> cartas)
        //{
        //	string json = JsonConvert.SerializeObject(cartas);
        //	System.IO.File.WriteAllText(_cartaCaminhoArquivo, json);
        //}

        #endregion


    }
}
