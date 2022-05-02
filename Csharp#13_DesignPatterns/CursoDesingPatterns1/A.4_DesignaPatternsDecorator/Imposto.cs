namespace A._4_DesignaPatternsDecorator
{  
    // Aula04 alterou Inteface para Classe abstrata
    //Aplicação do Design Pattern Decorator
    public abstract class Imposto
    {

        public Imposto OutroImposto { get; set; }

        public Imposto(Imposto outroImposto)
        {
            this.OutroImposto = outroImposto;
        }

        public Imposto()
        {
            OutroImposto = null;
        }
        public abstract double Calcula(Orcamento orcamento);


        protected double CalculoDoOutroImposto(Orcamento orcamento)
        {
            if(OutroImposto == null)return 0;
            return OutroImposto.Calcula(orcamento);
        }

    }
}