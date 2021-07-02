using System;
using System.Collections.Generic;
using Projeto_marcas.Classes.Interfaces;

namespace Projeto_marcas.Classes
{
    public class Marca : IMarca
    {
        public int codigo;
        public string nomeMarca;
        public DateTime dataCadastro;
        public List<Marca> listaDeMarcas = new List<Marca>();

        public Marca() {}

        public Marca(string _nomeMarca)
        {
            Random r = new Random();
            this.codigo = r.Next(9999);
            this.nomeMarca = _nomeMarca;

            dataCadastro = DateTime.Now;
        }
        public string CadastrarMarca()
        {
            return "Marca registrada";
        }

        public string ListarMarca()
        {
            return "Marcas listadas!";
        }

        public string DeletarMarca()
        {
            return "Marca deletado!";
        }
    }
}