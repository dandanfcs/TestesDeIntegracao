using Microsoft.EntityFrameworkCore;
using TestesDeIntegracao.Data;
using TestesDeIntegracao.Models;

namespace TestesDeIntegracao.Services
{
    public class ProdutoService
    {
        private readonly ProdutoDbContext _context;

        public ProdutoService(ProdutoDbContext context)
        {
            _context = context;
        }

        public async Task AdicionarProduto(Produto produto)
        {
            _context.Produtos.Add(produto);
            await _context.SaveChangesAsync();
        }

        public async Task AtualizarProduto(Produto Produto)
        {
            _context.Produtos.Update(Produto);
            await _context.SaveChangesAsync();
        }
        public List<Produto> ListarProdutos()
        {
            var extensoes = _context.Produtos.ToList();
            return extensoes;
        }

        public async Task ExcluirProduto(int id)
        {
            var Produto = await _context.Produtos.FindAsync(id);
            if (Produto != null)
            {
                _context.Produtos.Remove(Produto);
                await _context.SaveChangesAsync();
            }
        }
    }
}
