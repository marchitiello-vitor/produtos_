using System;
using System.Collections.Generic;
using Projeto_marcas.Classes.Interfaces;

namespace Projeto_marcas.Classes
{
    public class Produto : IProduto
    {
        public int codigo;
        public string nomeProduto;
        public float precoProduto;
        public DateTime dataCadastro;
        public Marca marca;
        public Usuario cadastradoPor;
        public List<Produto> listaDeProdutos = new List<Produto>();

        public Produto() {}

        public Produto(string _nomeProduto, float _preco)
        {
            Random ra = new Random();
            this.codigo = ra.Next(9999);
            this.nomeProduto = _nomeProduto;
            this.precoProduto = _preco;

            dataCadastro = DateTime.Now;
        }

        public string CadastrarProduto()
        {

            return "Produto cadastrado!";
        }

        public void ListarProduto()
        {

        }

        public string DeletarProduto()
        {
            return "Produto deletado!";
        }
    }
}