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
        public Produto Get(int id)
        {
            var dao = new ProdutoDAO();
            var carrinho = dao.Busca(id);
            return carrinho;
        }
    }
}
