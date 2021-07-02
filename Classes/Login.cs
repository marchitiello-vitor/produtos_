using System;
using Projeto_marcas.Classes.Interfaces;

namespace Projeto_marcas.Classes
{
    public class Login : ILogin
    {
        private bool logado = false;
        public bool Logado
        {
            get { return logado; }
            set { logado = value; }
        }

        public Login()
        {

        }

        public string Logar()
        {   
            Logado = false;
            Console.WriteLine($@"
_________________________
| 1 - Cadastrar usuario 
| 2 - Cadastrar marca   
| 3 - Cadastrar Produto 
| 4 - Listar marcas     
| 5 - Listar Produtos   
| 6 - Listar Usuarios
| 7 - Deletar marca     
| 8 - Deletar produto   
| 9 - Deletar usuario   
| 0 - Deslogar          
");
            return "";
        }
        public string Deslogar()
        {
            Logado = true;
            Console.Write("obrigado ;)");
            return "flw";
        }
    }
}