using System;

namespace A._9_DesignPattern_Facades_e_Singletons
{
    internal class ClienteDao : ICliente
    {
        public ClienteDao()
        {
        }

        public string Nome { get; set; }
        public string Endereco { get; set ; }
        public DateTime DataDeNascimento { get ; set; }

        internal ICliente BuscaPorCpf(string cpf)
        {
            throw new NotImplementedException();
        }
    }
}