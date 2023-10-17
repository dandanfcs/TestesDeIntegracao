using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TestesDeIntegracao.Models;
using TestesDeIntegracao.Services;

namespace TestesDeIntegracao.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly ProdutoService _produtoService;
        public ProdutoController(ProdutoService produtoService)
        {
            _produtoService = produtoService;
        }
        [HttpGet]
        public List<Produto> ListarProdutos()
        {
            var listaDeProdutos = _produtoService.ListarProdutos();
            return listaDeProdutos;
        }

        [HttpPost]
        public async Task<IActionResult> InscrverEmExtensao(Produto produto)
        {
            await _produtoService.AdicionarProduto(produto);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> AtualizarProduto(Produto produto)
        {
            await _produtoService.AtualizarProduto(produto);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> ExcluirProduto(int id)
        {
            await _produtoService.ExcluirProduto(id);
            return Ok();
        }
    }
}
