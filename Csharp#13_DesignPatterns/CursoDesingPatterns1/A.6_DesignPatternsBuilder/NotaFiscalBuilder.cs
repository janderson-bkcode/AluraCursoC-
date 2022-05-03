using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace A._6_DesignPatternsBuilder
{   /// <summary>
/// Classe que funciona como Desing Pattern Builder
/// e tem função de criar a classe <see cref="NotaFiscal"/>.
/// Classe Builder é um Pattern  que ajuda a criar uma outra classe complicada.
///
/// </summary>
    public class NotaFiscalBuilder
    {
        public String RazaoSocial { get; private set; }
        public String Observacoes { get; private set; }
        public String Cnpj { get; private set; }
        public DateTime Data { get; private set; }


        private double valorTotal;
        private double impostos;
        private IList<ItemDaNota> todosItens = new List<ItemDaNota>();

        public NotaFiscalBuilder()
        {
            this.Data = DateTime.Now;
        }

        public NotaFiscalBuilder NaData(DateTime novadata)
        {
            this.Data = novadata;
            return this;
        }

        public NotaFiscal Constroi()
        {
            return new NotaFiscal(RazaoSocial, Cnpj, Data, valorTotal, impostos, todosItens, Observacoes);
        }


        public NotaFiscalBuilder ParaEmpresa(String razaoSocial)
        {
            this.RazaoSocial = razaoSocial;
            return this;
        }

        public NotaFiscalBuilder ComCnpj(String cnpj)
        {
            this.Cnpj = cnpj;
            return this;
        }
        public NotaFiscalBuilder Com(ItemDaNota item)
        {
            todosItens.Add(item);
            valorTotal += item.Valor;
            impostos += item.Valor * 0.05;
            return this;
        }
        public NotaFiscalBuilder ComObservacoes(String observacoes)
        {
            this.Observacoes = observacoes;
            return this;
        }

        public NotaFiscalBuilder NaDataAtual()
        {
            this.Data = DateTime.Now;
            return this;
        }

    }
}