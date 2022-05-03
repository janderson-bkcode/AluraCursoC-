namespace A._4_DesignaPatternsDecorator
{  
    // Aula04 alterou Inteface para Classe abstrata
    //Aplicação do Design Pattern Decorator
    public abstract class Imposto
    {
        //Adcionando propriedade que representa OutroImposto
        public Imposto OutroImposto { get; set; }

        //Adcionando construtor onde a abstração Imposto guarda outro imposto

        public Imposto(Imposto outroImposto)
        {
            this.OutroImposto = outroImposto;
        }
        //Construtor padrão para inicializar OutroImposto = null
        //Para não obrigar a sempre colocar um objeto Imposto no paramêtro
        //Sempre que instanciar new Imposto = new ISS(null)
        // No metodo CalculoDoOutroImposto() usamos essa lógica
        public Imposto()
        {
            OutroImposto = null;
        }
        public abstract double Calcula(Orcamento orcamento);

        /// <summary>
        /// Método para lógica do Decorator 
        /// Chamando o calculo do próximo Imposto que deve  ser um tipo de 
        /// <see cref="Imposto"/>
        /// </summary>
        /// <param name="orcamento"></param>
        /// <returns></returns>
        protected double CalculoDoOutroImposto(Orcamento orcamento)
        {
            //Imposto sendo null no construtor padrão sem passar paramentro retorna zero
            if(OutroImposto == null)return 0;
            return OutroImposto.Calcula(orcamento);
        }

    }
}