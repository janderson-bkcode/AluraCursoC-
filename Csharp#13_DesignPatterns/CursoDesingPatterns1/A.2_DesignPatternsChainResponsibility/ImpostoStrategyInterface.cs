namespace A._2_DesignPatternsChainResponsibility
{   /// <summary>
    /// Interface que funciona como StrategyInterface do Design Pattern Strategy
    /// e define a assinatura do Metodo para Calcular o orçamento
    /// </summary>
    /// 
    public interface ImpostoStrategyInterface
    {
        /// <summary>
        /// Assinatura de Método que deve ser implementado pelas classes filhas,
        /// Recebe um parâmetro do tipo double <paramref name="orcamento"/>
        /// </summary>
        /// <param name="orcamento">Representa o valor em reais do orçamento do cliente  </param>
        /// <returns></returns>
        double Calcula(Orcamento orcamento);

    }
}