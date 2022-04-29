using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.Modelos
{
    public class ParceiroComercial : IAutenticavel
    {
        private AutenticacaoHelper _autenticacaoHelper = new AutenticacaoHelper();

        public string Senha { get; set; }

        public bool Autenticar(string senha)
        {
            //return Senha == senha;
            return _autenticacaoHelper.CompararSenhas(Senha, senha);
        }
    }
}