using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._3_DesignPatternsMemento
{
    internal class Contrato
    {
        public DateTime Data { get; private set; }

        public String Cliente { get; private set; }

        public TipoContrato Tipo { get; private set; }


        public Contrato(DateTime date, string cliente, TipoContrato tipo)
        {
            Data = date;
            Cliente = cliente;
            Tipo = tipo;
        }   

        /// <summary>
        /// Método com propósito de mudar o estado do contrato
        /// </summary>
        public void Avanca()
        {
            if (this.Tipo == TipoContrato.Novo) this.Tipo = TipoContrato.EmAndamento;
            else if (this.Tipo == TipoContrato.EmAndamento) this.Tipo = TipoContrato.Acertado;
            else if (this.Tipo == TipoContrato.Acertado) this.Tipo = TipoContrato.Concluido;

        }

        /// <summary>
        /// Método para Salvar o estado do Contrato
        /// </summary>
        /// <returns></returns>
        public Estado SalvaEstado()
        {
            return new Estado(new Contrato(this.Data,this.Cliente,this.Tipo));
        }

        public void Restaura(Estado estado)
        {
            this.Data = estado.Contrato.Data;
            this.Cliente = estado.Contrato.Cliente;
            this.Tipo = estado.Contrato.Tipo;
        }
    }


}

