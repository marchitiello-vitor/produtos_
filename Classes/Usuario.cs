using System;
using System.Collections.Generic;
using Projeto_marcas.Classes.Interfaces;

namespace Projeto_marcas.Classes
{
    public class Usuario : IUsuario
    {
        public int codigo;
        public string nomeUsuario;
        public string emailUsuario;
        public string senha;
        public DateTime dataCadastro;
        public List<Usuario> listaDeUsuario = new List<Usuario>();

        public Usuario() {}

        public Usuario(string _nomeUsuario, string _email, string _senha)
        {
            Random r = new Random();
            this.codigo = r.Next(9999);
            this.nomeUsuario = _nomeUsuario;
            this.emailUsuario = _email;
            this.senha = _senha;

            dataCadastro = DateTime.Now;
        }

        public string CadastrarUsuario()
        {
            return "Usuario cadastrado!";
        }

        public string DeletarUsuario()
        {
            return "Usuario deletado!";
        }
    }
}