namespace A._7_DesignPatternsObserver
{
    public class ItemDaNota
    {
        public string Descricao { get; set; }
        public double Valor { get; set; }

        public ItemDaNota(string descricao, double valor)
        {
            Descricao = descricao;
            Valor = valor;
        }


    }
}