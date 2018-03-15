using HandsOnChatBotWebAPI.DAO;
using Loja.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HandsOnChatBotWebAPI.Controllers
{
    public class ProdutoController : ApiController
    {
        [Route("api/Produto/{animal},{porte}")]
        public List<Produto> Get(int animal, int porte)
        {
            var dao = new ProdutoDAO();
            var carrinho = dao.BuscaProdutos(animal,porte);
            return carrinho;
        }
        [Route("api/Produto/{animal}")]
        public List<Produto> Get(int animal)
        {
            var dao = new ProdutoDAO();
            var carrinho = dao.BuscaAnimal(animal);
            return carrinho;
        }

        [Route("api/Produto/")]
        public List<Produto> Get()
        {
            var dao = new ProdutoDAO();
            var carrinho = dao.BuscaTodos();
            return carrinho;
        }
    }
}
